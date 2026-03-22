namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Database would you like to use?: List, SQL, MongoDB");
            
            var databaseName = Console.ReadLine();
            
            var database = DataAccessFactory.GetDataAccessType(databaseName);
            
            database.LoadData();
            database.SaveData();
            
            
        }
    }
}
