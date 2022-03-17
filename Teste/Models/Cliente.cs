using System.ComponentModel.DataAnnotations;

namespace Teste.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }


        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]

        public DateTime Date { get; set; }

        public string Tipo { get; set; }
        [Required]

        public string Cpf { get; set; }
        [Required]

        public string Estadual { get; set; }
        [Required]

        public string Isento { get; set; }
        [Required]

        public string Genero { get; set; }

    }
}
