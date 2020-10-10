using System;

namespace TestDotNetJRPL
{

    public static class Task2
    {

        /*
           Uma tarefa comum em um sistema corporativo é a definição de prazos para tarefas. Com base nos exemplos abaixo, construa uma função que determine qual é a data final de uma tarefa (Dias corridos).

            1. Data de ínicio:04/10/2020
               Dias para conclusão: 10 dias
               Prazo: 14/10/2020

            2. Data de ínicio:25/09/2020
               Dias para conclusão: 15 dias
               Prazo: 10/10/2020



            Observação: Use o formato dd/MM/yyyy para entrada e saída de datas da sua função.
        */

        public static string GetDueDate(string Date, int DaysToFinish)
        {
            Date = string.Format("{0:dd/MM/yyyy}", Date);

            DateTime StartDate = Convert.ToDateTime(Date);
            DateTime DueDate = StartDate.AddDays(DaysToFinish);

            return string.Format("{0:dd/MM/yyyy}", DueDate);
        }


    }
}
