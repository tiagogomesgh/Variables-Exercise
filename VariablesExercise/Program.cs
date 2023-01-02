namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patient Information:");
            Console.WriteLine($"Name: {myName}  |  Age: {myAge}  |  Gender: {myGender}");
            Console.WriteLine($"Organ Donor: {isOrganDonor}  |  Blinks/Min: {blinksPerMinute}  |  Blinks/Sec : {blinksPerSecond}");
        }

        static string myName = "Tiago";

        static int myAge = 21;

        static char myGender = 'M';

        static bool isOrganDonor = true;

        static double blinksPerMinute = 76.2;

        static decimal blinksPerSecond = .4M;

    }
}
