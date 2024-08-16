using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersDIO {
    public class ValidacoesString {

        public Int32 RetornaQuantidadeCaracteres(String entrada) {
            return entrada != null? entrada.Length : 0;
        }

        public Boolean ContemCaractere(String entrada, String caractere) {
            return entrada != null && caractere != null ? entrada.Contains(caractere) : false;
        }

        public Boolean TextoTerminaCom(String entrada, String caractere) {
            return entrada != null && caractere != null ? entrada.EndsWith(caractere): false;
        }
    }
}
