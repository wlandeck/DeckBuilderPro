﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckBuilderPro.Infrastructure
{
    public static class Guard
    {
        private static readonly string noParameterNameSpecified = "(no parameter name)";
        public static void ArgumentNotNull(object parameterValue, string parameterName)
        {
            if (parameterValue == null)
            {
                throw new ArgumentNullException(string.IsNullOrEmpty(parameterName) ? Guard.noParameterNameSpecified : parameterName);
            }
        }
    }
}
