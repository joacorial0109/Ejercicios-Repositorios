﻿using System;

namespace Ucu.Poo.Expert
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Shelf estanteria = new Shelf();
            Shelf estanteria2 = new Shelf();
            estanteria.Shelf("A","7");
            estanteria2.Shelf("B","3");


        }
    }
}