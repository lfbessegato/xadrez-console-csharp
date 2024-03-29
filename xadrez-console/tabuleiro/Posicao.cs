﻿namespace tabuleiro
{
    class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        //Construtor
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        //Definir os valores da posição
        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
