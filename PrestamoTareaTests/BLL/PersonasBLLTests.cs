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
            bool paso;
            Personas persona = new Personas
            {
                PersonaId = 0,
                Nombres = "Anthony",
                Cedula = "402-1002050-2",
                FechaNacimiento = DateTime.Now,
                Balance = 0
            };
            paso = PersonasBLL.Guardar(persona);

            Assert.AreEqual(paso, true);
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
            bool Lista;
            List<Personas> List = new List<Personas>();
            List = PersonasBLL.GetList(P => true);

            if (List != null)
                Lista = true;
            else
                Lista = false;

            Assert.IsTrue(Lista);
        }
    }
}