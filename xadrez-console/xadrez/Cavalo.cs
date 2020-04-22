using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Cor cor, Tabuleiro tab ) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "C";
        }

        private bool podeMover (Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            //2 BAIXO 1 CIMA
            pos.definirValores(posicao.linha + 2, posicao.coluna - 1);
            if ( tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //1 BAIXO 2 ESQUERDA
            pos.definirValores(posicao.linha + 1, posicao.coluna - 2);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //2 CIMA 1 ESQUERDA
            pos.definirValores(posicao.linha - 2, posicao.coluna - 1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //1 CIMA 2 ESQUERDA
            pos.definirValores(posicao.linha - 1, posicao.coluna - 2);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //2 BAIXO 1 DIREITA
            pos.definirValores(posicao.linha + 2, posicao.coluna +1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //1 BAIXO 2 DIREITA
            pos.definirValores(posicao.linha + 1, posicao.coluna + 2);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //2 CIMA 1 DIREITA
            pos.definirValores(posicao.linha - 2, posicao.coluna + 1);
            if ( tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //1 BAIXO 2 DIREITA
            pos.definirValores(posicao.linha - 1, posicao.coluna + 2);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;


        }
    }
}
