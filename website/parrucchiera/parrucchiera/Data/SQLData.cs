using parrucchiera.Models;
using System.Data.SqlClient;
using Dapper;

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
		public List<parrucchieri> GetCaricacliente()
		{
			using (var connection = new SqlConnection(_connectionString))
			{
				string query = @"
SELECT * FROM clienti";
				var cliente = connection.Query<parrucchieri>(query)
							.ToList();
				return cliente;
			}
		}
		public List<cliente> GetCaricaListaClienti()
		{
			using (var connection = new SqlConnection(_connectionString))
			{
				string query = @"
SELECT * FROM clienti";
				var cliente = connection.Query<cliente>(query)
							.ToList();
				return cliente;
			}
		}

        public parrucchieri GetCaricaParrucchiere(int IDParrucchiere)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"
SELECT * FROM Parrucchieri WHERE Id = @IDParrucchiere";
				var parrucchiere = connection.QueryFirst<parrucchieri>(query,  new { IDParrucchiere });
                            
                return parrucchiere;
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
		public List<prenotazione> GetCaricaListaPrenotazioni()
		{
			using (var connection = new SqlConnection(_connectionString))
			{
				string query = @"
SELECT  
    a.[Id]
    ,[clienteID]
    ,[appuntamento_Data_tempo]
    ,[parrucchieraID]
	, [cliente]= c.nome +' '+ c.cognome
	, [parrucchiere]= p.nome +' '+ p.cognome
,    [parrucchiere]= p.codice_immagine
FROM 
    [dbo].[Appuntamenti] a
    inner join dbo.parrucchieri p on p.Id = a.parrucchieraID
    inner join dbo.clienti c on c.Id = a.clienteID
ORDER BY a.[appuntamento_Data_tempo] DESC";
				var prenotazioni = connection.Query<prenotazione>(query)
							.ToList();
				return prenotazioni;
			}
		}

		public void CreaPrenotazione(prenotazione prenotazione, int SelectedClienteId, parrucchieri parrucchiere)
		{
			using (var connection = new SqlConnection(_connectionString))
			{
				string query = @"
INSERT INTO [dbo].[Appuntamenti] VALUES (@SelectedClienteId,@data,@parrucchieraId)";
				var parrucchieri = connection.Execute(query, new { data = prenotazione.appuntamento_Data_tempo, parrucchieraId = parrucchiere.id, SelectedClienteId = SelectedClienteId });

			}
		}

		public void CreaParrucchiere(parrucchieri parrucchiere)
		{
			using (var connection = new SqlConnection(_connectionString))
			{
				string query = @"
INSERT INTO Parrucchieri VALUES (@nome,@cognome,@email,@telefono,'avatar7.png')";
				var parrucchieri = connection.Execute(query, new { nome = parrucchiere.nome, cognome = parrucchiere.cognome, email = parrucchiere.email, telefono = parrucchiere.telefono, codice_immaggine = parrucchiere.codice_immagine });

			}
		}

		public void Creacliente(cliente cliente)
		{
			
				using (var connection = new SqlConnection(_connectionString))
				{
					string query = @"
INSERT INTO clienti VALUES (@nome,@cognome,@email,@ntelefono)";
					var clienti = connection.Execute(query, new { nome = cliente.nome, cognome = cliente.cognome, email = cliente.email, ntelefono = cliente.ntelefono});

				}
			
	
		}
	}
}


