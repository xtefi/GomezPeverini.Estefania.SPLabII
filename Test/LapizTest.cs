using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class LapizTest
    {
        [TestMethod]
        public void LeerArchivoXml()
        {
            // Arrange
            Lapiz lapiz = new Lapiz("Test", 1, "test", "test");
            Lapiz lapizEsperado;
            //Act
            lapizEsperado = lapiz.LeerXml();
            //Assert
            Assert.IsNotNull(lapizEsperado);
        }
    }
}
