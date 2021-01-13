using ApiTestExample.Infrastructure.Fixture.Filmes;
using ApiTestExample.Infrastructure.Services;
using FluentAssertions;
using Refit;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace ApiTestExample
{
    public class GetMovieDetailsTest : IClassFixture<GetMovieDetailsFixture>
    {
        GetMovieDetailsFixture fixture;
        public GetMovieDetailsTest(GetMovieDetailsFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public async Task BuscarFilmePorId()
        {
            var token = fixture.ObterToken();

            var filmeService = RestService.For<IGetMovieDetailsService>(fixture.urlBase, new RefitSettings
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(token)

            });

            var resultFilme = await filmeService.GetBuscarFilmePorIdAsync(337401);
 
            resultFilme.Error?.Content.Should().BeNull();
            resultFilme.StatusCode.Should().Be(HttpStatusCode.OK);
            resultFilme.Content.Titulo.Should().Be("Mulan");
        }
    }
}
