﻿using FactoryPattern.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory
{
    internal interface IAnimalFactory
    {
        IAnimal CreateAnimal();
    }
}
