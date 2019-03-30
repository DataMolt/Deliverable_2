using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_2___Fun_Places
{
    class Program
    {

        static void Main(string[] args)
        {         

            var decision = new Dictionary<string, string>
            {
                { "1", "Action" },
                { "2", "Chilling" },
                { "3", "Danger" },
                { "4", "Good Food" }
            };

            var activities = new Dictionary<string, string>
            {
                { "1", "Stock Car Racing" },
                { "2", "Hiking" },
                { "3", "Skydiving" },
                { "4", "To Taco Bell" }
            };

            var travel = new Dictionary<string, string>
            {
                { "1", "sneakers" },
                { "2", "a sedan" },
                { "3", "a Volkswagen bus" },
                { "4", "an airplane" }
            };

            string input1 = null;
            bool activityCheck = true;
            Console.WriteLine("Hello user, what are you in the mood for?");           
            while (activityCheck == true)
            {
                Console.WriteLine("Here are your options:\n1) Action\n2) Chill times\n3) Danger\n4) Good food");
                input1 = Console.ReadLine();
                if (!(activities.ContainsKey(input1)))
                {
                    Console.WriteLine("Please enter a number value 1 through 4");
                }
                else
                {
                    activityCheck = false;
                }
            }

            string return1 = decision[input1];
            string return2 = activities[input1];

            string return3 = null;
            bool travelCheck = true;
            int input2 = -1;
            while (travelCheck == true)
            {
                Console.WriteLine("How many people are you bringing with you?");
                int value;
                string check = Console.ReadLine();
                if (int.TryParse(check, out value) && int.Parse(check) > -1)
                {
                    input2 = int.Parse(check);
                    travelCheck = false;
                }             
                else
                {
                    Console.WriteLine("Please enter valid, positive integers only");
                }

            }
            if (input2 == 0)
            {
                return3 = travel["1"];
            }
            else if (input2 <= 4)
            {
                return3 = travel["2"];
            }
            else if (input2 <= 10)
            {
                return3 = travel["3"];
            }
            else if (input2 > 10)
            {
                return3 = travel["4"];
            }       
            else
            {
                return3 = "some means I can't understand";
            }
            
            Console.WriteLine("Okay if you’re in the mood for {0}, then you should go to {1} and travel by {2}", 
                return1, return2, return3);
            Console.ReadLine();
        }
    }
}
