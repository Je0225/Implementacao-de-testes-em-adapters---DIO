using AdaptersDIO;

namespace TestesDosAdapters
{
    public class ValidacoesListaTests {

        readonly List<Int32> numeros = new (){-8, 0, 2, 6, -6, 9, 5, -2};

        private readonly List<Int32> numerosPositivos = new() {0, 2, 6, 9, 5};

        private readonly List<Int32> produtos = new() { -16, 0, 4, 12, -12, 18, 10, -4 };

        private readonly ValidacoesListas validacoesListas = new();

        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista() {
            Assert.Equal(numerosPositivos, validacoesListas.RemoveNumerosNegativos(numeros));
        }

        [Fact]
        public void ValidaParametrosRemoveNumerosNegativos() {
            Assert.Equal(null, validacoesListas.RemoveNumerosNegativos(null));
            Assert.Equal(null, validacoesListas.RemoveNumerosNegativos(new List<Int32>()));
        }

        [Fact]
        public void DeveConterONumero9NaLista() {
            Assert.True(validacoesListas.Contains(numeros, 9));
        }

        [Fact]
        public void ValidaParametrosContains() {
            Assert.False(validacoesListas.Contains(null, 9));
            Assert.False(validacoesListas.Contains(new List<Int32>(), 9));
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista() {
            Assert.False(validacoesListas.Contains(numeros, 10));
            Assert.False(validacoesListas.Contains(null, 10));
            Assert.False(validacoesListas.Contains(new List<Int32>(), 10));
        }

        [Fact]
        public void ValidaParametrosMultiplicaNumeros() {
            Assert.Equal(null, validacoesListas.MultiplicaNumeros(null, 2));
            Assert.Equal(null, validacoesListas.MultiplicaNumeros(new List<Int32>(), 2));
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2() {
            Assert.Equal(produtos, validacoesListas.MultiplicaNumeros(numeros, 2));
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista() {
            Assert.Equal(9, validacoesListas.RetornaMaiorNumeroLista(numeros));
        }

        [Fact]
        public void ValidaEntradaRetornaMaiorNumeroLista() {
            Assert.Equal(null, validacoesListas.RetornaMaiorNumeroLista(null));
            Assert.Equal(null, validacoesListas.RetornaMaiorNumeroLista(new List<Int32>()));
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaList() {
            Assert.Equal(-8, validacoesListas.RetornaMenorNumero(numeros));
        }

        [Fact]
        public void ValidaEntradaRetornaMenorNumero() {
            Assert.Equal(null, validacoesListas.RetornaMenorNumero(null));
            Assert.Equal(null, validacoesListas.RetornaMenorNumero(new List<Int32>()));
        }
    }
}