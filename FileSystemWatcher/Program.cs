
internal class Program
{
  private static void Main(string[] args)
  {
    var path = @"C:\xampp\htdocs\csharp_arquivos_streams_testes\Directory_and_DirectoryInfo\globo";
    using var fsw = new FileSystemWatcher(path);

    fsw.Created += OnCreated;
    fsw.Deleted += OnDeleted;
    fsw.Renamed += OnRenamed;

    fsw.EnableRaisingEvents = true;
    fsw.IncludeSubdirectories = true;

    System.Console.WriteLine("monitoramento de eventos na pasta Globo");
    System.Console.WriteLine("Pressione [enter] para finalizar");
    System.Console.console.ReadLine();

    void OnCreated(object sender, FileSystemEventArgs e)
    {
      System.Console.WriteLine($"foi criado o arquivo {e.Name}");
    }

    void OnDeleted(object sender, FileSystemEventArgs e)
    {
      System.Console.WriteLine($"foi excluido o arquivo {e.Name}");
    }

    void OnRenamed(object sender, FileSystemEventArgs e)
    {
      System.Console.WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}");
    }
  }
}