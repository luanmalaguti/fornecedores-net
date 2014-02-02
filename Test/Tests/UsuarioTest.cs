using System;
using System.Data;
using Context.DAO;
using Model.POCO;
using NUnit.Framework;


namespace Test
{
    [TestFixture]
    public class UsuarioTest
    {
        private FornecedoresContext db;
        private Usuario u;

        [SetUp]
        public void setUp()
        {
            db = ConnProvider.getContext();
        }

        [Test]
        public void Save()
        {
            u = new Usuario();
            u.Username = "lol";
            u.Password = "lol";

            u = db.Usuario.Add(u);
            db.SaveChanges();

            Assert.NotNull(u.Id);
        }

        [Test]
        public void Find()
        {
            Save();
            Usuario result = db.Usuario.Find(u.Id);
            Assert.NotNull(result);
        }

        [Test]
        public void Edit()
        {
            Save();
            u.Username = "Edit";
            u.Password = "Edit";
            db.Entry(u).State = EntityState.Modified;
        }

        [Test]
        public void Remove()
        {
            Save();
            db.Usuario.Remove(u);
        }
    }
}
