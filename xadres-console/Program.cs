﻿using System;
using tabuleiro;
using xadrez;
namespace xadres_console
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                PartidaDeXadrez partida = new PartidaDeXadrez();



                while(!partida.terminada){
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                }
            }
            catch(TabuleiroExeption e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}