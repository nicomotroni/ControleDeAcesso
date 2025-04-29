using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace ControleDeAcessoUi
{
    public class Usuário
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string TipoUsuario { get; set; }
        public string Senha { get; set; }
        //Simulada

        public Usuário(int id, string nome, string cpf, string tipousuario, string senha)
        {

            Id = id;
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipousuario;
            Senha = senha;
        }
        public Usuário(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;

        }
        public void TrocarSenha(string novaSenha)
        {
            Senha = novaSenha;
        }

        // Método para editar dados
        public void Editar(string nome, string cpf, string tipoUsuario)
        {
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipoUsuario;
        }

        // Método para excluir dados
        public void Excluir()
        {
            Id = 0;
            Nome = null;
            Cpf = null;
            TipoUsuario = null;
            Senha = null;
        }

        // Método para mostrar dados
        public void MostrarDados()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Tipo de Usuário: {TipoUsuario}");
        }
    }
    public class RegistroAcesso
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataHora { get; set; }
        public string TipoOperacao { get; set; } // Entrada ou Saída

        // Método para registrar uma operação
        public void Registrar(int usuarioId, string tipoOperacao)
        {
            UsuarioId = usuarioId;
            TipoOperacao = tipoOperacao;
            DataHora = DateTime.Now;
        }

        // Método para exibir o registro
        public void MostrarRegistro()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Usuário Id: {UsuarioId}");
            Console.WriteLine($"Data e Hora: {DataHora}");
            Console.WriteLine($"Tipo de Operação: {TipoOperacao}");
        }



    }
}
//teste
