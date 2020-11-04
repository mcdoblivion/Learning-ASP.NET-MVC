namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'553aaeab-c0ae-4f51-a3eb-30aa4b1c508e', N'admin@vidly.com', 0, N'AAXoLv9fKI5KyD/1X8p70hO8f5zd+dFpvBA8x4GCqYUM+1+j58s/3sgJtSeBVQD1hA==', N'7fd2b5de-c480-425e-a7f6-5a8465e2e912', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b77ae0ba-d15e-4674-be23-62dc54eaf598', N'mcd.oblivion@gmail.com', 0, N'ALQu3cjajqiDezKuLJ5dkQaALV3Wv8SEzprAcKwYNuKsomquwb1RsZuvgQZV0+ULnw==', N'574e1f38-6071-4215-8574-e335677ab0b2', NULL, 0, 0, NULL, 1, 0, N'mcd.oblivion@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6cd25251-0ad9-49aa-adc9-73fdbe74c7e4', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'553aaeab-c0ae-4f51-a3eb-30aa4b1c508e', N'6cd25251-0ad9-49aa-adc9-73fdbe74c7e4')
");
        }

        public override void Down()
        {
        }
    }
}