﻿using System;
using System.Collections.Generic;

namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p2 = new Produto();
            p2.nome = "Mochila Camuflada";
            p2.preco = 109.90f;
            p2.Insere();

            Produto p = new Produto();
            List<Produto> lista = p.BuscaTodos();

            foreach (Produto produto in lista) 
            { 
                Console.WriteLine("ID: "+produto.id+" | Nome: "+produto.nome);
            }

        }
    }
}
