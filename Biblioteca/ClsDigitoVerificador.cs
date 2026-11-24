using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ClsDigitoVerificador
    {
        public static bool ValidarCedula(string text)
        {
            ClsDigitoVerificador verif = new ClsDigitoVerificador();
            return verif.VerificarCedula(text);
        }

        public bool VerificarCedula(string cedula)
        {
            if (cedula == null || cedula.Length != 10)
                return false;

            int suma = 0;
            int[] coef = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };

            for (int i = 0; i < 9; i++)
            {
                if (!int.TryParse(cedula[i].ToString(), out int dig))
                    return false;

                int val = dig * coef[i];
                if (val >= 10)
                    val -= 9;
                suma += val;
            }

            int ultimoDigito = int.Parse(cedula[9].ToString());
            int resto = suma % 10;
            int digEsperado = (resto == 0) ? 0 : 10 - resto;

            return digEsperado == ultimoDigito;
        }
    }
}
