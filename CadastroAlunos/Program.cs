namespace CadastroAlunos;

//========
// CLASSE ALUNO
//========
public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    
    
}

class Program
{
    static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>();
        int option = 0;

        //========
        // MENU
        //========
        do
        {

            Console.Clear();
            Console.WriteLine("==== MENU ====");
            Console.WriteLine("1 - Cadastrar alunos\n2 - Listar alunos\n3 - Procurar aluno\n4 - Remover aluno\n0 - Sair");
            Console.WriteLine("Escolha: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                {
                    Console.WriteLine("Digite o nome do aluno: ");
                    string novoAlunoNome = Console.ReadLine();

                    Console.WriteLine("Digite a idade do aluno: ");
                    int novoAlunoIdade = int.Parse(Console.ReadLine());

                    alunos.Add(new Aluno
                    {
                        Nome = novoAlunoNome,
                        Idade = novoAlunoIdade
                    });
                    Console.WriteLine("Usuário cadastrado com sucesso!\n");
                    Console.WriteLine("Aperte qualquer tecla para voltar.");
                    Console.ReadKey();

                    break;

                }
                case 2:
                {
                    foreach (Aluno aluno in alunos)
                    {
                        Console.WriteLine($"Aluno: {aluno.Nome}\nIdade: {aluno.Idade}");
                    }
                    Console.WriteLine("Aperte qualquer tecla para voltar");
                    Console.ReadKey();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Digite o nome do aluno a ser procurado: ");
                    string procurarAluno = Console.ReadLine();

                    foreach (Aluno aluno in alunos)
                    {
                        if (procurarAluno == aluno.Nome)
                        {
                            Console.WriteLine($"Aluno: {aluno.Nome}\nIdade: {aluno.Idade}");
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado!");
                        }
                        Console.WriteLine("Aperte qualquer tecla para voltar!");
                        Console.ReadKey();
                    }
                    break;
                }
                case 4:
                {
                    bool alunoRemovido = false;
                    Console.WriteLine("Digite o nome do aluno a ser removido: ");
                    string procurarAluno = Console.ReadLine();

                    for (int i = 0; i < alunos.Count; i++)
                    {
                        if (alunos[i].Nome == procurarAluno)
                        {
                            alunos.RemoveAt(i);
                            Console.WriteLine("Aluno removido!");
                            alunoRemovido = true;
                        }
                    }

                    if (alunoRemovido != true)
                    {
                        Console.WriteLine("Aluno não encontrado!");
                    }
                    Console.WriteLine("Aperte qualquer tecla para voltar");
                    Console.ReadKey();
                    break;
                }
                default:
                {
                    Console.WriteLine("Opção Inválida, aperte qualquer tecla para voltar");
                    Console.ReadKey();
                    break;
                }



            }
        } while (option != 0);
    }

}