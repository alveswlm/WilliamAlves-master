using System;
using System.Text.RegularExpressions;

namespace TestDotNetJRPL
{

    public static class Task1
    {
        /*
           Considere a seguinte regra para a criação de um identificador de uma entidade em um sistema coorporativo:
           1. 3 letras maiúsculas entre A e D;
           2. 4 dígitos do ano(entre 1999 e 2035);
           3. Número sequencial com 4 dígitos

           Exemplos de strings geradas corretamente: 
           1. ABC20190020
           2. BFC20350001
           3. BBB19990200
           
          Construa uma função que receba uma string e valide se ela está no formato esperado.
        */

        public static Boolean CheckString(string Input)
        {
            if (Input.Length > 0 && Input.Length < 12)
            {
                string Letras = Input.Substring(0, 3);
                string Digitos = Input.Substring(3, 4);
                string Sequencial = Input.Substring(7, 4);

                Regex LetrasPattern = new Regex(@"[A-D]");
                bool LetrasOK = LetrasPattern.IsMatch(Letras);

                bool DigitosOK = false;
                if (Convert.ToInt16(Digitos) >= 1999 && Convert.ToInt16(Digitos) <= 2035)
                    DigitosOK = true;

                Regex SequencialPattern = new Regex(@"[0-9]");
                bool SequencialOK = SequencialPattern.IsMatch(Sequencial);

                if (LetrasOK && DigitosOK && SequencialOK)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }        
    }
}
