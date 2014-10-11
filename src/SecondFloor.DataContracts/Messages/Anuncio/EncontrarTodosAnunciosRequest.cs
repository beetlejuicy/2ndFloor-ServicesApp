﻿using System.ServiceModel;

namespace SecondFloor.DataContracts.Messages.Anuncio
{
    [MessageContract(WrapperNamespace = "messages.am.fiap.com.br")]
    public class EncontrarTodosAnunciosRequest
    {
        [MessageBodyMember]
        public string AnuncianteId { get; set; }
    }
}