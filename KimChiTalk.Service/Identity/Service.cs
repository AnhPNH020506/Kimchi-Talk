// using Microsoft.EntityFrameworkCore;
// using Org.BouncyCastle.Crypto.Generators;
//
// namespace KimChiTalk.Service.Identity;
// using KimChiTalk.Repository;
// public class Service : IService
// {
//     private readonly AppDbContext _dbContext;
//     public Service(AppDbContext dbContext)
//     {
//         _dbContext = dbContext;
//     }
//     public async Task<Response.IdentityResponse> LoginRequest(Request.LoginRequest request)
//     {
//         var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
//         if (user == null)
//         {
//             throw new KeyNotFoundException("User not found");
//         }
//
//         if (!BCrypt.Net.BCrypt.Verify(request.Password, user.HashshedPassword))
//         {
//             throw new UnauthorizedAccessException("Invalid password");
//         }
//          
//     }
// }