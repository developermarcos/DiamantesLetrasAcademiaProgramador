using System;

namespace DiamantesLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imprimir = "";
            int larguraMeioFimDiamante, quantidadeEspacos, quantidadeLetras = 1, letraInformaUsuario;
            int valorMinimoTabelaAsc = 65;
            #region Imput dados
            Console.WriteLine("Imforme uma letra para o sistema montar um diamante: ");
            letraInformaUsuario = Convert.ToInt32(Convert.ToChar(Console.ReadLine().ToUpper()));
            #endregion

            #region Set parametros
            quantidadeEspacos = (letraInformaUsuario + 1) - valorMinimoTabelaAsc;
            larguraMeioFimDiamante = (letraInformaUsuario + 1) - valorMinimoTabelaAsc;
            #endregion

            #region parte crescente diamante
            for (int inicioDiamante = valorMinimoTabelaAsc; inicioDiamante < letraInformaUsuario; inicioDiamante++)
            {
                imprimir += "\n";
                for (int i = 1; i < quantidadeEspacos; i++)
                    imprimir += " ";
                
                if(quantidadeLetras != 1)
                    imprimir += Convert.ToChar(inicioDiamante).ToString();
                
                for (int impressaoX = 0; impressaoX < (quantidadeLetras -2); impressaoX++)
                    imprimir += " ";

                imprimir += Convert.ToChar(inicioDiamante).ToString();
                imprimir += "\n";
                quantidadeLetras += 2;
                quantidadeEspacos--;
            }
            #endregion

            #region parte meio diamanta
            quantidadeLetras -= 2;
            imprimir += "\n";
            imprimir += Convert.ToChar(letraInformaUsuario);
            for (int meioDiamante = 0; meioDiamante < quantidadeLetras; meioDiamante++)
            {
                imprimir += " ";
            }
            imprimir += Convert.ToChar(letraInformaUsuario);
            imprimir += "\n";
            #endregion

            #region parte baixa diamante
            quantidadeEspacos++;
            for (int fimDiamante = (letraInformaUsuario -1); fimDiamante >= valorMinimoTabelaAsc; fimDiamante--)
            {
                imprimir += "\n";
                for (int i = 1; i < quantidadeEspacos; i++)
                    imprimir += " ";

                if (quantidadeLetras != 1)
                    imprimir += Convert.ToChar(fimDiamante).ToString();

                for (int impressaoX = 0; impressaoX < (quantidadeLetras -2); impressaoX++)
                    imprimir += " ";

                imprimir += Convert.ToChar(fimDiamante).ToString();
                imprimir += "\n";
                quantidadeLetras -= 2;
                quantidadeEspacos++;
            }
            #endregion

            #region Saida dados
            Console.WriteLine("Diamante \n{0}", imprimir);
            Console.ReadKey();
            #endregion
        }
    }
}
