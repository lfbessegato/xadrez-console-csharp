using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {

        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            /* Pode mover qdo a casa estiver vazia ou tiver uma peça adversária */
            return p == null || p.cor != cor;
        }

        //Implementando o método abstrato movimentosPossiveis
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas]; //Instanciado o mesmo número do tabuleiro

            Posicao pos = new Posicao(0, 0);

            //Acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);

            //Pode mover até o final do tabuleiro
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                // se no caminho tem uma peça adversária
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            //Abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);

            //Pode mover até o final do tabuleiro
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                // se no caminho tem uma peça adversária
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            //Direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);

            //Pode mover até o final do tabuleiro
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                // se no caminho tem uma peça adversária
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            //Esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);

            //Pode mover até o final do tabuleiro
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                // se no caminho tem uma peça adversária
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }

            return mat;
        }
    }
}
