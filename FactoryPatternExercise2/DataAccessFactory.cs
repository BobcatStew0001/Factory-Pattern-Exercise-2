namespace FactoryPatternExercise2;

public static class DataAccessFactory
{
    public static IDataAccess GetDataAccessType(string databaseType)
    {
        switch (databaseType.ToLower()) 
        {
            case "list":
                return new  ListDataAccess();
            
            case "sql":  //I originally only had sql but I looked over what Cruz did on his an added the others 
            case "sqlserver":
            case "mysql":    
                return new SQLDataAccess();
            
            case "mongo": //Same as with the SQL I added the MongoDB, because I found it hard even for me to not add the DB
            case "mongodb":    
                return new MongoDataAccess(); 
            
            default:
                return null;
        } 
    }
}