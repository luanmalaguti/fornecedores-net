using System;
using Context.DAO;
using Model.POCO;
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
            db = ConnProvider.getContext();
        }
      
        
        [Test]
        public void save()
        {
            Usuario u = new Usuario();
            u.Username = "lol";
            u.Password = "lol";
            
            u = db.Usuario.Add(u);
            db.SaveChanges();

            Assert.NotNull(u.Id);
        }
    }
}
