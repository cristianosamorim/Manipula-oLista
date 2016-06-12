using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManipulacaoListaTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Quero_Informar_Numeros_Maiores_Toda_Media_Numeros_Informados()
        {
            //Arrange
            IEnumerable<int> lista = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 15};

            //Act
            var media = lista.Average(x => x);
            var numerosMaioresMedia = lista.Where(x => x > media).ToList();

            //Assert
            Assert.AreEqual(6, numerosMaioresMedia.Count);
        }

        [TestMethod]
        public void Quero_Informar_Numeros_Ordem_Crescente()
        {
            //Arrange
            IEnumerable<int> lista = new List<int> { 15, 12, 10, 3, 4, 9, 5, 6, 7, 8};

            //Act
            var listaOrdem = lista.OrderBy(x => x).ToList();
            
            //Assert
            Assert.AreEqual(3, listaOrdem.FirstOrDefault(x => x > 0));
        }

        [TestMethod]
        public void Quero_Informar_Media_Soma_Todos_Numeros()
        {
            //Arrange
            IEnumerable<int> lista = new List<int> { 15, 12, 10, 3, 4, 9, 5, 6, 7, 8 };

            //Act
            var soma = lista.Sum(x => x);
            var media = lista.Average(x => x);

            //Assert
            Assert.AreEqual(79, soma);
            Assert.AreEqual(7.9, media);
        }
    }
}
