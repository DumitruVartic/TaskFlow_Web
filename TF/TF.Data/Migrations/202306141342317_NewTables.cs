namespace TF.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class NewTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserNoteDbTables",
                c => new
                {
                    UserId = c.Guid(nullable: false),
                    NoteId = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.UserId);

            CreateTable(
                "dbo.UserDbTables",
                c => new
                {
                    Id = c.Guid(nullable: false),
                    Role = c.Int(nullable: false),
                    Username = c.String(nullable: false, maxLength: 50),
                    Password = c.String(nullable: false, maxLength: 50),
                    Email = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.UserTaskDbTables",
                c => new
                {
                    UserId = c.Guid(nullable: false),
                    TaskId = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.UserId);

        }

        public override void Down()
        {
            DropTable("dbo.UserTaskDbTables");
            DropTable("dbo.UserDbTables");
            DropTable("dbo.UserNoteDbTables");
        }
    }
}
