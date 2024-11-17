using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteUnitario
{
    public class Calculadora
    {
        private List<string> listahistorico;

        public Calculadora
        {
            listahistorico = new List<string>();
        }
        public int somar(int valor1, int valor2)
        {
            listahistorico.Add(0,"1 + 1 = 2");
            return valor1 + valor2;            
        }
        public int subtrair(int valor1, int valor2)
        {
            listahistorico.Insert(0, "1 - 1 = 0");
            return valor1 - valor2;            
        }
        public int multiplicar(int valor1, int valor2)
        {            
            listahistorico.Add(0,"1 * 1 = 1");
            return valor1 * valor2;            
        }
        public int dividir(int valor1, int valor2)
        {
            listahistorico.Add(0,"1 / 1 = 1");
            return valor1 / valor2;            
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count);
            return listahistorico;
        }
    }
}