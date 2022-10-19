using SalesCome.API.Models.Client;
using SalesCome.Application.Services.Clients.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalesCome.API.Models.Mapper
{
    public class ClientMapperAPI
    {
        public RequestClientModel MapReq(RequestClientModelAPI model)
        {
            return new RequestClientModel()
            {
                BirthDate = model.BirthDate,
                ClientId = model.ClientId,
                DocumentNumber = model.DocumentNumber,
                FirsSurName = model.FirsSurName,
                FirstName = model.FirstName,
                SecondName = model.SecondName,
                SecondSurName = model.SecondSurName,
                TypeDocumentId = model.TypeDocumentId,
                UrlImg = model.UrlImg,
                UserCreate = model.UserCreate
            };
        }

        public List<ResponseClientModelAPI> MapListResp(List<ResponseClientModel> model)
        {
            return model.Select(s => new ResponseClientModelAPI
            {
                BirthDate = s.BirthDate,
                ClientId = s.ClientId,
                ContactInfoCollection = MapListRespContactInfo(s.ContactInfoCollection),
                DocumentName = s.DocumentName,
                DocumentNumber = s.DocumentNumber,
                FirstName = s.FirstName,
                FirsSurName = s.FirsSurName,
                SecondName = s.SecondName,
                SecondSurName = s.SecondSurName,
                ShortDocumentName = s.ShortDocumentName,
                TypeDocumentId = s.TypeDocumentId,
                UrlImg = s.UrlImg
            }).ToList();
        }

        public List<ResponseContactInfoModelAPI> MapListRespContactInfo(List<ResponseContactInfoModel> model)
        {
            return model.Select(s => new ResponseContactInfoModelAPI
            {
                Active = s.Active,
                ClientId = s.ClientId,
                ContactId = s.ContactId,
                ContactType = s.ContactType,
                ContactTypeId = s.ContactTypeId,
                Informaction = s.Informaction
            }).ToList();
        }

        public RequestContactInfoModel MapContactInfoReq(RequestContactInfoModelAPI model)
        {
            return new RequestContactInfoModel()
            {
                UserCreate = model.UserCreate,
                ContactTypeId = model.ContactTypeId,
                ClientId = model.ClientId,
                Active = model.Active,
                ContactInfoId = model.ContactInfoId,
                Information = model.Information
            };
        }
    }
}
