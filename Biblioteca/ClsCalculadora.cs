using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ClsCalculadora
    {

        // Atributos privados para el estado y la memoria
        private double valorActual;
        private double memoria;

        public double ValorActual
        {
            get { return valorActual; }
            set { valorActual = value; }
        }

        public double Memoria
        {
            get { return memoria; }
        }

        public ClsCalculadora()
        {
            valorActual = 0;
            memoria = 0;
        }

        // --- OPERACIONES BÁSICAS ---
        public double Sumar(double a, double b) => a + b;
        public double Restar(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a * b;

        public double Dividir(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("No se puede dividir por cero.");
            return a / b;
        }

        // --- FUNCIONES ESTÁNDAR (Visibles en la imagen) ---
        public double Porcentaje(double baseNum, double porcentaje) => (baseNum * porcentaje) / 100.0;

        public double Inverso(double numero)
        {
            if (numero == 0) throw new DivideByZeroException("No se puede dividir por cero.");
            return 1.0 / numero;
        }

        public double Cuadrado(double numero) => Math.Pow(numero, 2);

        public double RaizCuadrada(double numero)
        {
            if (numero < 0) throw new ArgumentException("Entrada no válida.");
            return Math.Sqrt(numero);
        }

        // --- GESTIÓN DE MEMORIA (MC, MR, M+, M-, MS) ---
        public void MemoriaClear() => memoria = 0;

        public double MemoriaRead() => memoria;

        public void MemoriaStore(double valor) => memoria = valor;

        public void MemoriaAdd(double valor) => memoria += valor;

        public void MemoriaSubtract(double valor) => memoria -= valor;
    }
}
