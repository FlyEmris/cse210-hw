using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
    }
}
        // while loop
        var count = 0;
        while (true)
        {
            Console.WriteLine("Still Going");
            if (count <= 5)
            {
                break;
            }
            ++count
        }

        //do while
        do
        {
            Console.WriteLine("hit");
            count++;
            Console.WriteLine($"Count = {count++}")
        }
        while (count < 5);
        //for loop
        for (var i = 0; i<5; ++i)
        {
            Console.WriteLine($"i = {i}");
        }

        //foreach loop

        var myInts = new int[]{1,2,3,4,5};
        for(var i=0; i<myInts.Length; ++i)
        {
            Console.WriteLine($"i = {i}");
        }

        // Functions

        returnType FunctionName(paramType paramName1, paramType paramName2)
        {
            function body
        }

        //return int

        int Add2(int start)
        {
            return start + 2;
        }
        Console.WriteLine($"Total = {Add2(4)}");

        //void

        void DisplayString(string value)
        {
            Console.WriteLine(value);
        }

        DisplayString("Hello no return value");

        //variable scope

        int SumItAll(in[] numbers)
        {
            var total = 0;
            foreach (var i in numbers)
            {
                total += i;
            }
            return total;
        }

        var numbs = new int[]{1,2,3};
        System.Console.WriteLine($"SumItAll = {SumitAll(numbs)}");
        System.Console.WriteLine($"Total = {total}")




// Classes
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        var car1 = new Car();
        car1._make = "Honda";
        car1._model = "Civic";
        car1._mileage = 30;
        car1._gallonsOfFuel = 10;

        car1.ReduceFuel(3);

        car cars - new List<Cars>();
        cars.Add(car1);

        var miles = car1.RemainingMiles;
        


    }
    public class Car
    {
        public string _make;

        public string _model;

        public int _mileage;

        public int _gallonsOfFuel;


        public int RemainingMiles()
        {
            return _gallonsOfFuel * _mileage;
        }

        public void ReduceFuel(int amount)
        {
            _gallonsOfFuel = _gallonsOfFuel - amount;
        }
    }
}