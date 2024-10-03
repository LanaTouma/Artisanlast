using Artisan.Application.ArtisansAppService;
using Artisan.Application.dtos;
using Artisan.Domain.Entities;
using Artisan.Infrastructure.Data;
using Artisan.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using Org.BouncyCastle.Crypto.Generators;

namespace Artisan.API.Controllers
{
    public class UsersController
    {

        //[Route("api/UsersController")]
        //[ApiController]

        public class UserController : ControllerBase
        {
            private readonly ArtisanDBContext _artisanDBContext; 

            public UserController(ArtisanDBContext context)
            {
                _artisanDBContext = context;
            }

            [HttpPost]
            [Route("api/Register")]
            public async Task<IActionResult> Register([FromBody] RegisterUserDto registerUserDto)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Check if user already exists
                var existingUser = await _artisanDBContext.Users.FirstOrDefaultAsync(u => u.Email == registerUserDto.Email);

                if (existingUser != null)
                {
                    return Conflict("User with this email already exists.");
                }

                // Create a new user instance
                var user = new Users
                {
                    FirstName = registerUserDto.FirstName,
                    LastName = registerUserDto.LastName,
                    Email = registerUserDto.Email,
                    Password = BCrypt.Net.BCrypt.HashPassword(registerUserDto.Password), // Hashing password for security
                    PhoneNumber = registerUserDto.PhoneNumber,
                    AlternativePhoneNumber = registerUserDto.AlternativePhoneNumber,
                    BirthDate = registerUserDto.BirthDate,
                    UserType = UserType.Customer, // Default user type
                    Status = UserStatus.Active, // Default status
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                };

                // Add user to the database
                _artisanDBContext.Users.Add(user);
                await _artisanDBContext.SaveChangesAsync();

                // Optionally return the created user (omit Password)
                return CreatedAtAction(nameof(Register), new { userId = user.UserId }, user);
            }
        }

    }
}
