namespace MiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlankMigrationForAdminRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"
    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2d19f88c-d474-4f7f-9f05-5fab85ae9af1', N'Admin')
   
    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FullName], [DOB], [Gender], [isAdmin]) VALUES (N'96deb67c-8fc8-4f72-8204-a51502d71947', N'guest@mail.com', 0, N'AAKfq4NDb25K5SOCKuPiE0snGY9r1dpA/Wu8SYx4yjEa5xJKHxvNsZl16cODt0NeYg==', N'749c4a33-523b-4a85-96ad-f4fb81a40750', NULL, 0, 0, NULL, 1, 0, N'guest@mail.com', N'', N'1900-01-01 00:00:00', N'', 0)
    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FullName], [DOB], [Gender], [isAdmin]) VALUES (N'fdb36f72-6eab-4320-912c-16e17f85d476', N'admin@mail.com', 0, N'AEwZIk3O7qYWkqjJ+KVZhYbsmUQyxzxYD7V6HVR41+Zd29WOniqd0oruXPr0nR4wug==', N'2ef6967a-8acb-4d65-a242-c432705bfb27', NULL, 0, 0, NULL, 1, 0, N'admin@mail.com', N'', N'1900-01-01 00:00:00', N'', 0)
     INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fdb36f72-6eab-4320-912c-16e17f85d476', N'2d19f88c-d474-4f7f-9f05-5fab85ae9af1')
");
        }
        
        public override void Down()
        {
        }
    }
}
