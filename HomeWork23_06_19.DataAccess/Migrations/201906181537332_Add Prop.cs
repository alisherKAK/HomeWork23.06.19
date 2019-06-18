namespace HomeWork23_06_19.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CatalogMoveTasks", "IsDone", c => c.Boolean(nullable: false));
            AddColumn("dbo.EmailSendTasks", "IsDone", c => c.Boolean(nullable: false));
            AddColumn("dbo.FileDownloadTasks", "IsDone", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FileDownloadTasks", "IsDone");
            DropColumn("dbo.EmailSendTasks", "IsDone");
            DropColumn("dbo.CatalogMoveTasks", "IsDone");
        }
    }
}
