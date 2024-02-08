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

            users.Add(new IdentityUserRole<string>()
            {
                RoleId = "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                UserId = "7decfb7d-d2df-40a2-a449-dcec04eb091a"
            });

            users.Add(new IdentityUserRole<string>()
            {
                RoleId = "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b"
            });

            users.Add(new IdentityUserRole<string>()
            {
                RoleId = "71281cf3-9730-4d7e-acbb-213edee8291c",
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            });

            return users;
        }
    }
}
