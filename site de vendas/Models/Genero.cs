﻿using System.ComponentModel.DataAnnotations;

namespace site_de_vendas.Models {
    public class Genero {
        public int Id { get; set; }
        
        
        [Required(ErrorMessage = "{0} Requerido")]
        public string Nome { get; set; }
    }
}