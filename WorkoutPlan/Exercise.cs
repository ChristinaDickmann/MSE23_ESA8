namespace WorkoutPlan
{
    public class Exercise
    {
        public string Name { get; }
        public int Sets { get; }
        public int Reps { get; }

        public Exercise(string name, int sets, int reps)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
            
            Name = name;
            Sets = sets;
            Reps = reps;
        }

    }
}