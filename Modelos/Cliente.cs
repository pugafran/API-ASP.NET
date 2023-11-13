﻿using System.ComponentModel.DataAnnotations;

namespace APIClientes.Modelos
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }
    }
}
