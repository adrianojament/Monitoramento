using Microsoft.EntityFrameworkCore;
using Monitoramento.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoramento.Infra.Data.Context
{
    public class MonitoramentoContexto : DbContext
    {

        public MonitoramentoContexto(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Servidor> Servidores { get; set; }
    }
}
