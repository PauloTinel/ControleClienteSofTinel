using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data.Common;
using System.IO;
using ControleClienteSofTinel.Dominio.Entidades;
using ControleClienteSofTinel.Dominio.Identity;

namespace ControleClienteSofTinel.Data.Context
{
    public class SvaContext : IdentityDbContext<ApplicationUser>
    {
        private string _conexao;
        private string _Situacao;

        public SvaContext()
        {
        }

        #region Tabelas
        public DbSet<ADMAdministradorVO> ADMAdministrador { get; set; }
        public DbSet<ADMEmpresaVO> Empresa{ get; set; }
        public DbSet<ADMPedidoVO> Pedido { get; set; }
        public DbSet<ADMPedidoStatusVO> PedidoStatus{ get; set; }
        public DbSet<ADMPlanoVO> Plano { get; set; }
        public DbSet<ADMRemessaVO> Remessas { get; set; }
        public DbSet<ADMSegmentoVO> Segmento { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (string.IsNullOrWhiteSpace(_conexao) || string.IsNullOrWhiteSpace(_Situacao))
            {
                IConfigurationRoot config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                if (string.IsNullOrWhiteSpace(_conexao))
                {
                    _conexao = config["ConexaoPadrao"];
                }
                if (string.IsNullOrWhiteSpace(_Situacao))
                {
                    _Situacao = config["Situacao"];
                }

                string connectionString = "Data Source=DESKTOP-QJLMS2H\\MSSQLSERVER01;Initial Catalog=ControleClienteSofTinel;Integrated Security=True";

                _Situacao = "mssql";
                switch (_Situacao.ToLower())
                {
                    case "mysql":
                        //optionsBuilder.UseMySql(connectionString);
                        break;
                    case "mssql":
                        optionsBuilder.UseSqlServer(connectionString);
                        break;
                        //case "oracle":
                        //    optionsBuilder.UseSqlOracle(connectionString);
                        //    break;
                        //Complementar com os Use provaveis

                }
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly(new AdministradorMap());
            //modelBuilder.ApplyConfiguration(new EmpresaMap());
            //modelBuilder.ApplyConfiguration(new ParametroMap());
            //modelBuilder.ApplyConfiguration(new PedidoMap());
            //modelBuilder.ApplyConfiguration(new PedidoStatusMap());
            //modelBuilder.ApplyConfiguration(new PlanoMap());
            //modelBuilder.ApplyConfiguration(new RemessaMap());
            //modelBuilder.ApplyConfiguration(new SegmentoMap());
             }
    
        public DbParameter GetDbParameter(string parameterName, object parameterValue)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            _Situacao = config["Situacao"];
            _Situacao = "mssql";
            DbParameter retValue = null;
            switch (_Situacao.ToLower())
            {
                case "mysql":
                   // retValue = new MySqlParameter();
                    break;
                case "mssql":
                    retValue = new SqlParameter();
                    break;
                default:
                    retValue = new SqlParameter();
                    break;
            }
            retValue.ParameterName = parameterName;
            retValue.Value = parameterValue;

            return retValue;
        }
    }
}
