using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositorys
{
    public class RepositoryIncomes : IRepositoryIncome
    {
        public Incomes GetIncomesByPerson(int PersonId)
        {
            try
            {
                Incomes income = null;


                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;

                    using (var connection = new SqlConnection(ctx.Database.Connection.ConnectionString))
                    {
                        connection.Open();

                        using (var command = new SqlCommand("ObtenerDatosSalario", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@IdPersona", PersonId));

                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    income = new Incomes
                                    {
                                        LastSalary = Convert.ToDecimal(reader["UltimoSalario"]),
                                        Avg2Months = reader["SalarioPromedio2meses"] != DBNull.Value ? Convert.ToDecimal(reader["SalarioPromedio2meses"]) : 0m,
                                        Avg3Months = reader["SalarioPromedio3meses"] != DBNull.Value ? Convert.ToDecimal(reader["SalarioPromedio3meses"]) : 0m,
                                        Avg6Months = reader["SalarioPromedio6meses"] != DBNull.Value ? Convert.ToDecimal(reader["SalarioPromedio6meses"]) : 0m,
                                        AvgYear = reader["SalarioPromedio12meses"] != DBNull.Value ? Convert.ToDecimal(reader["SalarioPromedio12meses"]) : 0m,
                                        LastUpdate = Convert.ToDateTime(reader["FechaActualizacion"])
                                    };
                                }
                            }
                        }
                    }
                }

                return income;
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception(dbEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
