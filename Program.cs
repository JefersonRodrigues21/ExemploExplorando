using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Jeferson";
p1.Sobrenome = "Rodrigues";

Pessoa p2 = new Pessoa();
p2.Nome = "Miguel";
p2.Sobrenome = "Rodrigues";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

//----------------------------------------------------
// Pessoa p1 = new Pessoa();
// p1.Nome = "Jeferson";
// p1.Sobrenome = "Rodrigues";
// p1.Idade = 38;
// p1.Apresentar();
