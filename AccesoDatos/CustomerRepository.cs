using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public  class CustomerRepository
    {

        public List<Customers> ObtenerTodos() {
            using (var conexion = DataBase.GetSqlConnection()) {

                String sqlSelectAll = "";
                sqlSelectAll = sqlSelectAll + "SELECT [CustomerID] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[CompanyName] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[ContactName] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[ContactTitle] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[Address] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[City] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[Region] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[PostalCode] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[Country] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[Phone] " + "\n";
                sqlSelectAll = sqlSelectAll + "      ,[Fax] " + "\n";
                sqlSelectAll = sqlSelectAll + "  FROM [dbo].[Customers]";

                var cliente = conexion.Query<Customers>(sqlSelectAll).ToList();
                return cliente;
            }
        }

        public Customers ObtenerPorID(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {

                String sellectPorID = "";
                sellectPorID = sellectPorID + "SELECT [CustomerID] " + "\n";
                sellectPorID = sellectPorID + "      ,[CompanyName] " + "\n";
                sellectPorID = sellectPorID + "      ,[ContactName] " + "\n";
                sellectPorID = sellectPorID + "      ,[ContactTitle] " + "\n";
                sellectPorID = sellectPorID + "      ,[Address] " + "\n";
                sellectPorID = sellectPorID + "      ,[City] " + "\n";
                sellectPorID = sellectPorID + "      ,[Region] " + "\n";
                sellectPorID = sellectPorID + "      ,[PostalCode] " + "\n";
                sellectPorID = sellectPorID + "      ,[Country] " + "\n";
                sellectPorID = sellectPorID + "      ,[Phone] " + "\n";
                sellectPorID = sellectPorID + "      ,[Fax] " + "\n";
                sellectPorID = sellectPorID + "  FROM [dbo].[Customers] " + "\n";
                sellectPorID = sellectPorID + "  WHERE CustomerID = @CustomerID";

                var Cliente = conexion.QueryFirstOrDefault<Customers>(sellectPorID, new { CustomerID = id });
                return Cliente;
            }
    }
    }
}
