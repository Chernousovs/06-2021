using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> list = new List<ISound>();
            list.Add(new Firework());
            list.Add(new Parrot());
            list.Add(new Radio());
            
            list.ForEach(soundMaker => soundMaker.PlaySound());
        }
    }
} 