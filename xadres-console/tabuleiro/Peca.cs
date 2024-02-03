

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor Color { get; set; }

        public int QteMovimentos { get; private set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Tabuleiro tab, Cor color)
        {
            posicao = null;
            Tab = tab;
            Color = color;
            QteMovimentos = 0;
        }
    }
}
