using Antlr4.Runtime.Misc;

namespace WorkoutPlan
{
    public class PlanListener : WorkoutBaseListener
    {
        public Plan Plan { get; } = new Plan();
        private Exercise currentExercise;

        public override void EnterExercise([NotNull] WorkoutParser.ExerciseContext context)
        {
            var name = context.NAME().GetText();
            var sets = int.Parse(context.SETS().GetText());
            var reps = int.Parse(context.REPS().GetText());

            currentExercise = new Exercise(name, sets, reps);
        }

        public override void ExitExercise([NotNull] WorkoutParser.ExerciseContext context)
        {
            Plan.AddExercise(currentExercise);
            currentExercise = null;
        }
    }
}