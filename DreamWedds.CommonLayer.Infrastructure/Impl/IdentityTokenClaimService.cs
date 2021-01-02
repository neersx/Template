using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.CommonLayer.Aspects.Constants;
using DreamWedds.PersistenceLayer.Entities.Entities;
using DreamWedds.PersistenceLayer.Entities.Specifications;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DreamWedds.PersistenceLayer.Repository.Repository;

namespace DreamWedds.CommonLayer.Infrastructure.Impl
{
    public class IdentityTokenClaimService : ITokenClaimsService
    {
        private readonly IAsyncRepository<UserMaster> _userRepository;
        private readonly IAsyncRepository<RoleMaster> _roleRepository;
        private readonly IAsyncRepository<UserRoles> _userRoleRepository;
        private readonly IConfiguration _configuration;
        public IdentityTokenClaimService(
             IConfiguration configuration,
            IAsyncRepository<UserMaster> userRepository,
            IAsyncRepository<RoleMaster> roleRepository,
            IAsyncRepository<UserRoles> userRoleRepository)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _userRoleRepository = userRoleRepository;
            _configuration = configuration;
        }

        public async Task<string> GetToken(int id)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration.GetValue<string>("AppSettings:Secret"));
            var user = await _userRepository.GetByIdAsync(id);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.FirstName + " " + user.LastName),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.MobilePhone, user.Mobile)
                }),
                Expires = DateTime.UtcNow.AddSeconds(_configuration.GetValue<int>("Tokens:Lifetime")),
                IssuedAt = DateTime.UtcNow,
                Issuer = "DreamWedds",
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public async Task<string> GetTokenAsync(int id)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(AuthorizationConstants.JWT_SECRET_KEY);
            var user = await _userRepository.GetByIdAsync(id);
            var specification = new UserRoleFilterSpecification(id);
            var role = _roleRepository.GetByIdAsync(_userRoleRepository.FirstOrDefaultAsync(specification).Result.RoleId).Result.Name;
            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, id.ToString()),
                new Claim(ClaimTypes.Name, user.FirstName + " " + user.LastName),
                new Claim(ClaimTypes.Email, user.Email)
            };
            claims.Add(new Claim(ClaimTypes.Role, role));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims.ToArray()),
                IssuedAt = DateTime.UtcNow,
                Issuer = "DreamWedds",
                Expires = DateTime.UtcNow.AddSeconds(_configuration.GetValue<int>("Tokens:Lifetime")),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}
