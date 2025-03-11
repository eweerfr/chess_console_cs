using tabuleiro;
using xadrez;
namespace Csharp_chess;

class Program
{
    static void Main(string[] args)
    {
        PosicaoXadrez pos = new PosicaoXadrez('a', 1);

        Console.WriteLine(pos);
        Console.WriteLine(pos.toPosicao());
    }
}