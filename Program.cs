﻿using System;
using tabuleiro;
using xadrez;

namespace Jogo_de_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

            Tela.imprimirTabuleiro(tab);
        }
    }
}
