using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
static void Main(string[] args)
{
    using (var context = new CadastroContext())
    {
        //Log da consulta que será realizada
        context.Database.Log = Console.Write;

        var cadastros = context.Cadastros.Where(a => a.EmailPrincipal == "rodolfo.fadino@gmail.com").ToList();

        foreach (var cadastro in cadastros)
        {
            Console.WriteLine("----- cadastro ------");
            Console.WriteLine(cadastro.Id);
            Console.WriteLine(cadastro.NomeCompleto);
        }
    }
}
    }
}
