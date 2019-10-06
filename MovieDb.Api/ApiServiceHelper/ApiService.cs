using MoviewDB.Helper.Common.httpClient;
using MoviewDB.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MovieDb.Api.ApiServiceHelper
{
    public static class ApiService
    {

        public static async Task<TopRatedMovieModel> TopRatingMovie(string apiUrl, string apiKey)
        {
            try
            {
                var moviedbUrl = apiUrl + $"3/movie/top_rated?api_key={apiKey}&language=en-US&page=1";
                var requestMovives = await HttpRequestFactory.Get(moviedbUrl);
                var MoviveContent = await requestMovives.Content.ReadAsStringAsync();
                var movies = JsonConvert.DeserializeObject<TopRatedMovieModel>(MoviveContent);

                return movies;
            }
            catch (Exception ex)
            {
                return new TopRatedMovieModel();
              
            }
 
        }

        public static async Task<NowPlayingMovieModel> NowPlayingMovie(string apiUrl, string apiKey)
        {
            try
            {
         
                var moviedbUrl = apiUrl + $"3/movie/now_playing?api_key={apiKey}&language=en-US&page=1";
                var requestMovives = await HttpRequestFactory.Get(moviedbUrl);
                var MoviveContent = await requestMovives.Content.ReadAsStringAsync();
                var nowPlayings = JsonConvert.DeserializeObject<NowPlayingMovieModel>(MoviveContent);

                return nowPlayings;
            }
            catch (Exception ex)
            {
                return new NowPlayingMovieModel();

            }

        }

        public static async Task<PopularMovieModel> PopularMovie(string apiUrl, string apiKey)
        {
            try
            {

                var moviedbUrl = apiUrl + $"3/movie/popular?api_key={apiKey}&language=en-US&page=1";
                var requestMovives = await HttpRequestFactory.Get(moviedbUrl);
                var MoviveContent = await requestMovives.Content.ReadAsStringAsync();
                var populars = JsonConvert.DeserializeObject<PopularMovieModel>(MoviveContent);

                return populars;
            }
            catch (Exception ex)
            {
                return new PopularMovieModel();

            }

        }

        public static async Task<TvTopRatedMovieModel> TvTopRatingMovie(string apiUrl, string apiKey)
        {
            try
            {

                var moviedbUrl = apiUrl + $"3/tv/top_rated?api_key={apiKey}&language=en-US&page=1";
                var requestMovives = await HttpRequestFactory.Get(moviedbUrl);
                var MoviveContent = await requestMovives.Content.ReadAsStringAsync();
                var tvTopRates = JsonConvert.DeserializeObject<TvTopRatedMovieModel>(MoviveContent);

                return tvTopRates;
            }
            catch (Exception ex)
            {
                return new TvTopRatedMovieModel();

            }
        }

        public static async Task<PopularTvModel> TvPopularMovie(string apiUrl, string apiKey)
        {
            try
            {

                var moviedbUrl = apiUrl + $"3/tv/popular?api_key={apiKey}&language=en-US&page=1";
                var requestMovives = await HttpRequestFactory.Get(moviedbUrl);
                var MoviveContent = await requestMovives.Content.ReadAsStringAsync();
                var tvTopRates = JsonConvert.DeserializeObject<PopularTvModel>(MoviveContent);

                return tvTopRates;
            }
            catch (Exception ex)
            {
                return new PopularTvModel();

            }
        }

        public static async Task<DetailMovieTvModel> Detail(string apiUrl, string apiKey, detailModel model)
        {
            try
            {
        

                var moviedbUrl = apiUrl + $"3/{model.type.ToLower().ToString()}/{model.id}?api_key={apiKey}&language=en-US&page=1";
                var requestMovives = await HttpRequestFactory.Get(moviedbUrl);
                var MoviveContent = await requestMovives.Content.ReadAsStringAsync();
                var tvTopRates = JsonConvert.DeserializeObject<DetailMovieTvModel>(MoviveContent);

                return tvTopRates;
            }
            catch (Exception ex)
            {
                return new DetailMovieTvModel();

            }
        }

        public static async Task<DetailMovieTvCreditModel> DetailCredits(string apiUrl, string apiKey, detailModel model)
        {
            try
            {
                 

                var moviedbUrl = apiUrl + $"3/{model.type.ToLower().ToString()}/{model.id}/credits?api_key={apiKey}&language=en-US&page=1";
                var requestMovives = await HttpRequestFactory.Get(moviedbUrl);
                var MoviveContent = await requestMovives.Content.ReadAsStringAsync();
                var tvTopRates = JsonConvert.DeserializeObject<DetailMovieTvCreditModel>(MoviveContent);

                return tvTopRates;
            }
            catch (Exception ex)
            {
                return new DetailMovieTvCreditModel();

            }
        }

     
    }
}