using OptimisationTasks.DataStructures;
using OptimisationTasks.FileOperations;

namespace OptimisationTasks.OptimisationMethods
{
    /// <summary>
    /// Абстрактный класс, представляющий интерфейс для всех конкретных методов оптимизации
    /// </summary>
    public abstract class OptimizationMethod
    {
        /// <summary>
        /// Выполняет поиск оптимального решения с условиями, 
        /// заданными в описании задачи.
        /// Все методы этого класса возвращают оптимальное значение, если оно существует и null в противном случае
        /// </summary>
        /// <param name="t">Задача на оптимизацию</param>
        public abstract double? Optimise(Task1D t, double eps);
        /// <summary>
        /// Выполняет поиск оптимального решения в направлении 
        /// <paramref>d</paramref>, которое может отличаться от заданного в описании 
        /// </summary>
        /// <param name="pathToFile">Путь до файла с задачей</param>
        /// <param name="d">Вид (направление) оптимума</param>
        public double? Optimise(string pathToFile, OptKind d, double eps)
            {
            var task = TaskReader.ReadTaskFromFile(pathToFile);
            return Optimise(new Task1D(task.TargetFunction, d, task.VariableName, task.OptimumInterval), eps);
            }
        /// <summary>
        /// Читает описание задачи из файла и вызывает <code>this.Optimise(Task1D t)</code> для решения задачи
        /// </summary>
        /// <param name="pathToTaskFile">Путь к файлу, содержащему описание задачи</param>
        public double? Optimise(string pathToTaskFile, double eps) => 
            Optimise(TaskReader.ReadTaskFromFile(pathToTaskFile), eps);
    }
}