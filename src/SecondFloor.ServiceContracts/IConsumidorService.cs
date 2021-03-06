﻿using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using SecondFloor.DataContracts.DTO;
using SecondFloor.DataContracts.Messages.Anuncio;
using SecondFloor.DataContracts.Messages.Consumidor;
using SecondFloor.DataContracts.Messages.ConsumidorOfertas;

namespace SecondFloor.ServiceContracts
{
    [ServiceContract(Namespace = "services.secondfloor.com",Name = "ConsumidorService")] //compatibilidade de nome de interface no Java
    public interface IConsumidorService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        EncontrarOfertaResponse EncontrarOfertaPor(EncontrarOfertaRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        AtribuirRatingOfertaResponse AtribuirRatingPara(AtribuirRatingOfertaRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        CadastrarConsumidorResponse CadastrarConsumidor(CadastrarConsumidorRequest request);

        //[OperationContract]
        //[WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //EfetuarPublicacaoResponse PublicarAnuncio(EfetuarPublicacaoRequest request);
    }
}