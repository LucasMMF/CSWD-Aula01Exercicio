using Aula01Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01Exercicio.Repositories
{
    public class FuncionarioRepository
    {
        public void ExportarDados (Funcionario funcionario)
        {
            var path = $"d:\\temp\\csharp\\webdeveloper\\funcionario_{funcionario.IdFuncionario}.txt";

            var streamWriter = new StreamWriter (path);

            streamWriter.WriteLine($"ID................: {funcionario.IdFuncionario}");
            streamWriter.WriteLine($"NOME..............: {funcionario.Nome}");
            streamWriter.WriteLine($"CPF...............: {funcionario.Cpf}");
            streamWriter.WriteLine($"DATA ADMISSAO.....: {funcionario.DataAdmissao}");
            streamWriter.WriteLine($"MATRICULA.........: {funcionario.Matricula}");

            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
