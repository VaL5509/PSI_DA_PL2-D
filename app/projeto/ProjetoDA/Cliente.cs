using ProjetoDA;
using System;
using System.Collections.Generic;

class Cliente
    {

        public String Nome;

        public String NIF;

        private List<Compra> compras;

        public List<Compra> Compras
        {
            get
            {
                return compras;
            }
        }

        public Decimal Total
        {
            get
            {
                Decimal internoTotal = 0;
                foreach (Compra item in compras)
                {
                    internoTotal += item.Total;
                }
                return internoTotal;
            }
        }

        public Cliente(String nome, String NIF)
        {
            this.Nome = nome;
            this.NIF = NIF;
            compras = new List<Compra>();
        }

        public override string ToString()
        {
            return Nome + "(" + NIF + ")";
        }

    }
