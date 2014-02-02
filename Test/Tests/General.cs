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
        public void CreateDataBase()
        {
            Assert.IsTrue(db.Database.Exists());
        }
    }
}
