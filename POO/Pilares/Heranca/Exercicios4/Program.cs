using Exercicios4;
Aluno a1 = new Aluno();
a1.Nome = "Stephani";
a1.Idade = 16;
a1.Curso = "Desenvolvimento de Sistemas";

Professor p1 = new Professor();
p1.Nome = "Elvis";
p1.Idade = 53;
p1.Disciplina = "Química";

Console.WriteLine(@$"Aluno
Nome: {a1.Nome}
Idade: {a1.Idade}
Curso: {a1.Curso}");
Console.WriteLine($"");
Console.WriteLine($"");
Console.WriteLine(@$"Professor
Nome: {p1.Nome}
Idade: {p1.Idade}
Disciplina: {p1.Disciplina}");