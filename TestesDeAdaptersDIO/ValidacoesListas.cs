using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersDIO
{
    public class ValidacoesListas {

        public List<Int32>? RemoveNumerosNegativos(List<Int32> lista) {
            if (lista == null || lista.Count == 0 ) {
                return null;
            }
            List<Int32> numerosPositivos = new List<Int32>();
            foreach (Int32 numero in lista) {
                if (numero >= 0) {
                    numerosPositivos.Add(numero);
                }
            }
            return numerosPositivos;
        }

        public Boolean? Contains(List<Int32> lista, Int32 numero) {
            return lista != null && lista.Count > 0 ?  lista.Contains(numero) : false;
        }

        public List<Int32>? MultiplicaNumeros(List<Int32> lista, Int32 fator1) {
            if (lista == null || lista.Count == 0) {
                return null;
            }
            List<Int32> produtos = new List<Int32>();
            foreach (Int32 fator2 in lista) {
                produtos.Add(fator1 * fator2);
            }
            return produtos ;
        }

        public Int32? RetornaMaiorNumeroLista(List<Int32> lista) {
            return lista != null && lista.Count > 0  ? lista.Max() : null;
        }

        public Int32? RetornaMenorNumero(List<Int32> lista) {
            return lista != null && lista.Count > 0 ? lista.Min() : null;
        }
    }
}
