namespace ExercicioAlunos;
class Program{
    static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();

        Console.WriteLine("Nome do Aluno: ");
        aluno1.nome = Console.ReadLine();
        //Console.WriteLine("O nome do aluno é: "+ nome);
        Console.WriteLine("***************************");

        Console.WriteLine("Primeira nota: ");
        aluno1.nota1 = double.Parse(Console.ReadLine());
        //Console.WriteLine("A primeira nota é: "+ nota1);

        Console.WriteLine("Segunda nota: ");
        aluno1.nota2 = double.Parse(Console.ReadLine());
        //Console.WriteLine("A segunda nota é: "+ nota2);

        aluno1.mensagem();
    }
}
