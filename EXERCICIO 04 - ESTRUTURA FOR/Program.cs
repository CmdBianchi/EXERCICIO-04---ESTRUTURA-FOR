using System;
namespace EXERCICIO_04___ESTRUTURA_FOR{
    class Program{
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Conditional();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("Exercício 04 - estrutura repetitiva FOR - Lista de exercícios.");
        }
        //------------------------------------------------------------------------------------------//
        static void Conditional(){
            int n = int.Parse(Console.ReadLine()); //----> Números de casos
            for ( int i = 0; i < n; i++) {
                string[] line = Console.ReadLine().Split(' '); //----> Digitar lateralmente com espaço os valores | Cria um ARRAY de POSIÇOES "N"
                double a = double.Parse(line[0]); double b = double.Parse(line[1]);
                double result = a / b;
                if (b == 0){
                    Console.WriteLine("INDIVISÍVEL");                   
                }
                else {
                    Console.WriteLine(result.ToString("F1")); 
                }              
            }     
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
