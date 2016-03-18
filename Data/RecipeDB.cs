using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class RecipeDB
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Servings { get; set; }
    }
}