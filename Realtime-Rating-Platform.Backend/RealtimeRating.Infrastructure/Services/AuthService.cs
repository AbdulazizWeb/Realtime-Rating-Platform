using Microsoft.EntityFrameworkCore;
using RealtimeRating.Application.Abstractions;
using RealtimeRating.Infrastructure.Abstractions;
using RealtimeRating.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtimeRating.Infrastructure.Services
{
    public class AuthService : IAuthService
    {

        private readonly ApplicationDbContext _dbContext;
        private readonly ITokenService _tokenService;
        private readonly IHashProvider _hashProvider;

        public AuthService(ApplicationDbContext dbContext, ITokenService tokenService, IHashProvider hashProvider)
        {
            _dbContext = dbContext;
            _tokenService = tokenService;
            _hashProvider = hashProvider;
        }

        public async Task<string> LoginAsync(string email, string password)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Email == email);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (user.PasswordHash != _hashProvider.GetHash(password))
            {
                throw new Exception("Password is wrong");
            }

            return _tokenService.GenerateAccessToken(user);
        }
    }
}
