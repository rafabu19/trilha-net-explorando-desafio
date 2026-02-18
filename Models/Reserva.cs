using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get; set;}
        public Suite suite {get; set;}
        public int DiasReservados{ get; set;}

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
                Console.WriteLine("Hóspedes cadastrados!");
            }
            else
            {
                  // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception($"Capacidade não alcançada, A suíte suporta até {suite.Capacidade} pessoas.");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
           this.suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            //TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count;
        }
        public decimal CalcularValorDiaria()
        {
            //TODO retorna o valor da diária
            //cálculo: DiasReservados x Suíte.ValorDiaria
            decimal valorTotal = DiasReservados * suite.ValorDiaria;

            //Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados>=10)
            {
                valorTotal-=valorTotal*0.10m;
            }
            
            return valorTotal;
        }
    }
}