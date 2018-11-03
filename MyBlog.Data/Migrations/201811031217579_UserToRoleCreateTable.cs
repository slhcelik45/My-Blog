namespace MyBlog.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserToRoleCreateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 16),
                        Gender = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        InsertDate = c.DateTime(nullable: false),
                        Image = c.String(maxLength: 250),
                        RolId = c.Int(nullable: false),
                        
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RolId)
                .Index(t => t.RolId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RolId", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "RolId" });
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}
