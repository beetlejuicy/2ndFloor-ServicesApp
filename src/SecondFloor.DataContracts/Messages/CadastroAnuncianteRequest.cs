﻿using System.ServiceModel;
using SecondFloor.DataContracts.DTO;

namespace SecondFloor.DataContracts.Messages
{
    [MessageContract(WrapperNamespace = "messages.am.fiap.com.br")]
    public class CadastroAnuncianteRequest
    {
        [MessageBodyMember]
        public AnuncianteDto Anunciante;

        //TODO: talvez criar um constructor para iniciar um AnuncioDTO vazio
    }
}