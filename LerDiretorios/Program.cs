
var path = @"C:\xampp\htdocs\csharp_arquivos_streams_testes\Directory_and_DirectoryInfo\globo";
//LerDiretorios(path);
LerArquivos(path);

System.Console.WriteLine("Digite enter para finalizar...");
System.Console.ReadLine();

static void LerDiretorios(string path)
{

  if (Directory.Exists(path))
  {
    var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
    foreach (var dir in diretorios)
    {
      var dirInfo = new DirectoryInfo(dir);
      System.Console.WriteLine($"[Nome]:{dirInfo.Name}");
      System.Console.WriteLine($"[Raiz]:{dirInfo.Root}");
      if (dirInfo.Parent != null)
        System.Console.WriteLine($"[Pai]:{dirInfo.Parent.Name}");
      System.Console.WriteLine("----------------------------------");
    }
  }
  else
  {
    System.Console.WriteLine($"{path} não existe");
  }

}

static void LerArquivos(string path)
{
  var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
  foreach (var arquivo in arquivos)
  {
    var fileInfo = new FileInfo(arquivo);
    System.Console.WriteLine($"[Nome]:{fileInfo.Name}");
    System.Console.WriteLine($"[Tamanho]:{fileInfo.Length}");
    System.Console.WriteLine($"[Ultimo acesso]:{fileInfo.LastAccessTime}");
    System.Console.WriteLine($"[Pasta]:{fileInfo.DirectoryName}");
    System.Console.WriteLine("-----------------------------------");
  }
}
