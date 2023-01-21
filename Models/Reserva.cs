using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
           //Implementado!!!!            
           if(Suite.Capacidade >= hospedes.Count)
           {
                 Hospedes = hospedes; 
           }
           else if(Suite.Capacidade < hospedes.Count)
           {
                throw new System.ArgumentException("A quantidade de hóspedes não pode exceder a capacidade de suíte");
           }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //Implementado!!!!!
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado!!!!!
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

           
            if (DiasReservados >= 10)
            {
                valor = valor * 0.90m; //0.90 calcula o valor de desconto direito sem precisar fazer a subtração
            }

            return valor;
        }
    }
}