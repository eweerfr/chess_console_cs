using tabuleiro;

namespace xadrez;

public class PosicaoXadrez
{
    public char coluna { get; set; }
    public int linha { get; set; }

    public PosicaoXadrez(char coluna, int linha)
    {
        this.linha = linha;
        this.coluna = coluna;
    }

    public Posicao toPosicao()  //converte a posicao no xadrez pra posicao na matriz eg: c1 para 2,0
    {
        return new Posicao(8 - linha, coluna - 'a');
    }
    
    public override string ToString()
    {
        return $"{coluna}{linha}";
    }
}