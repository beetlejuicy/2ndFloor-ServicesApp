using System;
using System.Collections.Generic;

namespace SecondFloor.Model.Specifications
{
    public static class ComentarioSpecification
    {
        public static IDictionary<string,string> GetBrokenBusinessRules(this Comentario comentario)
        {
            //Consumidor 
            if (comentario.Consumidor == null)
            {
                comentario.AddBrokenRule("Cosumidor", "O consumidor n�o foi especificado.");
            }
            else if (comentario.Consumidor != null)
            {
                comentario.AddRangeBrokenRules(comentario.Consumidor.GetBrokenBusinessRules());
            }

            //Anunciante
            if (comentario.Para == null)
            {
                comentario.AddBrokenRule("Para", "O anunciante n�o foi especificado.");
            }
            else if (comentario.Para != null)
            {
                comentario.AddRangeBrokenRules(comentario.Para.GetBrokenBusinessRules());
            }

            //Descricao 
            if (comentario.Descricao.Length < 3)
            {
                comentario.AddBrokenRule("Descricao", "A descri��o deve possuir no m�nimo (3) caracteres.");
            }
            else if (comentario.Descricao.Length > 1000) // Tomei como base o Mercado Livre
            {
                comentario.AddBrokenRule("Descricao", "A descri��o deve conter no m�ximo (1000) caracteres.");
            }

            //Data
            if (comentario.Data.Date != DateTime.Now.Date)
            {
                comentario.AddBrokenRule("Data", "A data esta diferente do dia atual.");
            }

            //Ponto
            if (comentario.Ponto <= 0)
            {
                comentario.AddBrokenRule("Ponto", "Pontua��o deve ser no m�nimo 1.");
            }
            else if (comentario.Ponto > 5)
            {
                comentario.AddBrokenRule("Ponto", "Pontua��o deve ser m�ximo 5.");
            }
            return comentario.BrokenRules;
        }
    }
}