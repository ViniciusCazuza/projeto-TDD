using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Calculadora
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            
            this.data = data;
        }

        public int Somar(int x, int y)
        {
            
            int soma = x + y;
            
            listaHistorico.Insert(0, $"{data}: {x} + {y} = {soma}");

            return soma;
        }
        
        public int Subtrair(int x, int y)
        {
            int subtrair = x - y;

            listaHistorico.Insert(0, $"{data}: {x} - {y} = {subtrair}");
            
            return subtrair;
        }
        
        public int Multiplicar(int x, int y)
        {
            int multiplicar = x * y;

            listaHistorico.Insert(0, $"{data}: {x} * {y} = {multiplicar}");
            
            return multiplicar;
        }
        
        public int Dividir(int x, int y)
        {
            int dividir = x / y;

            listaHistorico.Insert(0, $"{data}: {x} / {y} = {dividir}");
            
            return dividir;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    
    }
}
