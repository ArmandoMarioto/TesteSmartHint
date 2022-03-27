using System.ComponentModel.DataAnnotations;

namespace Teste.Models
{
    public class ClienteModel
    {
        [Key]
        public int Id { get; set; }
        /*
         * name
         * email
         * telefone 
         * data
         * tipo
         * cpf
         * estadual
         * isento
         * genero
         * nascimento
         * bloqueado
         * senha
         */
        [Required(ErrorMessage = "Nome completo ou Razão Social do Cliente.")]
        public string? Name { get; set; }
        [Required (ErrorMessage = "Digite o E-mail do Cliente.")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido!")]
        public string? Email { get; set; }
        [Required (ErrorMessage = "Digite o Telefone do Cliente.")]
        [Phone (ErrorMessage = "O Telefone informado não é valido!")]
        public string? Telefone { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Selecione o tipo de Pessoa.")]
        public string? Tipo { get; set; }

        public string? Cpf { get; set; }

        public string? Cnpj { get; set; }

        public string? Estadual { get; set; }
        
        [Required(ErrorMessage = "Erro no campo Isento!")]
        public bool Isento { get; set; }
        
        public string? Genero { get; set; }
        public string? Nascimento { get; set; }
        public bool Bloqueado { get; set; }

        [Required(ErrorMessage = "Digite a senha do cliente!")]
        public string? Senha { get; set; }
    }
}
