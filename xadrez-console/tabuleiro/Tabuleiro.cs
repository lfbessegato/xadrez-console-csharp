namespace tabuleiro
{
    class Tabuleiro
    {

        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        //Construtor
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        /* 
         Método criado para retornar a peça na linha e coluna, já que o vetor Peca só enxerga dentro 
         dessa classe.
             */

        public Peca peca (int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}
