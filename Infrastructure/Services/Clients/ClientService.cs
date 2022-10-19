using SalesCome.DAC.DBContext;
using SalesCome.Infrastructure.Services.Clients.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SalesCome.Infrastructure.Services.Clients
{
    public class ClientService : IClientService
    {
        private readonly ISalesContext _salesContext;

        public ClientService(ISalesContext salesContext)
        {
            _salesContext = salesContext;
        }

        public async Task<bool> SaveClientAsync(ClientRequestModel client)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 0},
                new SqlParameter { ParameterName = "@FirstName", SqlDbType = SqlDbType.NVarChar, Value = client.FirstName},
                new SqlParameter { ParameterName = "@SecondName", SqlDbType = SqlDbType.NVarChar, Value = client.SecondName},
                new SqlParameter { ParameterName = "@FirstLastName", SqlDbType = SqlDbType.NVarChar, Value = client.FirsSurName},
                new SqlParameter { ParameterName = "@SecondLastName", SqlDbType = SqlDbType.NVarChar, Value = client.SecondSurName},
                new SqlParameter { ParameterName = "@Id_DocumentType", SqlDbType = SqlDbType.Int, Value = client.TypeDocumentId},
                new SqlParameter { ParameterName = "@DocumentNumber", SqlDbType = SqlDbType.NVarChar, Value = client.DocumentNumber},
                new SqlParameter { ParameterName = "@BirthDate", SqlDbType = SqlDbType.DateTime, Value = client.BirthDate},
                new SqlParameter { ParameterName = "@Img_Url", SqlDbType = SqlDbType.NVarChar, Value = client.UrlImg},
                new SqlParameter { ParameterName = "@CreateAccess", SqlDbType = SqlDbType.Int, Value = client.UserCreate},
                new SqlParameter { ParameterName = "@Id_ThirdParty", SqlDbType = SqlDbType.BigInt, Value = client.ClientId}
            };

            int result = await _salesContext.ExecuteNonQueryAsync("db_thirdparties.sp_CRUDClients", parameters);

            if (result > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> UpdateClientAsync(ClientRequestModel client)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 1},
                new SqlParameter { ParameterName = "@FirstName", SqlDbType = SqlDbType.NVarChar, Value = client.FirstName},
                new SqlParameter { ParameterName = "@SecondName", SqlDbType = SqlDbType.NVarChar, Value = client.SecondName},
                new SqlParameter { ParameterName = "@FirstLastName", SqlDbType = SqlDbType.NVarChar, Value = client.FirsSurName},
                new SqlParameter { ParameterName = "@SecondLastName", SqlDbType = SqlDbType.NVarChar, Value = client.SecondSurName},
                new SqlParameter { ParameterName = "@Id_DocumentType", SqlDbType = SqlDbType.Int, Value = client.TypeDocumentId},
                new SqlParameter { ParameterName = "@DocumentNumber", SqlDbType = SqlDbType.NVarChar, Value = client.DocumentNumber},
                new SqlParameter { ParameterName = "@BirthDate", SqlDbType = SqlDbType.DateTime, Value = client.BirthDate},
                new SqlParameter { ParameterName = "@Img_Url", SqlDbType = SqlDbType.NVarChar, Value = client.UrlImg},
                new SqlParameter { ParameterName = "@CreateAccess", SqlDbType = SqlDbType.Int, Value = client.UserCreate},
                new SqlParameter { ParameterName = "@Id_ThirdParty", SqlDbType = SqlDbType.BigInt, Value = client.ClientId}
            };

            int result = await _salesContext.ExecuteNonQueryAsync("db_thirdparties.sp_CRUDClients", parameters);

            if (result > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> DeleteClientAsync(ClientRequestModel client)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 2},
                new SqlParameter { ParameterName = "@FirstName", SqlDbType = SqlDbType.NVarChar, Value = client.FirstName},
                new SqlParameter { ParameterName = "@SecondName", SqlDbType = SqlDbType.NVarChar, Value = client.SecondName},
                new SqlParameter { ParameterName = "@FirstLastName", SqlDbType = SqlDbType.NVarChar, Value = client.FirsSurName},
                new SqlParameter { ParameterName = "@SecondLastName", SqlDbType = SqlDbType.NVarChar, Value = client.SecondSurName},
                new SqlParameter { ParameterName = "@Id_DocumentType", SqlDbType = SqlDbType.Int, Value = client.TypeDocumentId},
                new SqlParameter { ParameterName = "@DocumentNumber", SqlDbType = SqlDbType.NVarChar, Value = client.DocumentNumber},
                new SqlParameter { ParameterName = "@BirthDate", SqlDbType = SqlDbType.DateTime, Value = client.BirthDate},
                new SqlParameter { ParameterName = "@Img_Url", SqlDbType = SqlDbType.NVarChar, Value = client.UrlImg},
                new SqlParameter { ParameterName = "@CreateAccess", SqlDbType = SqlDbType.Int, Value = client.UserCreate},
                new SqlParameter { ParameterName = "@Id_ThirdParty", SqlDbType = SqlDbType.BigInt, Value = client.ClientId}
            };

            int result = await _salesContext.ExecuteNonQueryAsync("db_thirdparties.sp_CRUDClients", parameters);

            if (result > 0)
                return true;
            else
                return false;
        }

        public async Task<List<ClientResponseModel>> GetClientsAsync()
        {
            List<ClientResponseModel> clientCollection = new List<ClientResponseModel>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 3},
                new SqlParameter { ParameterName = "@FirstName", SqlDbType = SqlDbType.NVarChar, Value = null},
                new SqlParameter { ParameterName = "@SecondName", SqlDbType = SqlDbType.NVarChar, Value = null},
                new SqlParameter { ParameterName = "@FirstLastName", SqlDbType = SqlDbType.NVarChar, Value = null},
                new SqlParameter { ParameterName = "@SecondLastName", SqlDbType = SqlDbType.NVarChar, Value = null},
                new SqlParameter { ParameterName = "@Id_DocumentType", SqlDbType = SqlDbType.Int, Value = null},
                new SqlParameter { ParameterName = "@DocumentNumber", SqlDbType = SqlDbType.NVarChar, Value = null},
                new SqlParameter { ParameterName = "@BirthDate", SqlDbType = SqlDbType.DateTime, Value = null},
                new SqlParameter { ParameterName = "@Img_Url", SqlDbType = SqlDbType.NVarChar, Value = null},
                new SqlParameter { ParameterName = "@CreateAccess", SqlDbType = SqlDbType.Int, Value = 0},
                new SqlParameter { ParameterName = "@Id_ThirdParty", SqlDbType = SqlDbType.BigInt, Value = 0}
            };

            DataSet ds = await _salesContext.Fill("db_thirdparties.sp_CRUDClients", parameters);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ClientResponseModel clientResponse = new ClientResponseModel()
                    {
                        ClientId = long.Parse(dr["Id"].ToString()),
                        FirstName = dr["First_Name"].ToString(),
                        SecondName= dr["Second_Name"].ToString(),
                        FirsSurName = dr["First_Last_Name"].ToString(),
                        SecondSurName = dr["Second_Last_Name"].ToString(),
                        BirthDate = DateTime.Parse(String.IsNullOrEmpty(dr["BirthDate"].ToString()) ? DateTime.Now.ToString() : dr["BirthDate"].ToString()),
                        TypeDocumentId = int.Parse(dr["Id_DocumentType"].ToString()),
                        DocumentName = dr["Document"].ToString(),
                        ShortDocumentName = dr["Short_Description"].ToString(),
                        DocumentNumber = dr["Document_Number"].ToString(),
                        UrlImg = dr["Image_Url"].ToString(),
                        ContactInfoCollection = await ContactInfoCollectionAsync(long.Parse(dr["Id"].ToString()))
                    };

                    clientCollection.Add(clientResponse);
                }
            }

            return clientCollection;
        }

        public async Task<bool> SaveInfoContactAsync(ContactInfoRequestModel contact)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 0},
                new SqlParameter { ParameterName = "@Id_ContactType", SqlDbType = SqlDbType.Int, Value = contact.ContactTypeId},
                new SqlParameter { ParameterName = "@Informamation", SqlDbType = SqlDbType.NVarChar, Value = contact.Information},
                new SqlParameter { ParameterName = "@Active", SqlDbType = SqlDbType.Bit, Value = contact.Active},
                new SqlParameter { ParameterName = "@CreateAccess", SqlDbType = SqlDbType.Int, Value = contact.UserCreate},
                new SqlParameter { ParameterName = "@Id_ThirdParty", SqlDbType = SqlDbType.BigInt, Value = contact.ClientId},
                new SqlParameter { ParameterName = "@Id_InfoContact", SqlDbType = SqlDbType.BigInt, Value = contact.ContactInfoId},
            };


            int result = await _salesContext.ExecuteNonQueryAsync("db_thirdparties.sp_CRUDInfoAdicional", parameters);

            if (result > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> UpdateInfoContactAsync(ContactInfoRequestModel contact)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 1},
                new SqlParameter { ParameterName = "@Id_ContactType", SqlDbType = SqlDbType.Int, Value = contact.ContactTypeId},
                new SqlParameter { ParameterName = "@Informamation", SqlDbType = SqlDbType.NVarChar, Value = contact.Information},
                new SqlParameter { ParameterName = "@Active", SqlDbType = SqlDbType.Bit, Value = contact.Active},
                new SqlParameter { ParameterName = "@CreateAccess", SqlDbType = SqlDbType.Int, Value = contact.UserCreate},
                new SqlParameter { ParameterName = "@Id_ThirdParty", SqlDbType = SqlDbType.BigInt, Value = contact.ClientId},
                new SqlParameter { ParameterName = "@Id_InfoContact", SqlDbType = SqlDbType.BigInt, Value = contact.ContactInfoId},
            };


            int result = await _salesContext.ExecuteNonQueryAsync("db_thirdparties.sp_CRUDInfoAdicional", parameters);

            if (result > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> DeleteInfoContactAsync(ContactInfoRequestModel contact)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 2},
                new SqlParameter { ParameterName = "@Id_ContactType", SqlDbType = SqlDbType.Int, Value = contact.ContactTypeId},
                new SqlParameter { ParameterName = "@Informamation", SqlDbType = SqlDbType.NVarChar, Value = contact.Information},
                new SqlParameter { ParameterName = "@Active", SqlDbType = SqlDbType.Bit, Value = contact.Active},
                new SqlParameter { ParameterName = "@CreateAccess", SqlDbType = SqlDbType.Int, Value = contact.UserCreate},
                new SqlParameter { ParameterName = "@Id_ThirdParty", SqlDbType = SqlDbType.BigInt, Value = contact.ClientId},
                new SqlParameter { ParameterName = "@Id_InfoContact", SqlDbType = SqlDbType.BigInt, Value = contact.ContactInfoId},
            };


            int result = await _salesContext.ExecuteNonQueryAsync("db_thirdparties.sp_CRUDInfoAdicional", parameters);

            if (result > 0)
                return true;
            else
                return false;
        }

        public async Task<List<ContactInfoResponseModel>> ContactInfoCollectionAsync(long ClientId)
        {
            List<ContactInfoResponseModel> contactInfos = new List<ContactInfoResponseModel>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Action", SqlDbType = SqlDbType.Int, Value = 3},
                new SqlParameter { ParameterName = "@Id_ContactType", SqlDbType = SqlDbType.Int, Value = null},
                new SqlParameter { ParameterName = "@Informamation", SqlDbType = SqlDbType.NVarChar, Value = null},
                new SqlParameter { ParameterName = "@Active", SqlDbType = SqlDbType.Bit, Value = null},
                new SqlParameter { ParameterName = "@CreateAccess", SqlDbType = SqlDbType.Int, Value = 0},
                new SqlParameter { ParameterName = "@Id_ThirdParty", SqlDbType = SqlDbType.BigInt, Value = ClientId},
                new SqlParameter { ParameterName = "@Id_InfoContact", SqlDbType = SqlDbType.BigInt, Value = 0},
            };

            DataSet ds = await _salesContext.Fill("db_thirdparties.sp_CRUDInfoAdicional", parameters);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ContactInfoResponseModel clientResponse = new ContactInfoResponseModel()
                {
                    ContactId = long.Parse(dr["Id_InfoContact"].ToString()),
                    Informaction = dr["Information"].ToString(),
                    Active = bool.Parse(dr["Active"].ToString()),
                    ClientId = long.Parse(dr["Id_ThirdParty"].ToString()),
                    ContactType = dr["TipoContacto"].ToString(),
                    ContactTypeId = int.Parse(dr["Id_ContactType"].ToString())
                };

                contactInfos.Add(clientResponse);
            }

            return contactInfos;
        }
    }
}
