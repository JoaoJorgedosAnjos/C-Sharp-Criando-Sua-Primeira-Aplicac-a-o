var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
    { "Ana", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 8, 7, 6 } },
        { "Java", new List<int> { 7, 6, 5 } },
        { "Python", new List<int> { 9, 8, 8 } }
    }}
    };

var studentScore = new Dictionary<string, List<int>> {

        { "João", new List<int> { 5, 5, 5, 5 } }
    };

List<int> scoreJoao = studentScore["João"];
double averageScoreJoao = scoreJoao.Average();

Console.WriteLine("Lista de notas:");
foreach (var score in scoreJoao)
{
    Console.WriteLine(score);

}
Console.WriteLine($"Média das notas {averageScoreJoao}");