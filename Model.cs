using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SevenZip;


namespace My7zip
{
    class Model
    {
        private const string LibraryPath = @"c:\programas\7-zip\7z64.dll";
        private string tempPath = @"c:\temp\";
        Alertas msg = new Alertas();

        public Model()
        {
        }

        public void descomprime(string ficheiro, string diretorio)
        {
            if (string.IsNullOrEmpty(diretorio))
            {
                diretorio = diretorioDefeito(ficheiro, diretorio);
            }
            SevenZipExtractor.SetLibraryPath(LibraryPath);
            var extrai = new SevenZipExtractor(ficheiro);
            extrai.FileExists += new EventHandler<FileOverwriteEventArgs>(msg.ficheiroRepetido);
            extrai.BeginExtractArchive(diretorio);
            extrai.ExtractionFinished += new EventHandler<EventArgs>(msg.fimDescompressão);
        }

        public void comprime(string ficheiro, string diretorio)
        {
            if (string.IsNullOrEmpty(ficheiro))
            {
                ficheiro = caminhoFicheiroDefeito(ficheiro, diretorio);
            }
            SevenZipCompressor.SetLibraryPath(LibraryPath);
            SevenZipCompressor comprimir = new SevenZipCompressor();
            comprimir.ArchiveFormat = OutArchiveFormat.SevenZip;
            comprimir.CompressionMode = SevenZip.CompressionMode.Create;
            comprimir.TempFolderPath = tempPath;
            comprimir.CompressionFinished += new EventHandler<EventArgs>(msg.fimCompressão);
            comprimir.CompressDirectory(diretorio, ficheiro);
        }

        public string diretorioDefeito(string ficheiro, string diretorio)
        {
            //Retorna caminho para descomprimir para um diretorio por defeito (diretorio onde se encontra o ficheiro)

            int ultimoDiretorio = ficheiro.LastIndexOf('\\');
            diretorio = ficheiro.Substring(0, ultimoDiretorio);
            return diretorio;
        }

        public string caminhoFicheiroDefeito(string ficheiro,string diretorio)
        {
            // Retorna um nome por defeito para o ficheiro comprimido (nome do diretorio a ser comprimido)

            int tamanhoCaminho = diretorio.Length;
            int ultimoDiretorio = diretorio.LastIndexOf('\\');    
            int tamanhoNomeFicheiro = tamanhoCaminho - ultimoDiretorio;
            string diretorioRaiz = diretorio.Substring(0, ultimoDiretorio);
            ficheiro = diretorioRaiz + diretorio.Substring(ultimoDiretorio,tamanhoNomeFicheiro)+".7z";
            return ficheiro;
        }
    }
}
