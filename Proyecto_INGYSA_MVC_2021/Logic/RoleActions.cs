using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_INGYSA_MVC_2021.Models;
using Proyecto_INGYSA_MVC_2021.Areas;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace Proyecto_INGYSA_MVC_2021.Logic
{
    internal class RoleActions 
    {
        internal void AddUserAndRole()
        {
            INGYSA_DB_Context context = new INGYSA_DB_Context();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            // Create a RoleStore object by using the ApplicationDbContext object. 
            // The RoleStore is only allowed to contain IdentityRole objects.
            var roleStore = new RoleStore<IdentityRole>(context);

            // Create a RoleManager object that is only allowed to contain IdentityRole objects.
            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            // Then, you create the "canEdit" role if it doesn't already exist.
            if (!roleMgr.RoleExists("admin"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "admin" });
            }

            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = "admin@ingysa.com",
                Email = "admin@ingysa.com"
            };

            IdUserResult = userMgr.Create(appUser, "1234");

            if (!userMgr.IsInRole(userMgr.FindByEmail("admin@ingysa.com").Id, "admin"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("admin@ingysa.com").Id, "admin");
            }
        }
    }
}