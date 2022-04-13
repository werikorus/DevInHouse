﻿using System;
using System.Collections.Generic;

#nullable disable

namespace practiceAPI.Models
{
    public partial class Autor
    {
        public Autor()
        {
            LivroAutors = new HashSet<LivroAutor>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public bool? Ativo { get; set; }

        public virtual ICollection<LivroAutor> LivroAutors { get; set; }
    }
}
