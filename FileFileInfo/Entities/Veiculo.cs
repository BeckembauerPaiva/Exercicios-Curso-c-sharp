﻿using System;

namespace FileFileInfo.Entities
{
    internal class Veiculo
    {
        public string Modelo { get; set; }

        public Veiculo (string modelo) //construtor para forçar a instanciação
        {
            Modelo = modelo;
        }
    }
}
