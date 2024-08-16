using AdaptersDIO;
using System.Runtime.Intrinsics.X86;

namespace TestesDosAdapters {

    public class ValidacoesStringTests {

        private readonly ValidacoesString validacoesString = new();

        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix() {
            Assert.Equal(6,validacoesString.RetornaQuantidadeCaracteres("Matrix"));
        }

        [Fact]
        public void OutrosTestesMetodoRetornaQtdCaracteres() {
            Assert.Equal(3, validacoesString.RetornaQuantidadeCaracteres("   "));
            Assert.Equal(0, validacoesString.RetornaQuantidadeCaracteres(""));
            Assert.Equal(0, validacoesString.RetornaQuantidadeCaracteres(null));
        }

        [Fact]
        public void DeveConterAPalavraQualquerNoTexto() {
            Assert.False(validacoesString.ContemCaractere("Esse é um texto qualquer", "Qualquer"));
        }

        [Fact]
        private void OutrosTestesMetodoContains() {
            Assert.True(validacoesString.ContemCaractere("Esse é um texto qualquer", "qualquer"));
            Assert.False(validacoesString.ContemCaractere("Esse é um texto qualquer", "QUALQUER"));
            Assert.True(validacoesString.ContemCaractere("Esse é um texto qualquer", " "));
            Assert.False(validacoesString.ContemCaractere("Esse é um texto qualquer", "qualquer "));
            Assert.True(validacoesString.ContemCaractere("Esse é um texto qualquer", "lquer"));
            Assert.False(validacoesString.ContemCaractere(" ", "qualquer"));
            Assert.False(validacoesString.ContemCaractere(null, null));
            Assert.False(validacoesString.ContemCaractere("Esse é um texto qualquer", null));
            Assert.False(validacoesString.ContemCaractere(null, "qualquer"));
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto() {
            Assert.False(validacoesString.ContemCaractere("Esse é um texto qualquer", "teste"));
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado() {
            Assert.True(validacoesString.TextoTerminaCom("Começo, meio e fim do texto procurado", "procurado"));
        }

        [Fact]
        public void OutrosTestesMetodoTextoTerminaCom() {
            Assert.True(validacoesString.TextoTerminaCom("Começo, meio e fim do texto procurado", "rado"));
            Assert.False(validacoesString.TextoTerminaCom("Começo, meio e fim do texto procurado", "procu"));
            Assert.True(validacoesString.TextoTerminaCom("Começo, meio e fim do texto procurado", " procurado"));
            Assert.False(validacoesString.TextoTerminaCom("Começo, meio e fim do texto procurado", "procurado "));
            Assert.True(validacoesString.TextoTerminaCom("Começo, meio e fim do texto procurado", ""));
            Assert.False(validacoesString.TextoTerminaCom("Começo, meio e fim do texto procurado", null));
            Assert.False(validacoesString.TextoTerminaCom(null, "procurado"));
            Assert.False(validacoesString.TextoTerminaCom(null, null));
        }
    }
}