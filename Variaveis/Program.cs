using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        enum Notas
        {
            Minimo = 10,
            Media = 20,
            Maxima = 30
        }

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;

        }

        static void Main(string[] args)
        {
            #region Numericas Integrais
            //// Integral assinado
            //sbyte num1 = 10; // 8 bits, de -128 a 127
            //short num2 = 20; // 16 bits, -32.768 a 32.767
            //int num3 = 30;   // 32 bits, -2.147.483.648 a 2.147.484.647
            //long num4 = 40L; // 64 bits, -9.223.327.036.854.775.909 a 9.223.372.036.854.775.807

            ////Integral sem sinal
            //byte num5 = 10; // 8 bits, intervalo de 0 a 225
            //ushort num6 = 20; // 16 bits, de 0 a 65.535
            //uint num7 = 30; // 32 bits, de 0 a 4.294.967.295
            //ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

            //sbyte numero;
            //numero = 100;

            //numero = 120;
            //numero = num1;
            #endregion
            #region Caractere
            float real1 = 100.75f; // 32 bits // no códogo fonte colocar ponto. no sistema vai imprimir com virgla
            double real2 = 12500.45; // 64 bits
            decimal real3 = 752538.457m; // 128 bits

            double valor;
            valor = real1;
            #endregion

            #region Caractere
            char letra = '\u0061';
            char escape = '\n';
            #endregion

            #region Boolean
            bool verificar = false;
            verificar = true;
            #endregion

            #region String
            string texto = @"Gariel Artigas \n 1985 @@@?";
            string mensagem = null;
            mensagem = texto;
            #endregion

            #region Variavel
            var teste1 = 14;
            #endregion

            #region Object
            object obj = false;
            obj = 200;
            #endregion

            #region Constante
            const double pi = 3.1415;
            const string nome = "eduardo";
            #endregion

            #region Enum
            Notas notasAlunos = Notas.Media;

            #endregion

            #region Struct
            Pessoa p1 = new Pessoa();
            p1.altura = 1.70;
            p1.idade = 39;
            p1.nome = "eduardo";

            Pessoa p2 = new Pessoa()
            {
                nome = "Bruno",
                idade = 14,
                altura = 1.35
            };


            #endregion

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.altura);
            Console.WriteLine(p1.idade);

            Console.WriteLine();

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.altura);
            Console.WriteLine(p2.idade);
            Console.ReadKey();
            
        }
    }
}
