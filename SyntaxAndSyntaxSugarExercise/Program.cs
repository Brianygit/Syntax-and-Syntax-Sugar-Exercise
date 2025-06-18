namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var answerIsLessThan = (answer < 9 ?$"{answer} is less than 9" : $"{answer} is greater than 9");
            Console.WriteLine(answerIsLessThan);
        }
    }
}
