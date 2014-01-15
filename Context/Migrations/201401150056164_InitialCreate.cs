namespace Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        Fornecedor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fornecedor", t => t.Fornecedor_Id)
                .Index(t => t.Fornecedor_Id);
            
            CreateTable(
                "dbo.ItemPedido",
                c => new
                    {
                        PedidoID = c.Int(nullable: false),
                        ProdutoID = c.Int(nullable: false),
                        quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PedidoID, t.ProdutoID })
                .ForeignKey("dbo.Pedido", t => t.PedidoID, cascadeDelete: true)
                .ForeignKey("dbo.Produto", t => t.ProdutoID, cascadeDelete: true)
                .Index(t => t.PedidoID)
                .Index(t => t.ProdutoID);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        Preco = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FornecedorProdutoes",
                c => new
                    {
                        Fornecedor_Id = c.Int(nullable: false),
                        Produto_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Fornecedor_Id, t.Produto_Id })
                .ForeignKey("dbo.Fornecedor", t => t.Fornecedor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Produto", t => t.Produto_Id, cascadeDelete: true)
                .Index(t => t.Fornecedor_Id)
                .Index(t => t.Produto_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.FornecedorProdutoes", new[] { "Produto_Id" });
            DropIndex("dbo.FornecedorProdutoes", new[] { "Fornecedor_Id" });
            DropIndex("dbo.ItemPedido", new[] { "ProdutoID" });
            DropIndex("dbo.ItemPedido", new[] { "PedidoID" });
            DropIndex("dbo.Pedido", new[] { "Fornecedor_Id" });
            DropForeignKey("dbo.FornecedorProdutoes", "Produto_Id", "dbo.Produto");
            DropForeignKey("dbo.FornecedorProdutoes", "Fornecedor_Id", "dbo.Fornecedor");
            DropForeignKey("dbo.ItemPedido", "ProdutoID", "dbo.Produto");
            DropForeignKey("dbo.ItemPedido", "PedidoID", "dbo.Pedido");
            DropForeignKey("dbo.Pedido", "Fornecedor_Id", "dbo.Fornecedor");
            DropTable("dbo.FornecedorProdutoes");
            DropTable("dbo.Produto");
            DropTable("dbo.ItemPedido");
            DropTable("dbo.Pedido");
            DropTable("dbo.Fornecedor");
        }
    }
}
