using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UsuarioAluraFlix.Data
{
    public class UserDbContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
    {

        public UserDbContext(DbContextOptions<UserDbContext> opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //Criando usuario admin
            IdentityUser<int> admin = new IdentityUser<int>
            {
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                Id = 999999999
            };

            //criando usuario comum 
            IdentityUser<int> user = new IdentityUser<int>
            {
                UserName = "user",
                NormalizedUserName = "USER",
                NormalizedEmail = "USER@USER.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                Id = 999999998
            };
            //criando e adicionando senha do admin
            PasswordHasher<IdentityUser<int>> hasher1 = new PasswordHasher<IdentityUser<int>>();
            admin.PasswordHash = hasher1.HashPassword(admin, "Admin123!");
            //criando e adicionando senha do user
            PasswordHasher<IdentityUser<int>> hasher2 = new PasswordHasher<IdentityUser<int>>();
            user.PasswordHash = hasher2.HashPassword(user, "User123!");

            builder.Entity<IdentityUser<int>>().HasData(admin);
            builder.Entity<IdentityUser<int>>().HasData(user);

            //Criando role admin 
            builder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int> { Id = 999999999, Name = "admin", NormalizedName = "ADMIN" }
                );

            //Criando e  role regular
            builder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int> { Id = 999999998, Name = "regular", NormalizedName = "REGULAR" }
                );
            // adicionado role ao admin
            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int> { RoleId = 999999999, UserId = 999999999 }
                );
            //adicionando role ao user
            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int> { RoleId = 999999998, UserId = 999999998 }
                );
        }
    }
}