var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
    { "Ana", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 8, 7, 6 } },
        { "Java", new List<int> { 7, 6, 5 } },
        { "Python", new List<int> { 9, 8, 8 } }
    }}
    };

var studentScore = new Dictionary<string, List<int>> {

        { "João", new List<int> { 5, 5, 5, 5 } },
    };

List<int> scoreJoao = studentScore["João"];
double averageScoreJoao = scoreJoao.Average();

Console.WriteLine("Lista de notas:");
foreach (var score in scoreJoao)
{
    Console.WriteLine(score);

}
Console.WriteLine($"Média das notas {averageScoreJoao}");
/*
Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();

// Adicione notas para alguns alunos
notasAlunos["João"] = new List<double> { 8.5, 9.0, 7.5 };
notasAlunos["Maria"] = new List<double> { 7.0, 8.0, 6.5 };

foreach (var aluno in notasAlunos)
{
    double soma = 0;
    for(int i = 0; i < aluno.Value.Count ; i++){
        soma += aluno.Value[i];
    }
    double media = soma / aluno.Value.Count;
    Console.WriteLine($"Média de {aluno.Key}: {media}");
}*/