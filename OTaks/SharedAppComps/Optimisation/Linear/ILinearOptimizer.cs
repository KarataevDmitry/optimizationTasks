namespace OptimisationTasks.OptimisationMethods.Linear
{
    public interface ILinearOptimizer
    {
        double [ ] CalcSolution (double[,] taskTable );
    }
}