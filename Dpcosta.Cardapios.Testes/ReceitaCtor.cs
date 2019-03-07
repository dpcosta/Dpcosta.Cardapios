using System;
using Xunit;
using Dpcosta.Cardapios.Core;

namespace Dpcosta.Cardapios.Testes
{
    //When
    public class ReceitaCtor
    {
        [Fact]
        public void DeveCriarListaIngredientesNaoNulaEVazia()
        {
            int qtdeEsperada = 0;
            var receita = new Receita();
            Assert.NotNull(receita.Ingredientes);
            Assert.Equal(qtdeEsperada, receita.Ingredientes.Count);
        }
    }
}
