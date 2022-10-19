using SalesCome.DAC.DBContext;
using SalesCome.Infrastructure.Services.Products.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SalesCome.Infrastructure.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly ISalesContext _salesContext;

        public ProductService(ISalesContext salesContext)
        {
            _salesContext = salesContext;
        }
        public async Task<bool> SaveProductAsync(ProductRequestModel client)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 0},
                new SqlParameter { ParameterName = "@Id_ProductCategory", SqlDbType = SqlDbType.Int, Value = client.ProductCategory},
                new SqlParameter { ParameterName = "@Id_TradeMark", SqlDbType = SqlDbType.Int, Value = client.TradeMark},
                new SqlParameter { ParameterName = "@Id_ThirdParty", SqlDbType = SqlDbType.BigInt, Value = client.ProviderId},
                new SqlParameter { ParameterName = "@Product_Name", SqlDbType = SqlDbType.NVarChar, Value = client.ProductName},
                new SqlParameter { ParameterName = "@Product_Description", SqlDbType = SqlDbType.NVarChar, Value = client.ProducDescription},
                new SqlParameter { ParameterName = "@Active", SqlDbType = SqlDbType.Bit, Value = client.Active},
                new SqlParameter { ParameterName = "@CreateAccess", SqlDbType = SqlDbType.Int, Value = client.UserCreate},
                new SqlParameter { ParameterName = "@Id_Product", SqlDbType = SqlDbType.BigInt, Value = client.ProductId}
            };

            int result = await _salesContext.ExecuteNonQueryAsync("db_thirdparties.sp_CRUDProductos", parameters);

            if (result > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> UpdateProductAsync(ProductRequestModel client)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 1},
                new SqlParameter { ParameterName = "@Id_ProductCategory", SqlDbType = SqlDbType.Int, Value = client.ProductCategory},
                new SqlParameter { ParameterName = "@Id_TradeMark", SqlDbType = SqlDbType.Int, Value = client.TradeMark},
                new SqlParameter { ParameterName = "@Id_ThirdParty", SqlDbType = SqlDbType.BigInt, Value = client.ProviderId},
                new SqlParameter { ParameterName = "@Product_Name", SqlDbType = SqlDbType.NVarChar, Value = client.ProductName},
                new SqlParameter { ParameterName = "@Product_Description", SqlDbType = SqlDbType.NVarChar, Value = client.ProducDescription},
                new SqlParameter { ParameterName = "@Active", SqlDbType = SqlDbType.Bit, Value = client.Active},
                new SqlParameter { ParameterName = "@CreateAccess", SqlDbType = SqlDbType.Int, Value = client.UserCreate},
                new SqlParameter { ParameterName = "@Id_Product", SqlDbType = SqlDbType.BigInt, Value = client.ProductId}
            };

            int result = await _salesContext.ExecuteNonQueryAsync("db_thirdparties.sp_CRUDProductos", parameters);

            if (result > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> DeleteProductAsync(ProductRequestModel client)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 2},
                new SqlParameter { ParameterName = "@Id_ProductCategory", SqlDbType = SqlDbType.Int, Value = client.ProductCategory},
                new SqlParameter { ParameterName = "@Id_TradeMark", SqlDbType = SqlDbType.Int, Value = client.TradeMark},
                new SqlParameter { ParameterName = "@Id_ThirdParty", SqlDbType = SqlDbType.BigInt, Value = client.ProviderId},
                new SqlParameter { ParameterName = "@Product_Name", SqlDbType = SqlDbType.NVarChar, Value = client.ProductName},
                new SqlParameter { ParameterName = "@Product_Description", SqlDbType = SqlDbType.NVarChar, Value = client.ProducDescription},
                new SqlParameter { ParameterName = "@Active", SqlDbType = SqlDbType.Bit, Value = client.Active},
                new SqlParameter { ParameterName = "@CreateAccess", SqlDbType = SqlDbType.Int, Value = client.UserCreate},
                new SqlParameter { ParameterName = "@Id_Product", SqlDbType = SqlDbType.BigInt, Value = client.ProductId}
            };

            int result = await _salesContext.ExecuteNonQueryAsync("db_thirdparties.sp_CRUDProductos", parameters);

            if (result > 0)
                return true;
            else
                return false;
        }

        public async Task<List<ProductResponseModel>> GetProductsAsync()
        {
            List<ProductResponseModel> productResponseCollection = new List<ProductResponseModel>();

            var parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 3},
                new SqlParameter { ParameterName = "@Id_ProductCategory", SqlDbType = SqlDbType.Int, Value = null},
                new SqlParameter { ParameterName = "@Id_TradeMark", SqlDbType = SqlDbType.Int, Value = null},
                new SqlParameter { ParameterName = "@Id_ThirdParty", SqlDbType = SqlDbType.BigInt, Value = null},
                new SqlParameter { ParameterName = "@Product_Name", SqlDbType = SqlDbType.NVarChar, Value = null},
                new SqlParameter { ParameterName = "@Product_Description", SqlDbType = SqlDbType.NVarChar, Value =null},
                new SqlParameter { ParameterName = "@Active", SqlDbType = SqlDbType.Bit, Value = null},
                new SqlParameter { ParameterName = "@CreateAccess", SqlDbType = SqlDbType.Int, Value = 0},
                new SqlParameter { ParameterName = "@Id_Product", SqlDbType = SqlDbType.BigInt, Value = 0}
            };

            DataSet ds = await _salesContext.Fill("db_thirdparties.sp_CRUDProductos", parameters);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ProductResponseModel productResponse = new ProductResponseModel()
                    {
                        ProductId = long.Parse(dr["Id_Product"].ToString()),
                        ProductName = dr["Product_Name"].ToString(),
                        ProducDescription = dr["Product_Description"].ToString(),
                        CategoryProduct = dr["Categoria"].ToString(),
                        TradeMark = dr["Marca"].ToString(),
                        Active = bool.Parse(dr["Active"].ToString()),
                        QuantitieCollection = await QuantityCollectionAsync(long.Parse(dr["Id_Product"].ToString()))                        
                    };

                    productResponseCollection.Add(productResponse);
                }
            }

            return productResponseCollection;
        }

        public async Task<bool> SaveQuantityAsync(QuantityRequestModel contact)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 0},
                new SqlParameter { ParameterName = "@Id_Product", SqlDbType = SqlDbType.BigInt, Value = contact.ProductId},
                new SqlParameter { ParameterName = "@Quantity", SqlDbType = SqlDbType.Int, Value = contact.Quantity},
                new SqlParameter { ParameterName = "@UnitValue", SqlDbType = SqlDbType.Decimal, Value = contact.UnitValue},
                new SqlParameter { ParameterName = "@Id_Quantity", SqlDbType = SqlDbType.BigInt, Value = contact.QuantityId}
            };


            int result = await _salesContext.ExecuteNonQueryAsync("db_thirdparties.sp_Quantities", parameters);

            if (result > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> UpdateQuantityAsync(QuantityRequestModel contact)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 1},
                new SqlParameter { ParameterName = "@Id_Product", SqlDbType = SqlDbType.BigInt, Value = contact.ProductId},
                new SqlParameter { ParameterName = "@Quantity", SqlDbType = SqlDbType.Int, Value = contact.Quantity},
                new SqlParameter { ParameterName = "@UnitValue", SqlDbType = SqlDbType.Decimal, Value = contact.UnitValue},
                new SqlParameter { ParameterName = "@Id_Quantity", SqlDbType = SqlDbType.BigInt, Value = contact.QuantityId}
            };


            int result = await _salesContext.ExecuteNonQueryAsync("db_thirdparties.sp_Quantities", parameters);

            if (result > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> DeleteQuantityAsync(QuantityRequestModel contact)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 2},
                new SqlParameter { ParameterName = "@Id_Product", SqlDbType = SqlDbType.BigInt, Value = contact.ProductId},
                new SqlParameter { ParameterName = "@Quantity", SqlDbType = SqlDbType.Int, Value = contact.Quantity},
                new SqlParameter { ParameterName = "@UnitValue", SqlDbType = SqlDbType.Decimal, Value = contact.UnitValue},
                new SqlParameter { ParameterName = "@Id_Quantity", SqlDbType = SqlDbType.BigInt, Value = contact.QuantityId}
            };


            int result = await _salesContext.ExecuteNonQueryAsync("db_thirdparties.sp_Quantities", parameters);

            if (result > 0)
                return true;
            else
                return false;
        }

        public async Task<List<QuantityResponseModel>> QuantityCollectionAsync(long ClientId)
        {
            List<QuantityResponseModel> quantityResponseCollection = new List<QuantityResponseModel>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 3},
                new SqlParameter { ParameterName = "@Id_Product", SqlDbType = SqlDbType.BigInt, Value = ClientId},
                new SqlParameter { ParameterName = "@Quantity", SqlDbType = SqlDbType.Int, Value = null},
                new SqlParameter { ParameterName = "@UnitValue", SqlDbType = SqlDbType.Decimal, Value = null},
                new SqlParameter { ParameterName = "@Id_Quantity", SqlDbType = SqlDbType.BigInt, Value = 0}
            };


            DataSet ds = await _salesContext.Fill("db_thirdparties.sp_Quantities", parameters);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                QuantityResponseModel clientResponse = new QuantityResponseModel()
                {
                    ProductId = long.Parse(dr["Id_Product"].ToString()),
                    ProductName = dr["Product_Name"].ToString(),
                    ProducDescription = dr["Product_Description"].ToString(),
                    CategoryProduct = dr["Categoria"].ToString(),
                    TradeMark = dr["Marca"].ToString(),
                    Active = bool.Parse(dr["Active"].ToString()),
                    UnitValue = decimal.Parse(dr["UnitValue"].ToString()),
                    Quantity = int.Parse(dr["Quantity"].ToString())
                };

                quantityResponseCollection.Add(clientResponse);
            }

            return quantityResponseCollection;
        }
    }
}
