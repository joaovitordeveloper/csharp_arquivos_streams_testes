
CriarDiretorioGlobo();
CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do sul", "brasil", "brasil.txt");

//MoverArquivo(origem, destino);
CopiarArquivo(origem, destino);

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
  // if (!File.Exists(pathOrigem))
  // {
  //   System.Console.WriteLine("O arquivo de origem não existe:");
  //   return;
  // }


  // if (File.Exists(pathDestino))
  // {
  //   System.Console.WriteLine("O arquivo ja existe no destino:");
  //   return;
  // }

  File.Copy(pathOrigem, pathDestino);
}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
  if (!File.Exists(pathOrigem))
  {
    System.Console.WriteLine("O arquivo de origem não existe:");
    return;
  }


  if (File.Exists(pathDestino))
  {
    System.Console.WriteLine("O arquivo ja existe no destino:");
    return;
  }

  File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
  var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
  if (!File.Exists(path))
  {
    using var sw = File.CreateText(path);
    sw.WriteLine("População: 200MM");
    sw.WriteLine("IDH: 0,901");
    sw.WriteLine("Dados atualizados em: 20/05/2021");
  }
}

static void CriarDiretorioGlobo()
{
  var path = Path.Combine(Environment.CurrentDirectory, "globo");
  //criando um diretorio
  if (!Directory.Exists(path))
  {
    var dirGlob = Directory.CreateDirectory(path);
    var dirAmCentral = dirGlob.CreateSubdirectory("América central");
    var dirAmNorte = dirGlob.CreateSubdirectory("América do norte");
    var dirAmSul = dirGlob.CreateSubdirectory("América do sul");

    dirAmNorte.CreateSubdirectory("USA");
    dirAmNorte.CreateSubdirectory("Mexico");
    dirAmNorte.CreateSubdirectory("Canada");

    dirAmCentral.CreateSubdirectory("Costa Rica");
    dirAmCentral.CreateSubdirectory("Panama");

    dirAmSul.CreateSubdirectory("Brasil");
    dirAmSul.CreateSubdirectory("Argentina");
    dirAmSul.CreateSubdirectory("Paraguai");
  }
}