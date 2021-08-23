using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Hotsite.Models
{
    public class DatabaseService
    {
        public int CadastraInteresse(Interesse cad)
        {
            using (DatabaseContext _context = null)
            {
                try
                {
                    _context.Add(cad);
                    _context.SaveChanges();
                    return cad.Id;
                }
                catch
                {
                    throw new Exception("Erro ao cadastrar o interesse (Service)");
                }
            }
        }
    }
}