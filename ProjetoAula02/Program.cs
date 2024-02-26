using ProjetoAula02.Controllers;

class Program
{
    static void Main(string[] args)
    {
        FuncionarioController controller = new FuncionarioController();
        controller.CadastrarFuncionario();
    }
}