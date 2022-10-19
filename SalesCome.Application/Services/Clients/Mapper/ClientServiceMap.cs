using SalesCome.Application.Services.Clients.Model;
using SalesCome.Infrastructure.Services.Clients.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesCome.Application.Services.Clients.Mapper
{
    public class ClientServiceMap
    {
        public ClientRequestModel MapReq(RequestClientModel model)
        {
            return new ClientRequestModel()
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

        public List<ResponseClientModel> MapListResp(List<ClientResponseModel> model)
        {
            return model.Select(s => new ResponseClientModel
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

        public List<ResponseContactInfoModel> MapListRespContactInfo(List<ContactInfoResponseModel> model)
        {
            return model.Select(s => new ResponseContactInfoModel
            {
                Active = s.Active,
                ClientId = s.ClientId,
                ContactId = s.ContactId,
                ContactType = s.ContactType,
                ContactTypeId = s.ContactTypeId,
                Informaction = s.Informaction
            }).ToList();
        }

        public ContactInfoRequestModel MapContactInfoReq(RequestContactInfoModel model)
        {
            return new ContactInfoRequestModel()
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
