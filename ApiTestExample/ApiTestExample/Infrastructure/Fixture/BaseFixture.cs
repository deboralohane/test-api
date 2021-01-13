using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTestExample.Infrastructure.Fixture
{
    public class BaseFixture
    {
        public readonly string urlBase = "https://api.themoviedb.org/3";


        public string ObterToken()
        {
            var token = "SEU TOKEN AQUI";

            return token;
        }

    }
}
