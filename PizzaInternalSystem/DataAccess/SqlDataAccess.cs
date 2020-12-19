using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace PizzaDataLibrary.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public string GetConnectionString(string connectionName = "PizzaDB")
        {
            return _config.GetConnectionString(connectionName);
        }

        /// <summary>
        /// Загружает данные из БД.
        /// </summary>
        /// <typeparam name="T">Тип данных для загрузки</typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="sql">SQL код для выполнения</param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            string connectionString = GetConnectionString();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);
                return data.ToList();
            }
        }

        public async Task ExecuteSQLQuery<T>(string sql, T data)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    await connection.ExecuteAsync(sql, data);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public async Task<int> InsertDataIntoDatabase<T>(string sql, T data)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    return await connection.QuerySingleAsync<int>(sql, data);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public Task<List<T>> SearchData<T, U>(string sql, U parameters)
        {
            throw new NotImplementedException();
        }
    }
}