using Dapper;
using DevHair.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace DevHair.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly string? _connectionString;

        public ClientController(ILogger<ClientController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                const string sql = "SELECT * FROM Clients WHERE IsActive = 1";

                var client = await sqlConnection.QueryAsync<ClientModel>(sql);

                return Ok(client);
            }
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) 
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                string sql = $"SELECT * FROM Clients WHERE Id = {id}";

                var ids = await sqlConnection.QueryFirstAsync<ClientModel>(sql);

                return Ok(ids);
            }
        }

        [HttpPost]
        public async void Post(ClientModel client) 
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                sqlConnection.ExecuteAsync("INSERT INTO Clients(Name, StartDate, EndDate, IsActive) VALUES(@name, @StartDate, @EndDate, @IsActive)", client);
            }
        }

        [HttpPut]
        public async void Put(int id, ClientModel client)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                sqlConnection.Execute("UPDATE Client SET Nome = @Nome, StartDate = @StartDate, EndDate = @EndDate, IsActive = @IsActive WHERE IdCliente = @IdCliente", client);
            }
        }

        [HttpDelete]
        public async void Delete(int id)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                var ids = await sqlConnection.ExecuteAsync($"DELETE FROM Client WHERE Id = @Id", new { Id = id });
            }
        }
    }
}
