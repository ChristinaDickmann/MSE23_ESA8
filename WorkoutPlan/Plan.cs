namespace WorkoutPlan
{
    public class Plan
    {
        public List<Exercise> Exercises { get; }

        public Plan()
        {
            Exercises = new List<Exercise>();
        }

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }
    }
}