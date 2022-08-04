namespace Owomida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vehicle, unionmember;
            double tollprice, tripnumber, totalnumberoftripscost,sumtotal;
            sumtotal = 0;
            int numberofdrivers = 2;

            for (int i = 0; i < numberofdrivers; i++)
            {
                Console.WriteLine("What type of vehicle do you have? ");
                vehicle = Console.ReadLine();
                if (vehicle == "ke")
                {
                    Console.WriteLine("keke");
                    tollprice = 100;
                }
                else if (vehicle == "mo")
                {
                    Console.WriteLine("motorcycle");
                    tollprice = 200;
                }
                else if (vehicle == "mi")
                {
                    Console.WriteLine("minibuses");
                    tollprice = 300;
                }
                else if (vehicle == "bu")
                {
                    Console.WriteLine("buses");
                    tollprice = 400;
                }
                else
                {
                    tollprice = 0;
                }
                Console.WriteLine("How many number of trips have you gone? ");
                tripnumber = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Are you a union member? ");
                unionmember = Console.ReadLine();
                if (unionmember == "y")
                {
                    totalnumberoftripscost = tollprice * tripnumber * 0.7;
                }
                else 
                
                {
                    totalnumberoftripscost = tollprice * tripnumber;
                }
                Console.WriteLine("totalcost "+ totalnumberoftripscost);
                sumtotal += totalnumberoftripscost;
            }
            Console.WriteLine("Your total money: "+ sumtotal);
        }
    }
}