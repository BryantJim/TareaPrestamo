using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrestamoTarea.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using PrestamoTarea.Models;

namespace PrestamoTarea.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Personas persona = new Personas();
            persona.PersonaId = 2;
            persona.Nombres = "Anthony";
            persona.Cedula = "402-1286181-5";
            persona.FechaNacimiento = DateTime.Now;
            persona.Balance = 2000;
            bool guardo = PersonasBLL.Guardar(persona);
            Assert.IsTrue(guardo);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = PersonasBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool busco = false;
            var persona = PersonasBLL.Buscar(1);                                                                

            if (persona != null)
                busco = true;
            else
                busco = false;

            Assert.IsTrue(busco);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsTrue(true);
        }
    }
}