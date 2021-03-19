using System;
using System.Collections.Generic;

namespace ATV2_ORIG.Models
{
    public class CadastroCliente
    {
        private static List<Dados> dados = new List<Dados>();
        public static void Incluir (Dados cliente)
        {
            dados.Add(cliente);
        }
        public static List<Dados> Listar()
        {
            return dados;
        }
    }
}