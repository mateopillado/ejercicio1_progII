﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public interface IColleccion
    {
        bool estaVacia();

        object extraer();

        object primero();

        bool anadir(object obj);
    }
}
