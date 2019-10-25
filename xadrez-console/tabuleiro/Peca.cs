namespace tabuleiro
{
    class Peca
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
    }
}
