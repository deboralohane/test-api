using ApiTestExample.Infrastructure.Services.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestExample.Infrastructure.Services
{
    public interface IGetMovieDetailsService
    {
        [Get("/movie/{movieId}")]
        [Headers("Authorization: Bearer")]
        Task<ApiResponse<GetMovieDetailsResponse>> GetBuscarFilmePorIdAsync(int movieId);

    }
}
