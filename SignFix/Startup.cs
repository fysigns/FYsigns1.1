using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using SignFix.Models;


[assembly: OwinStartupAttribute(typeof(SignFix.Startup))]
namespace SignFix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }

        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            // creating Default Admin User
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }

            //HArdcoding Admin USer -- to implement work around later 

            var user = new ApplicationUser();
            user.UserName = "Jay";
            user.Email = "olatun98@gmail.com";
            string userPWD = "risa12345";

            var chkUser = userManager.Create(user, userPWD);

            //Add default User to Role Admin   
            if (chkUser.Succeeded)
            {
                var result1 = userManager.AddToRole(user.Id, "Admin");

            }

            // creating Creating Manager role    
            if (!roleManager.RoleExists("Contractor"))
            {
                var role = new IdentityRole();
                role.Name = "Contractor";
                roleManager.Create(role);

            }

            // creating Creating Employee role    
            if (!roleManager.RoleExists("Client"))
            {
                var role = new IdentityRole();
                role.Name = "Client";
                roleManager.Create(role);

            }

        }
    }
}
