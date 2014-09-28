﻿using System.ServiceModel;
using SecondFloor.DataContracts.Messages;

namespace SecondFloor.ServiceContracts
{
    [ServiceContract(Namespace = "services.am.fiap.com.br")]
    public interface IAnuncianteService
    {
        [OperationContract]
        CadastrarAnuncioResponse CadastrarAnuncio( CadastrarAnuncioRequest request );

        [OperationContract]
        CadastroAnuncianteResponse CadastrarAnunciante( CadastroAnuncianteRequest request );
    }
}