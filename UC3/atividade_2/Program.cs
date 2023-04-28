using System;
namespace atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int dia, mes, ano;
            string senha;
            DateTime data_nascimento = DateTime.Now;
            Boolean validar_data = false;

            Console.WriteLine("Qual é o seu nome? ");
            nome = Console.ReadLine();

            while (!validar_data) {
                Console.WriteLine("Em qual dia você nasceu? ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Em qual mês você nasceu? ");
                mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Em qual ano você nasceu? ");
                ano = int.Parse(Console.ReadLine());
                try {
                    data_nascimento = new DateTime(ano, mes, dia);
                    validar_data = true;
                }
                catch {
                    Console.WriteLine("Data inválida!");
                }
            }

            var idade = (int)(DateTime.Today.Subtract(data_nascimento).TotalDays/365);
            Console.WriteLine(idade);

            if(idade<18) {
                senha = nome + idade;
            }
            else {
                senha = idade + nome;
            }

            Console.WriteLine("Sugestão de senha: " + senha);
        }
    }
}