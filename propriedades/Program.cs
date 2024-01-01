using System.ComponentModel.Design.Serialization;
using propriedades.Models;

Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Mateus", email: "lucas@gmail.com");
Pessoa p2 = new Pessoa(nome: "Elon", sobrenome: "Musk", email: "elon@gmail.com");
Pessoa p3 = new Pessoa(nome: "Thomas", sobrenome: "Edison", email: "thomas@gmail.com");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();




























/*
Pessoa p1 = new Pessoa();
p1.Nome = "Lucas";
p1.Sobrenome = "Mateus";
p1.Idade = 18;
p1.Email = "Exemplo@gmail.com";
p1.Apresentar();
*/