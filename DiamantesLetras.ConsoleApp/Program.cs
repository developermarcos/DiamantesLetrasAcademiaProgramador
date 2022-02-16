using System;

namespace DiamantesLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imprimir = "";
            int alturaDiamante, alturaMeioFimDiamante, quantidadeEspacos, quantidadeX =1, letraInformaUsuario;
            int valorMinimoTabelaAsc = 65;

            Console.WriteLine("Imforme uma letra para o sistema montar um diamante: ");
            letraInformaUsuario = Convert.ToInt32(Convert.ToChar(Console.ReadLine().ToUpper()));

            alturaDiamante = (letraInformaUsuario + 1) - valorMinimoTabelaAsc;
            Console.WriteLine("altura diamante: {0}", alturaDiamante.ToString());
            alturaMeioFimDiamante = (alturaDiamante - 1) / 2;
            quantidadeEspacos = alturaMeioFimDiamante+1;

            for (int inicioDiamante = 0; inicioDiamante < alturaMeioFimDiamante; inicioDiamante++)
            {
                for (int i = 1; i < quantidadeEspacos; i++)
                    imprimir += " ";
                
                if(quantidadeX != 1)
                    imprimir +="A";
                
                for (int impressaoX = 0; impressaoX < (quantidadeX -2); impressaoX++)
                    imprimir += " ";

                imprimir +="A";
                imprimir += "\n";
                quantidadeX += 2;
                quantidadeEspacos--;
            }
            for (int meioDiamante = 0; meioDiamante < alturaDiamante; meioDiamante++)
            {
                if(meioDiamante == 0 || (meioDiamante+1) == alturaDiamante)
                    imprimir +="A";
                else
                    imprimir += " ";
            }
            imprimir += "\n";
            quantidadeX -= 2;
            quantidadeEspacos++;
            for (int inicioDiamante = 0; inicioDiamante < alturaMeioFimDiamante; inicioDiamante++)
            {
                for (int i = 1; i < quantidadeEspacos; i++)
                    imprimir += " ";
                
                if (quantidadeX != 1)
                    imprimir +="A";
                
                for (int impressaoX = 0; impressaoX < (quantidadeX -2); impressaoX++)
                    imprimir += " ";
                
                imprimir +="A";
                imprimir += "\n";
                quantidadeX -= 2;
                quantidadeEspacos++;
            }

            Console.WriteLine("Diamante \n{0}", imprimir);
            Console.ReadKey();
        }
    }
}
