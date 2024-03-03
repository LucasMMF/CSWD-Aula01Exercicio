using Aula01Exercicio.Entities;
using Aula01Exercicio.Repositories;

namespace Aula01Exercicio
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Lista de Exercícios 1 - C# WebDeveloper");
            Console.WriteLine("\n *** CADASTRO DE FUNCIONÁRIOS *** \n");

            var funcionario = new Funcionario();

            try
            {
                funcionario.IdFuncionario = Guid.NewGuid();

                Console.Write("Informe o nome do funcionário...............: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("Informe o CPF do funcionário................: ");
                funcionario.Cpf = Console.ReadLine();

                Console.Write("Informe a data de admissão do funcionário...: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                Console.Write("Informe a matricula do funcionário..........: ");
                funcionario.Matricula = Console.ReadLine();

                var funcionarioRepository = new FuncionarioRepository();

                funcionarioRepository.GravarArquivo(funcionario);

                Console.WriteLine("\nDADOS DO FUNCIONÁRIO: ");
                Console.WriteLine($"Id do funcionário........: {funcionario.IdFuncionario}");
                Console.WriteLine($"Nome do funcionário......: {funcionario.Nome}");
                Console.WriteLine($"CPF do funcionário.......: {funcionario.Cpf}");
                Console.WriteLine($"Data de Admissão.........: {funcionario.DataAdmissao}");
                Console.WriteLine($"Matricula................: {funcionario.Matricula}");
            }
            catch (Exception e)
            {
                Console.WriteLine("\n Falha ao cadastrar o funcionário! \n");
                Console.WriteLine($"Erro: {e.Message}");
            }

            Console.ReadKey();

        }
    }
}
