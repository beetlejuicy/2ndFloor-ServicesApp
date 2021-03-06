﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SecondFloor.DataContracts.DTO
{
    [DataContract(Name = "AnuncioDTO", Namespace = "dto.secondfloor.com")]
    public class AnuncioDto
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Titulo { get; set; }
        [DataMember]
        public int DiaInicio { get; set; }
        [DataMember]
        public int MesInicio { get; set; }
        [DataMember]
        public int AnoInicio { get; set; }
        [DataMember]
        public int DiaFim { get; set; }
        [DataMember]
        public int MesFim { get; set; }
        [DataMember]
        public int AnoFim { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string Logradouro { get; set; }
        [DataMember]
        public string Numero { get; set; }
        [DataMember]
        public string Complemento { get; set; }
        [DataMember]
        public string Bairro { get; set; }
        [DataMember]
        public string Cidade { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public string Cep { get; set; }

        [DataMember]
        public EnderecoDto Endereco { get; set; }

        [DataMember]
        public IList<OfertaDto> Ofertas { get; set; }

        [DataMember]
        public string AnuncianteId { get; set; }
    }
}