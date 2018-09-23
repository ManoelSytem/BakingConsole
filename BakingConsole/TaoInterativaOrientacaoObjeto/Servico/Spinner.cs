using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaoInterativaOrientacaoObjeto_.Servico
{
    public class Spinner
    {
        private const string Sequence = @"/-\|";
        private int counter = 0;
        private readonly int left;
        private readonly int top;
        private readonly int delay;
        private bool active;
        private readonly Thread thread;

        public Spinner(int left, int top, int delay = 100)
        {
            this.left = left;
            this.top = top;
            this.delay = delay;
            thread = new Thread(Spin);
        }

        public void Start()
        {
            active = true;
            if (!thread.IsAlive)
                thread.Start();
        }

        public void Stop()
        {
            active = false;
            Draw(' ');
        }

        private void Spin()
        {
            while (active)
            {
                Turn();
                Thread.Sleep(delay);
            }
        }

        private void Draw(char c)
        {

            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("______________Banco Console_____________...");
            Console.Write(c);
            Console.Write(c);
            Console.Write(c);
            Console.WriteLine(c);


        }

        private void Turn()
        {
            Draw(Sequence[++counter % Sequence.Length]);
        }

        public void Dispose()
        {
            Stop();
        }

        public void progreso(int progreso, int total = 100) //Default 100
        {
            //Dibujar la barra vacia
            Console.CursorLeft = 0;
            Console.Write("["); //inicio
            Console.CursorLeft = 32;
            Console.Write("]"); //fin
            Console.CursorLeft = 1; //Colocar el cursor al inicio
            float onechunk = 30.0f / total;

            //Rellenar la parte indicada
            int position = 1;
            for (int i = 0; i < onechunk * progreso; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //Pintar la otra parte
            for (int i = position; i <= 31; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //Escribir el total al final
            Console.CursorLeft = 35;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(progreso.ToString() + "% de " + total.ToString() + "    ");
        }
    }
}
