namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; } // protected -> Alterado pela classe ou subclasse
        public int qteMovimentos { get; protected set; } // protected -> alterado pela classe ou subclasse
        public Tabuleiro tab { get; protected set; } // protected -> Alterado pela classe ou subclasse

        //Construtor
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            qteMovimentos = 0;
        }

        //Método para incrementar a Qdt de Movimento
        public void incrementarQdteMovimentos()
        {
            qteMovimentos ++;
        }

        //Testa de se tem algum movimento possivel
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i=0; i<tab.linhas; i++)
            {
                for (int j=0;j<tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Validar Possiveis movimentos para o destino
        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        //Definido como abstract pois é uma classe muito genérica 
        // para definir o movimento da peça
        public abstract bool[,] movimentosPossiveis();
        
    }
}
