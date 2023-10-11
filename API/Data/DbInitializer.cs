using API.Entities;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class DbInitializer
    {
        public static async System.Threading.Tasks.Task Initialize(KanbanDbContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com",
                };
                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] { "Member","Admin" });
            }
            await context.SaveChangesAsync();
        }
    }
}
