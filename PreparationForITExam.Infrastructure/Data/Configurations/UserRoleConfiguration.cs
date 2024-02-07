using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Configurations
{
    public class UserRoleConifiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(GiveUsersRoles());
        }

        private List<IdentityUserRole<string>> GiveUsersRoles()
        {
            var users = new List<IdentityUserRole<string>>();

            users.Add(new IdentityUserRole<string>()
            {
                RoleId = "0f761db2-ab55-416c-83b9-70abded3d908",
                UserId = "789061a9-edaa-4a00-9e09-add6a20c8288"
            });

            return users;
        }
    }
}
