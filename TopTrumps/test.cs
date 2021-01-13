using System;

public class Class1
{
	public Class1()
	{
        int val = 10;
        int[] num = new int[val]; /* n is an array of 10 integers */

        /* initialize elements of array n */
        for (int i = 0; i < 10; i++)
        {
            num[i] = i + 100;
        }

        /* output each array element's value */
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine("Element[{0}] = {1}", j, num[j]);
        }
    }


    /*
    for (int i = 0; i < 10; i++)
    { 
        bool picked = true;
        while (picked == true)
        {
            int target = rnd.Next(0, num);
            array[i] = target;
            bool isExist = array.find(target);
            if (isExist)
            {
                Console.WriteLine("Element found in the array");
                picked = true;
            }
            else
            {
                Console.WriteLine("Element not found in given array");
                n[i] = target;
                picked = true;
            }
        }

        bool Cancontinue = true;
        do
        {
            int target = rnd.Next(0, num);
            Console.WriteLine(target);
            array[i] = target;
            bool isExist = false;
            isExist = array.find(target);
            Console.WriteLine(isExist);
            if (isExist = true)
            {
                n[i] = target;
                Console.WriteLine("entered");
                Cancontinue = false;
            }
            else
            {
                Console.WriteLine("Same");
                Cancontinue = true;
            }
        } while (Cancontinue = true);

        /* output each array element's value */
    /*for (int j = 0; j < 10; j++)
    {
        //Console.WriteLine("Element[{0}] = {1}", j, n[j]);

    }
    */



    ////
    ///

    /*
            int cat;
            bool parseSuccess = int.TryParse(category, out cat);

            if (parseSuccess)
            {
                Console.WriteLine($"Your category is: {cat}";
            }
            else
            {
                Console.WriteLine("This is not a number!");
            }
        */
}
