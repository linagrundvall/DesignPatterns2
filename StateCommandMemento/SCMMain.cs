﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och 
         * sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * 
         * 
         * 
         * 
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och 
         * stänger av maskinen. !Använd Memento Pattern!
         */
        public void Run()
        {
            Machine machine = new Machine();
            machine.MachineManager.CreateMemento();

            Console.WriteLine("**************************");
            Console.WriteLine("Welcome to the machine!");
            Console.WriteLine("");
            Console.WriteLine("Please interact");
            Console.WriteLine("");
            Console.WriteLine("1. Turn the machine on/off");
            Console.WriteLine("2. Print stuff");
            Console.WriteLine("3. Reset and turn off machine");
            Console.WriteLine("4. Exit the program");
            Console.WriteLine("");

            while(true)
            { 
                var userInput = Console.ReadKey(intercept: true).Key;
                switch (userInput)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        machine.PowerSwitch();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("Please write stuff to print");
                        var stuff = Console.ReadLine();
                        machine.Execute(stuff);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine("Resetting and turning off.");
                        machine.MachineManager.Reset();
                        machine.PowerSwitch();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Unknown command. Please try again.");
                        break;
                }
            }
        }
    }
}