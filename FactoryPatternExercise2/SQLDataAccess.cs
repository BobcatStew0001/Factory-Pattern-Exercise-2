namespace FactoryPatternExercise2;

public class SQLDataAccess : IDataAccess
{
    public void LoadData()
    {
        Console.WriteLine("I am reading data from a SQL Database");
    }

    public void SaveData()
    {
        Console.WriteLine("I am saving data to a SQL Database");
    }
}