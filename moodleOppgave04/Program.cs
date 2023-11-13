namespace moodleOppgave04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int calculate(int num1, int num2)
            {
                int sum = num1 + num2;

                return sum;
            }

            Console.WriteLine($"Sum av \"A\" og \"B\" er: {calculate(2, 2)}");
        }
    }
}