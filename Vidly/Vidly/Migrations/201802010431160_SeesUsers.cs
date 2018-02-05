namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeesUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'17c0b1a8-3849-4f3e-9a58-451135a43a68', N'admin@vidly.com', 0, N'AKlfw802y4IabnDsgep3L2a5Gf7d4kptrA8tN0roYC4TxTxJeYmUScUn0VbSYyfOEQ==', N'8aa761d6-f6f9-4d22-aceb-887ebacc6e80', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ac551eed-6fc7-4141-a210-655c77afef8b', N'guest@vidly.com', 0, N'AJLzGpXPy7T47+Vz/xkMa+NLO8Tvz9BXeYWUsqs3Yj5MUlbXFfR2R42fWhf951aRUQ==', N'd4cf1166-fb7b-4d95-9080-271ae231f833', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4274b979-3f0e-453c-94a5-9040ef53693e', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'17c0b1a8-3849-4f3e-9a58-451135a43a68', N'4274b979-3f0e-453c-94a5-9040ef53693e')

");
        }
        
        public override void Down()
        {
        }
    }
}
