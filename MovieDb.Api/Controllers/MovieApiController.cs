using MovieDb.Api.ApiServiceHelper;
using MoviewDB.Models.Common;
using MoviewDB.Models.Common.ResponseModels;
using System;
using System.Configuration;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;
using System.Web.Http;

namespace MovieDb.Api.Controllers
{
    public class MovieApiController : ApiController
    {
        private string apiUrl = ConfigurationManager.AppSettings["movieDbApiUrl"].ToString();
        private string apiKey = ConfigurationManager.AppSettings["movieDbApiKey"].ToString();
        private double cacheTime = double.Parse(ConfigurationManager.AppSettings["cacheTime"].ToString());

        [HttpGet]
        [Route("api/MovieApi/MovieGet")]
        public async Task<IHttpActionResult> MovieGet()
        {
            try
            {
                if (HttpRuntime.Cache["MovieCache"] != null)
                {
                    var ratingTopCache = HttpRuntime.Cache["MovieCache"] as RatingTopMovieModel;
                    return Ok(new BaseResponseModel
                    {
                        HttpStatusCode = HttpStatusCode.OK,
                        Data = ratingTopCache
                    });
                }

                var _topRatedMovie = await ApiService.TopRatingMovie(apiUrl, apiKey);
                var _nowPlayingMovie = await ApiService.NowPlayingMovie(apiUrl, apiKey);
                var _popularMovie = await ApiService.PopularMovie(apiUrl, apiKey);

                var ratingTopMovie = new RatingTopMovieModel
                {
                    nowPlayingMovie = _nowPlayingMovie,
                    topRatedMovie = _topRatedMovie,
                    popularMovie = _popularMovie

                };
                HttpRuntime.Cache.Insert("MovieCache", ratingTopMovie, null, DateTime.Now.AddMinutes(cacheTime), System.Web.Caching.Cache.NoSlidingExpiration);

                return Ok(new BaseResponseModel
                {
                    HttpStatusCode = HttpStatusCode.OK,
                    Data = ratingTopMovie
                });
            }
            catch (Exception ex)
            {
                return Ok(new BaseResponseModel
                {
                    HttpStatusCode = HttpStatusCode.BadRequest,
                    Data = null,
                    ExeptionMessage = ex.Message
                });
            }
        }


        [HttpGet]
        [Route("api/MovieApi/TvGet")]
        public async Task<IHttpActionResult> TvGet()
        {
            try
            {
                if (HttpRuntime.Cache["TvCache"] != null)
                {
                    var ratingTopCache = HttpRuntime.Cache["TvCache"] as RatingTopTvModel;
                    return Ok(new BaseResponseModel
                    {
                        HttpStatusCode = HttpStatusCode.OK,
                        Data = ratingTopCache
                    });
                }

                var _tvTopRatings = await ApiService.TvTopRatingMovie(apiUrl, apiKey);
                var _tvPopular = await ApiService.TvPopularMovie(apiUrl, apiKey);

                var ratingTopTv = new RatingTopTvModel
                {
                    tvPopularMovie = _tvPopular,
                    tvTopRatedMovie = _tvTopRatings

                };
                HttpRuntime.Cache.Insert("TvCache", ratingTopTv, null, DateTime.Now.AddMinutes(cacheTime), System.Web.Caching.Cache.NoSlidingExpiration);

                return Ok(new BaseResponseModel
                {
                    HttpStatusCode = HttpStatusCode.OK,
                    Data = ratingTopTv
                });
            }
            catch (Exception ex)
            {
                return Ok(new BaseResponseModel
                {
                    HttpStatusCode = HttpStatusCode.BadRequest,
                    Data = null,
                    ExeptionMessage = ex.Message
                });
            }
        }

        [HttpPost]
        [Route("api/MovieApi/GetDetail")]
        public async Task<IHttpActionResult> GetDetail(detailModel model)
        {
            try
            {
                string cacheName ="Detail" + model.type + model.id;

                if (HttpRuntime.Cache[cacheName] != null)
                {
                    var ratingTopCache = HttpRuntime.Cache[cacheName] as RatingTopTvModel;
                    return Ok(new BaseResponseModel
                    {
                        HttpStatusCode = HttpStatusCode.OK,
                        Data = ratingTopCache
                    });
                }

                if (model.type.ToLower()=="tv" || model.type.ToLower() == "movie")
                {
                    var _detail = await ApiService.Detail(apiUrl, apiKey, model);
                    var _detailCredits = await ApiService.DetailCredits(apiUrl, apiKey, model);

                    var detailTvModel = new DetailTvsMovieModel
                    {
                        detailMovieTvCreditModel = _detailCredits,
                        detailMovieTvModel = _detail
                    };

                    HttpRuntime.Cache.Insert(cacheName, detailTvModel, null, DateTime.Now.AddMinutes(cacheTime), System.Web.Caching.Cache.NoSlidingExpiration);

                    return Ok(new BaseResponseModel
                    {
                        HttpStatusCode = HttpStatusCode.OK,
                        Data = detailTvModel
                    });

                }

                return Ok(new BaseResponseModel
                {
                    HttpStatusCode = HttpStatusCode.BadRequest,
                    Data = null,
                    ExeptionMessage = "error"
                });
            }
            catch (Exception ex)
            {
                return Ok(new BaseResponseModel
                {
                    HttpStatusCode = HttpStatusCode.BadRequest,
                    Data = null,
                    ExeptionMessage = ex.Message
                });
            }
        }
    }
}
