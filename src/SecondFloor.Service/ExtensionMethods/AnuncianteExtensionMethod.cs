﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.ObjectBuilder2;
using SecondFloor.DataContracts.DTO;
using SecondFloor.Model;

namespace SecondFloor.Service.ExtensionMethods
{
    public static class AnuncianteExtensionMethod
    {
        public static Anunciante ConvertToAnunciante( this AnuncianteDto anuncianteDto )
        {
            var anunciante = new Anunciante();

            //if (string.IsNullOrEmpty(anuncianteDto.Id) || anuncianteDto.Id == "00000000-0000-0000-0000-000000000000")
            if (string.IsNullOrEmpty(anuncianteDto.Id) || anuncianteDto.Id == default(Guid).ToString())
            {
                anunciante.Id = Guid.NewGuid();
            }
            else
            {
                anunciante.Id = new Guid(anuncianteDto.Id);
            }

            anunciante.Responsavel = anuncianteDto.Responsavel;
            anunciante.RazaoSocial = anuncianteDto.RazaoSocial;
            anunciante.Email = anuncianteDto.Email;
            anunciante.Cnpj = anuncianteDto.Cnpj;
            //anunciante.Token = anuncianteDto.Token;
            //anunciante.Anuncios = anuncianteDto.Anuncios.ConvertToListaAnuncio(); //not used from JAVA app to 

            return anunciante;
        }

        public static AnuncianteDto ConvertToAnuncianteDto(this Anunciante anunciante)
        {
            var anuncianteDto = new AnuncianteDto();

            anuncianteDto.Id = anunciante.Id.ToString();
            anuncianteDto.Responsavel = anunciante.Responsavel;
            anuncianteDto.RazaoSocial = anunciante.RazaoSocial;
            anuncianteDto.Email = anunciante.Email;
            anuncianteDto.Cnpj = anunciante.Cnpj;
            //anuncianteDto.Token = anunciante.Token;
            anuncianteDto.Anuncios = anunciante.Anuncios.ConvertToListaAnunciosDtos();
            anuncianteDto.Enderecos = anunciante.Enderecos.ConvertToListaEnderecosDto();

            return anuncianteDto;
        }

        public static IList<AnuncianteDto> ConvertToListaAnunciantesDto(this IList<Anunciante> anunciantes)
        {
            var anunciantesDto = anunciantes.Select(anunciante => anunciante.ConvertToAnuncianteDto()).ToList();

            return anunciantesDto;
        }
    }
}