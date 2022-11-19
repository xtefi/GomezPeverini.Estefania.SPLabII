﻿namespace Entidades
{
    public abstract class Utiles
    {
        int unidades;
        string marca;
        float precio;

        public float Precio { get => this.precio; }
        public Utiles(int unidades, string marca, float precio)
        {
            this.unidades = unidades;
            this.marca = marca;
            this.precio = precio;  
        }

    }
}