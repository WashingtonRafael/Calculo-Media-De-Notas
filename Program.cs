namespace Media_de_Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##################################\n");
            Console.WriteLine("##### CALCULO MÉDIA DA TURMA #####\n");
            Console.WriteLine("##################################\n");
            Console.WriteLine("\nQuantos alunos existem na turma?  ");
            int alunos = Convert.ToInt32(Console.ReadLine());

            int contadorAlunos = 0;
            double notaAlunos = 0.0;
            double total = 0.0;

            while (contadorAlunos < alunos)
            {
                Console.Clear();
                Console.Write($"\nDigite a nota do {contadorAlunos + 1}° aluno: ");
                notaAlunos = Convert.ToDouble(Console.ReadLine());
                total += notaAlunos;
                contadorAlunos++;
            }
            Console.Clear();
            Console.WriteLine("##################################\n");
            Console.WriteLine("##### CALCULO MÉDIA DA TURMA #####\n");
            Console.WriteLine("##################################\n");
            double media = (total / alunos);
            Console.WriteLine($"\n {media.ToString("G2")} foi a média da Turma");
        }
    }
}