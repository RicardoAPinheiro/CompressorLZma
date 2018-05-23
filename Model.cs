using System;
using SevenZip;
using System.Windows.Forms;



namespace My7zip
{
    class Model: IModel
    {
        private const string LibraryPath = @"c:\programas\7-zip\7z64.dll";
        private string tempPath = @"c:\temp\";
        IAlertas msg = new Alertas();
        My7zip statusCompDescomp = new My7zip();


        public Model()
        {
        }

        public void descomprime(string ficheiro, string diretorio)
        {
           
            SevenZipExtractor.SetLibraryPath(LibraryPath);
            var extrai = new SevenZipExtractor(ficheiro);
            extrai.FileExists += new EventHandler<FileOverwriteEventArgs>(msg.ficheiroRepetido);
            extrai.BeginExtractArchive(diretorio);
            extrai.ExtractionFinished += new EventHandler<EventArgs>(msg.fimDescompressão);
        }

        public void comprime(string ficheiro, string diretorio)
        {
            
            SevenZipCompressor.SetLibraryPath(LibraryPath);
            SevenZipCompressor comprimir = new SevenZipCompressor();
            comprimir.ArchiveFormat = OutArchiveFormat.SevenZip;
            comprimir.CompressionMode = SevenZip.CompressionMode.Create;
            comprimir.TempFolderPath = tempPath;
            comprimir.Compressing += new EventHandler<ProgressEventArgs>(compressStatus);
            comprimir.CompressionFinished += new EventHandler<EventArgs>(msg.fimCompressão);
            comprimir.CompressDirectory(diretorio, ficheiro);
        }

        public void compressStatus(object sender, ProgressEventArgs e)
        {
            statusCompDescomp.getPercentagem = e.PercentDelta;
        }
    }
}
