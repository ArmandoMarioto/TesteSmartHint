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
        [Required(ErrorMessage ="Digite o nome do Cliente!")]
        public string Name { get; set; }
        [Required (ErrorMessage ="Digite o Email do cliente!")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido!")]
        public string Email { get; set; }
        [Required (ErrorMessage = "Digite o Telefone do cliente!")]
        [Phone (ErrorMessage = "O Telefone informado não é valido!")]
        public string Telefone { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public string Tipo { get; set; }
        [Required(ErrorMessage = "Digite o CPF/CNPJ do cliente!")]
        public string Cpf { get; set; }
        
        [Required (ErrorMessage = "Digite o Estadual do cliente!")]
        public string Estadual { get; set; }
        
        [Required(ErrorMessage = "Erro no campo Isento!")]
        public bool Isento { get; set; }
        
        [Required(ErrorMessage = "Erro no campo Genero!")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Selecione a data de nascimento.")]
        public string Nascimento { get; set; }
        public bool Bloqueado { get; set; }

        [Required(ErrorMessage = "Digite a senha do cliente!")]
        public string senha { get; set; }

    }
}
