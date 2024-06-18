using parrucchiera.Models;
using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using parrucchiera.viewmodels;
using System.Security.Cryptography.X509Certificates;
namespace parrucchiera.Data
{
    public class SQLData
    {
        private readonly string _connectionString;

        public SQLData()
        {
            _connectionString = "Data Source=localhost;Initial Catalog=Parrucchiera;uid=sa; password=Isolutions2021;Encrypt=False";
        }

        public List<servizi> GetCaricaServizi()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"
SELECT * FROM Servizi";
                var servizi = connection.Query<servizi>(query)
                            .ToList();
                return servizi;
            }
        }
		
		public List<parrucchieri> GetCaricaParrucchieri()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"
SELECT * FROM Parrucchieri";
                var parrucchieri = connection.Query<parrucchieri>(query)
                            .ToList();
                return parrucchieri;
			}
        }

		public void CreaParrucchiere(parrucchieri parrucchiere)
		{
			using (var connection = new SqlConnection(_connectionString))
			{
				string query = @"
INSERT INTO Parrucchieri VALUES (@nome,@cognome,@email,@cellulare)";
				var parrucchieri = connection.Execute(query, new { nome = parrucchiere.nome, cognome = parrucchiere.cognome, email = parrucchiere.email, cellulare = parrucchiere.telefono });
               void CreaParrucchiere(parrucchieri parrucchiere)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"
INSERT INTO Parrucchieri VALUES (@nome,@cognome,@email,@cellulare,'avatar7.png')";
                var parrucchieri = connection.Execute(query, new { nome = parrucchiere.nome, cognome = parrucchiere.cognome, email = parrucchiere.email, cellulare = parrucchiere.telefono });


    }
			}
		}
	}
            }
        }
    

