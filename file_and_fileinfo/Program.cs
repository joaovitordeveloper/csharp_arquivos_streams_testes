using static System.Console;

WriteLine("Digite o nome do arquivo:");
var nome = ReadLine();
nome = LimparNome(nome);
//criando um arquivos

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");
CriarArquivo(path);

WriteLine("Pressione Enter para continuar...");
ReadLine();
static void CriarArquivo(string path)
{
  try
  {
    using var sw = File.CreateText(path);
    //escrever no arquivo
    sw.WriteLine("Esta e a linha 1");
    sw.WriteLine("Esta e a linha 2");
    sw.WriteLine("Esta e a linha 3");
    //faz a descarga dakilo que esta em memoria
  }
  catch
  {
    WriteLine("O nome do arquivo esta invalido");

  }

}

static string LimparNome(string nome)
{
  foreach (var @char in Path.GetInvalidFileNameChars())
  {
    nome = nome.Replace(@char, '-');
  }
  return nome;
}

