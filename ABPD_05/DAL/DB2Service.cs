using CW5.Model;
using CW5.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ABPD_05.DAL
{
    public class DB2Service
    {
        private IConfiguration _configuration;

        public DB2Service(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public int addOrder(OrderRequest request)
        {
            using var con = new SqlConnection(_configuration.GetConnectionString("ProductionDb"));
            using var com = new SqlCommand("AddProductToWarehouse", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@IdProduct", request.IdProduct);
            com.Parameters.AddWithValue("@IdWarehouse", request.IdWarehouse);
            com.Parameters.AddWithValue("@Amount", request.Amount);
            com.Parameters.AddWithValue("@CreatedAt", request.CreateAt);

            con.Open();
            con.Close();
            return 1;
        }
    }
}
