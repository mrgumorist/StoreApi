namespace StoreApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Inizialu = c.String(),
                        Login = c.String(),
                        PassWord = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
