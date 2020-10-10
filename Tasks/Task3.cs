using System;
using System.Collections.Generic;
using System.Linq;
using Tasks.SupportFiles;

namespace TestDotNetJRPL
{

    public static class Task3
    {

        /*
           Para os exercicios abaixo, considere a classe Repository como uma DataBase.
        */


        /* Tarefa 3.1: Crie uma função que retorne a lista do nome dos itens com o estoque zerado.*/
        public static List<string> GetItemsOutOfStock()
        {
            Repository repository = new Repository();

            List<Component> ComponentList = new List<Component>();
            ComponentList = (from stock in repository.Stocks.AsEnumerable()
                             where stock.Quantity == 0

                             select new Component()
                             {
                                 Name = ""
                             }).ToList();
        }


        /* Tarefa 3.2: Crie uma função que retorne o total de itens no stock.*/
        public static int GetStockSum()
        {
            
        }



        /* Tarefa 3.3: Considere o seguinte pedido:
         * 
         * 200 Items do Produto A
         * 
         * Considerando a lista de materiais necessários para o Produto A:
         * 1. 2 Unidades do Component 2
         * 2. 1 Unidades do Component 3
         * 3. 3 Unidades do Component 4
         * 
         * Crie uma função que receba a quantidade, a lista de materiais e retorne se é possível ou não fabricar determinado produto        
         * .*/

        public static bool IsPossibleManufacturer(int OrderQuantity, MaterialEntry[] MaterialList)
        {

           
        }



    }
}
