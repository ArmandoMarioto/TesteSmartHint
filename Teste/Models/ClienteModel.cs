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
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public string Tipo { get; set; }
        [Required]

        public string Cpf { get; set; }
        [Required]

        public string Estadual { get; set; }
        [Required]

        public bool Isento { get; set; }
        [Required]

        public string Genero { get; set; }

        public string Nascimento { get; set; }
        public bool Bloqueado { get; set; }

        public string senha { get; set; }

    }
}
