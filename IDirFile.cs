
namespace My7zip
{
    interface IDirFile
    {
        string diretorio
        {
            set;
            get;
        }
        string ficheiro
        {
            set;
            get;
        }
        string dirDefeito { get; }
        string fileDefeito { get; }
    }
}
