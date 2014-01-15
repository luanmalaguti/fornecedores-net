namespace Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        username = c.String(nullable: false),
                        password = c.String(nullable: false),
                        TipoUsuario = c.Int(nullable: false),
                        Fornecedor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fornecedor", t => t.Fornecedor_Id)
                .Index(t => t.Fornecedor_Id);
            
            AddColumn("dbo.Fornecedor", "RazaoSocial", c => c.String(nullable: false));
            AddColumn("dbo.Fornecedor", "Cnpj", c => c.String(nullable: false));
            AddColumn("dbo.Fornecedor", "Telefone", c => c.String(nullable: false));
            AddColumn("dbo.Fornecedor", "Endereco", c => c.String(nullable: false));
            DropColumn("dbo.Fornecedor", "Nome");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fornecedor", "Nome", c => c.String(nullable: false));
            DropIndex("dbo.Usuario", new[] { "Fornecedor_Id" });
            DropForeignKey("dbo.Usuario", "Fornecedor_Id", "dbo.Fornecedor");
            DropColumn("dbo.Fornecedor", "Endereco");
            DropColumn("dbo.Fornecedor", "Telefone");
            DropColumn("dbo.Fornecedor", "Cnpj");
            DropColumn("dbo.Fornecedor", "RazaoSocial");
            DropTable("dbo.Usuario");
        }
    }
}
