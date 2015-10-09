namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class School : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.School",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Teacher", "SchoolId", c => c.Int(nullable: false));
            CreateIndex("dbo.Teacher", "SchoolId");
            AddForeignKey("dbo.Teacher", "SchoolId", "dbo.School", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teacher", "SchoolId", "dbo.School");
            DropIndex("dbo.Teacher", new[] { "SchoolId" });
            DropColumn("dbo.Teacher", "SchoolId");
            DropTable("dbo.School");
        }
    }
}
