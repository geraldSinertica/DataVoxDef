using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositorys
{
    public class RepositoryReport : IRepositoryReport
    {
        private IRepositoryPersona repositoryPersona;
        private IRepositoryIncome repositoryIncome;
        private IRepositoryOperations repositoryOperations;
        private IRepositoryJuicios repositoryJuicios;
        private IRepositoryStates repositoryStates;
        private IRepositoryConsulta repositoryConsulta;
        public RepositoryReport()
        {
            repositoryPersona = new RepositoryPersona();
            repositoryIncome = new RepositoryIncomes();
            repositoryOperations = new RepositoryOperations();
            repositoryJuicios = new RepositoryJuicios();
            repositoryStates = new RepositoryStates();
            repositoryConsulta = new RepositoryConsulta();
        }
        public Report PersonReport(string identification)
        {
            try
            {
                int PersonId = 0;

                Report report = null;

                ApplicantInformation personalData = null;
                Incomes Incomes = null;
                Operations operations = new Operations();
                States states = new States();
                PersonalProperty personalProperty = new PersonalProperty();

                List<Consulta> consultas = new List<Consulta>();
                List<tb_Juicio> juicios = new List<tb_Juicio>();


                personalData = repositoryPersona.GetPersonalInformation(identification);
               

                if (personalData != null)
                {
                    PersonId = personalData.InformacionPersonal.PersonId;
                    if(PersonId > 0)
                    {
                        Incomes = repositoryIncome.GetIncomesByPerson(PersonId);
                        operations = repositoryOperations.GetOperationsbyPerson(PersonId);
                        juicios = repositoryJuicios.GetJudgmentsbyPerson(PersonId);
                        states = repositoryStates.GetStatesByPerson(PersonId);
                        consultas = repositoryConsulta.GetAllByPerson(PersonId);
                       
                    }
                    
                }


                if (personalData != null)
                {
                    report = new Report();
                    report.DatosGenerales = personalData;
                    report.Ingresos = Incomes;
                    report.Obligaciones = operations;
                    report.Demandas = juicios;
                    report.Propiedades = states;
                    report.HistorialConsultas = consultas;

                }



                return report;
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
