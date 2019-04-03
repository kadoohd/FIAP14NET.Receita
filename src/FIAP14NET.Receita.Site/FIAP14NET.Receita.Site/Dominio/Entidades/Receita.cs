﻿using System;
using System.Collections.Generic;

namespace FIAP14NET.Receita.Site.Dominio.Entidades
{
    public class Receita
    {
        public Guid Id { get; private set; }

        public IList<Ingrediente> Ingredientes { get; set; } = new List<Ingrediente>();
    }
}
