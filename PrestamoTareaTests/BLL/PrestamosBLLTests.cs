using PrestamoTarea.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using PrestamoTarea.Models;

namespace PrestamoTarea.BLL.Tests
{
    [TestClass()]
    public class PrestamosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Prestamos prestamo = new Prestamos
            {
                PrestamoId = 0,
                Fecha = DateTime.Now,
                PersonaId = 0,
                Concepto = "Prestamo universitario",
                Monto = 200,
                Balance = 0
            };
            paso = PrestamosBLL.Guardar(prestamo);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = PrestamosBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool busco = false;
            var persona = PrestamosBLL.Buscar(1);

            if (persona != null)
                busco = true;
            else
                busco = false;

            Assert.IsTrue(busco);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}