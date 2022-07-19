
var path = Path.Combine(Environment.CurrentDirectory, "globo");
//criando um diretorio

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