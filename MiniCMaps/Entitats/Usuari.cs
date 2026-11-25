using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MiniPractica.Entitats;

public class Usuari
{
        public int  UsuariId {get; set;}
        
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string NomUsuari {get; set;}
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email {get; set;}
        public DateTime DataRegistre {get; set;}

        public int Karma { get; set; } = 0;
}