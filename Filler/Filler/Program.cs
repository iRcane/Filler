using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filler
{
    


    class Player
    {
        
    }

    class Field
    {
        const int width = 24;
        const int height = 20;
        private int[][] field;

        public Field()
        {
            field = new int[height][];
            for (int i = 0; i < height; i++)
                field[i] = new int[width];
        }

        private void Fill()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {

                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
