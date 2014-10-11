﻿using System.ServiceModel;

namespace SecondFloor.DataContracts.Messages.Anuncio
{
    [MessageContract(WrapperNamespace = "messages.am.fiap.com.br")]
    public class PublicarAnuncioRequest
    {
        [MessageBodyMember]
        public string Id { get; set; }
    }
}