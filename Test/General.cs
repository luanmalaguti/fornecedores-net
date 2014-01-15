using System;
using Context.DAO;
using NUnit.Framework;
using Model;
using Context;
using Assert = NUnit.Framework.Assert;

namespace Test
{
    [TestFixture]
    public class General
    {
        private FornecedoresContext db;
        
        [SetUp]
        public void setUp()
        {
            db = ConnProvider.getContext("db_fornecedores_test_2");
        }
      
        
        [Test]
        public void TestMethod1()
        {
            Fornecedor f = new Fornecedor()
                {
                    Nome = "Jerusalem",
                };
            
            f = db.Fornecedor.Add(f);
            db.SaveChanges();

            Assert.NotNull(f.Id);
        }
    }
}
