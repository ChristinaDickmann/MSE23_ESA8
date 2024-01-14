using System.Net.Sockets;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace WorkoutPlan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your workout plan. Each row has to be like this: exercise sets x reps");
            Console.WriteLine("For exercise, you can choose between: Squat, Lunge, LegCurl, LegExtension, HipThrust");
            Console.WriteLine("If you are finished with typing, press Enter.");
            Console.WriteLine();

            // read input
            StringBuilder inputText = new StringBuilder();

            string line;
            while (!string.IsNullOrWhiteSpace(line=Console.ReadLine()))
            {
                inputText.AppendLine(line);
            }

            AntlrInputStream inputStream = new AntlrInputStream(inputText.ToString());
            WorkoutLexer workoutLexer = new WorkoutLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(workoutLexer);
            WorkoutParser workoutParser = new WorkoutParser(commonTokenStream);

            WorkoutParser.PlanContext tree = workoutParser.plan();

            PlanListener planListener = new PlanListener();
            ParseTreeWalker.Default.Walk(planListener, tree);

            Plan workoutPlan = planListener.Plan;

            Console.WriteLine("You entered following workout plan:");
            foreach (var exercise in workoutPlan.Exercises)
            {
                Console.WriteLine($"exercise: {exercise.Name}, Sets: {exercise.Sets}, Reps: {exercise.Reps}");
            }

        }

    }
}