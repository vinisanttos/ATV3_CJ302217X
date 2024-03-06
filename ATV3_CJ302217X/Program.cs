namespace ATV3_CJ302217X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n;

            Console.WriteLine("Digite a sua nota");
            n = float.Parse(Console.ReadLine());

            if (n >= 6)
            {
                Console.WriteLine("Aluno foi aprovado");
            }
            else
            {
                Console.WriteLine("Aluno foi Reprovado");
            }
        }
    }
}