﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Habilidad
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //Relaciones

        public List<Candidato> Candidatos { get; set; }

    }
}
