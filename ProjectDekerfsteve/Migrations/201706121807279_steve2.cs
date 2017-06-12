namespace ProjectDekerfsteve.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class steve2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "SurName", c => c.String());
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
            AddColumn("dbo.AspNetUsers", "Birthdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Zipcode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Zipcode");
            DropColumn("dbo.AspNetUsers", "Birthdate");
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "SurName");
        }
    }
}
