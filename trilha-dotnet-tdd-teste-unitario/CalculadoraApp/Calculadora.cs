using System;
using System.Collections.Generic;

namespace CalculadoraApp
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private DateTime DataRegistro;

        public Calculadora(DateTime dataRegistro)
        {
            ListaHistorico = new List<string>();
            DataRegistro = dataRegistro;
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            ListaHistorico.Insert(0, $"{num1} + {num2} = {resultado} | {DataRegistro.ToShortDateString()}");
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            ListaHistorico.Insert(0, $"{num1} - {num2} = {resultado} | {DataRegistro.ToShortDateString()}");
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            ListaHistorico.Insert(0, $"{num1} * {num2} = {resultado} | {DataRegistro.ToShortDateString()}");
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            ListaHistorico.Insert(0, $"{num1} / {num2} = {resultado} | {DataRegistro.ToShortDateString()}");
            return resultado;
        }

        public List<string> RetornarHistoricoOperacoes()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }

    }
}
