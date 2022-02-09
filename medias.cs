using System;
 class metodos{

     static void Main(){
         Console.WriteLine("digite a sua nota de numero 1 :");
         double value_1 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("digite a nota de numero 2:");
         double value_2 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("digite a nota de numero 3:");
         double value_3 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("digite a nota de numero 4:");
         double value_4 = Convert.ToDouble(Console.ReadLine());
         Calcular_medias(value_1,value_2,value_3,value_4);
     }

     static void Calcular_medias(double n1,double n2, double n3, double n4){
            Console.WriteLine("digite seu Nome");
            string nome = Convert.ToString(Console.ReadLine());
            double media = (n1 + n2 + n3 + n4)/4;
         if(media<6){
            Console.WriteLine(" o aluno {0} foi reprovado com a media de {1} :",nome,media);
        }
        else{
            Console.WriteLine("O aluno {0} foi aprovado com a media de {1}",nome,media);
        }

     }
     }
