public class Orm : IDisposable
{
    private Database database;
    private bool _disposed = false;

    public Orm(Database database)
    {
        this.database = database;
    }

    public void Begin() => database.BeginTransaction();

    public void Write(string data)
    {
        try {
            database.Write(data);
        }
        catch (InvalidOperationException) {
            Dispose(); 
             
        }
    }

    public void Commit()
    {
        try {
            database.EndTransaction();
        }
        catch (InvalidOperationException) {
            Dispose();
           
        }
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            database?.Dispose(); 
            _disposed = true;
        }
        GC.SuppressFinalize(this);
    }
}