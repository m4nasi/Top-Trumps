using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Reflection;
using System.Linq.Expressions;

namespace TopTrumps_3
{
    class Card
    {
        //setting up the objects of the cards - has different attributes: name, strength, intelligence, powers, agility, Top Trump rating
        //gets and sets values of each attribute
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int tTRating { get; set; }

        //creates the contructor for the class and creates each variable
        public Card(string name, int strength, int intelligence, int tTRating)
        {
            name = "";
            strength = 0;
            intelligence = 0;
            tTRating = 0;
        }

        public Card()
        {
        }
    }

    class RndNums
    {
        //setting up the objects of the cards - has different attributes: rand and copyNum
        //gets and sets values of each attribute
        public int rand { get; set; }

        //creates the contructor for the class and creates each variable
        public RndNums(int inrand)
        {
            rand = inrand;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //creates an object that brings random into the program - and have named it rnd
            //creates an list of all the cards so all the instances are placed in one array
            //its in an list because I need to manipulate the array
            List<Card> ClassArray = new List<Card>();
            ClassArray.Add(new Card() { name = "Star Lord", strength = 4, intelligence = 15, tTRating = 118 });
            ClassArray.Add(new Card() { name = "Iron Man", strength = 7, intelligence = 20, tTRating = 121 });
            ClassArray.Add(new Card() { name = "Thor", strength = 10, intelligence = 11, tTRating = 115 });
            ClassArray.Add(new Card() { name = "Captain America", strength = 9, intelligence = 23, tTRating = 120 });
            ClassArray.Add(new Card() { name = "Iron Man", strength = 9, intelligence = 25, tTRating = 130 });
            ClassArray.Add(new Card() { name = "Black Panther", strength = 8, intelligence = 22, tTRating = 110 });
            ClassArray.Add(new Card() { name = "Shuri", strength = 3, intelligence = 30, tTRating = 99 });
            ClassArray.Add(new Card() { name = "Hulk", strength = 10, intelligence = 33, tTRating = 125 });
            ClassArray.Add(new Card() { name = "Captain Marvel", strength = 8, intelligence = 24, tTRating = 95 });
            ClassArray.Add(new Card() { name = "Ant Man", strength = 3, intelligence = 22, tTRating = 97 });


            int index = 0;
            Queue<int> player1 = new Queue<int>();
            Queue<int> player2 = new Queue<int>();
            Queue<int> player1strength = new Queue<int>();
            Queue<int> player1intelligence = new Queue<int>();
            Queue<int> player1tTRating = new Queue<int>();
            Queue<int> player2strength = new Queue<int>();
            Queue<int> player2intelligence = new Queue<int>();
            Queue<int> player2tTRating = new Queue<int>();
            string player = "";
            int num = ClassArray.Count;
            bool CanContinue = true;
            while (CanContinue == true)
            {
                for (int i = 0; i < (num); i++)
                {
                    bool loop = true;
                    while (loop == true)
                    {
                        if i < (num / 2){
                            player = "player1";
                        }
                        else
                        {
                            player = "player2";
                        }
                        List<int> randNum = new List<int>();
                        index = rnd.Next(ClassArray.Count);

                        var exists = randNum.Contains(index);

                        if (exists == false)
                        {
                            randNum.Add(index);
                            player1strength.Enqueue(ClassArray[i].strength);
                            player1intelligence.Enqueue(ClassArray[i].intelligence);
                            player1tTRating.Enqueue(ClassArray[i].tTRating);
                            Console.WriteLine("entered loop!");
                            loop = false;
                        }
                        else
                        {
                            loop = true;
                        }
                    }
                    Console.WriteLine("Character Name = {0} Strength = {1} Intelligence = {2} TTrating = {5}", ClassArray[index].name, ClassArray[index].strength, ClassArray[index].intelligence, ClassArray[index].tTRating);
                }

                string winner = "";
                Console.WriteLine("Player 1 please enter the category of your highest value");
                Console.WriteLine("1: strength");
                Console.WriteLine("2: intelligence");
                Console.WriteLine("3: TTRating");
                int category = Convert.ToInt16(Console.ReadLine());
                int search = "0";

                if (category == 1)
                {
                    search = player1strength;
                }
                else if (category == 2)
                {
                    cat = player1intelligence;
                }
                else if (category == 3)
                {
                    cat = player1tTRating;
                }
                else
                {
                    Console.WriteLine("Wrong entry");
                }
                int winningpile1 = 0;
                int winningpile2 = 0;

                Console.WriteLine(ClassArray[0].cat);
                string element1 = player1.Peek();
                string element2 = player1.Peek();
                if (element2 > element1)
                {
                    winningpile2 += winningpile2 + 1;
                    player1.Dequeue();
                    player2.Dequeue();
                }
                else
                {
                    winningpile1 += winningpile1 + 1;
                    player1.Dequeue();
                    player2.Dequeue();
                }

                if (winningpile1 == 10)
                {
                    winner = "Player 1";
                    CanContinue = false;
                }

                else if (winningpile2 == 10)
                {
                    winner = "Player 2";
                    CanContinue = false;
                }

                else
                {
                    CanContinue = true;
                };

                Console.WriteLine("The winner is " + winner);
                Console.WriteLine("Do you want to play again?");
                string replay = Console.ReadLine();
                if (replay.ToLower() == "yes")
                {
                    CanContinue = true;
                }

                else
                {
                    Console.WriteLine("Thanks for playing! :)");
                    CanContinue = false;
                }
            }
        }
    }
}



