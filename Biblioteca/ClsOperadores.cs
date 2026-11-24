using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ClsOperadores
    {
        public bool Numero (string texto)
        {
            return double.TryParse(texto, out _);
        }

        public double Sumar (Double N1, Double N2)
        {
            return N1 + N2;
        }
        public double Restar(Double N1, Double N2)
        {
            return N1 - N2;
        }
        public double Multiplicar(Double N1, Double N2)
        {
            return N1 * N2;
        }
        public double Dividir(Double N1, Double N2)
        {
            return N1 / N2;
        }

        public bool EsNumero(string text)
        {
            double valor;
            return double.TryParse(text, out valor);
        }
    }
}
