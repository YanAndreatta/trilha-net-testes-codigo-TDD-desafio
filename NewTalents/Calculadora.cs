using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> Listahistorico;
        private string Data;

        public Calculadora(string data)
        {
            Listahistorico = new List<string>();
            Data = data;
        }

        public int Somar(int val1, int val2)
        {
            int result = val1 + val2;
            Listahistorico.Insert(0, "Res: " + result.ToString() + "- data: " + Data);

            return result;
        }

        public int Subtrair(int val1, int val2)
        {
            int result = val1 - val2;
            Listahistorico.Insert(0, "Res: " + result.ToString() + "- data: " + Data);

            return result;
        }

        public int Multiplicar(int val1, int val2)
        {
            int result = val1 * val2;
            Listahistorico.Insert(0, "Res: " + result.ToString() + "- data: " + Data);

            return result;
        }

        public int Dividir(int val1, int val2)
        {
            int result = val1 / val2;
            Listahistorico.Insert(0, "Res: " + result.ToString() + "- data: " + Data);

            return result;
        }

        public List<string> Historico()
        {
            Listahistorico.RemoveRange(3, Listahistorico.Count - 3);
            return Listahistorico;
        }
    }
}