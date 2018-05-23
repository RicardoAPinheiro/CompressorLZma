using System;


namespace My7zip
{
    interface IAlertas
    {
        void fimDescompressão(object sender, EventArgs e);
        void fimCompressão(object sender, EventArgs e);
        void ficheiroRepetido(object sender, EventArgs e);
    }
}
