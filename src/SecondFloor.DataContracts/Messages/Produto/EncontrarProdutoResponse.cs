﻿using System.ServiceModel;
using SecondFloor.DataContracts.DTO;

namespace SecondFloor.DataContracts.Messages.Produto
{
    [MessageContract(WrapperNamespace = "messages.am.fiap.com.br")]
    public class EncontrarProdutoResponse : ResponseBase
    {
        [MessageBodyMember]
        public ProdutoDto Produto { get; set; }
    }
}