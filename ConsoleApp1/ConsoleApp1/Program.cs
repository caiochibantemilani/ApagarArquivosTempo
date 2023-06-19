using System;
using System.IO;

class limpeza
{
    static void Main()
    {
        string caminho = @"C:\Users\Fabiana\Desktop\TREINAMENTOS"; // Caminho que terá os arquivos excluídos

        DeletarArquivosAntigos(caminho);
    }
    static void DeletarArquivosAntigos(string caminho)
    {
        string[] files = Directory.GetFiles(caminho);

        //Excluir por tempo
        foreach (string arquivo in files)
        {
            FileInfo infoArquivos = new FileInfo(arquivo);
            if (infoArquivos.CreationTime < DateTime.Now.AddSeconds(-1))
            {
                File.Delete(arquivo);
                Console.WriteLine($"Arquivo {arquivo} excluído com sucesso.");
            }
            else
            {
                Console.WriteLine($"Arquivo {arquivo} mantido.");
            }
        }
    }


}
