﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Builder.Composite.Ingredients.Interfaces
{
    public interface IIngredientModelProtocol
    {
        public string Name { get; set; }
        public int Amount { get; set; }
    }
}
