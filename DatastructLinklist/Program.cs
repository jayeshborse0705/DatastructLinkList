﻿using System;
namespace DatastructureLinkList
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linklist operation:");
            Linklist list = new Linklist();
            list.Add(56);
            list.Add(30);
            list.Add(70);

            list.Display();


        }

    }
}

