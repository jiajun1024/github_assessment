using system;

namespace TelephoneCharges
{
    public class TelephoneCharges
    {
        public static void Main(string[] args)
        {
            int localCalls, subsequentCalls, outstationCall; 
            double totalCharges;

            Console.WriteLine("Enter number of local calls: ");
            localCalls = Convert.ToInt32(Console.ReadLine());
            
            if(localCalls <= 100)
            {
                subsequentCalls = 0;
            }
            else
            {
                subsequentCalls = localCalls - 100;
            }

            Console.WriteLine("Enter number of outstation calls: ");
            outstationCalls = double.Parse(Console.ReadLine());

            if(localCalls <= 100 && subsequentCalls == 0 && outstationCalls == 0)
            {
                totalCharges = 20;
            }
            else if(localCalls >= 100 && subsequentCalls != 0 && outstationCalls == 0)
            {
                totalCharges = 20 + (subsequentCalls * 0.1);
            }
            else
            {
                totalCharges = 20 + (subsequentCalls * 0.1) + (outstationCalls * 0.5);
            }

            Console.Write("Total Charges is RM ", totalCharges);

        }
    }
}
