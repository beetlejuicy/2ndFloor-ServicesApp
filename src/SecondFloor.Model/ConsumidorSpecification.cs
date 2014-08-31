﻿using System.Collections.Generic;
using SecondFloor.Infrastructure.Model;

namespace SecondFloor.Model
{
    public static class ConsumidorSpecification
    {
        public static IList<BusinessRule> GetBrokenBusinessRules(this Consumidor anunciante)
        {

            return anunciante.BrokenRules;
        }
    }
}