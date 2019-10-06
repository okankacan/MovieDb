using MoviewDB.Helper.Common.httpClient;
using MoviewDB.Models.Common;
using MoviewDB.Models.Common.ResponseModels;
using Newtonsoft.Json;
using System.Configuration;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MoviewDB.WebSite.Controllers
{
    public class HomeController : Controller
    {
        private string apiUrl = ConfigurationManager.AppSettings["apiUrl"].ToString();

 
        [Route("Film")]
        public async Task<ActionResult> Movies()
        {
            var requestMovives = await HttpRequestFactory.Get(apiUrl + "api/MovieApi/MovieGet");
            var MoviveContent = await requestMovives.Content.ReadAsStringAsync();
            var movieResult = JsonConvert.DeserializeObject<BaseResponseModel>(MoviveContent);
            if (movieResult.HttpStatusCode == HttpStatusCode.OK)
            {
                var movieList = JsonConvert.DeserializeObject<RatingTopMovieModel>(JsonConvert.SerializeObject(movieResult.Data));
                return View(movieList);
            }
            return View(new RatingTopMovieModel());
        }
        [Route("Tv")]
        public async Task<ActionResult> Tv()
        {

            var requestTv = await HttpRequestFactory.Get(apiUrl + "api/MovieApi/TvGet");
            var tvContent = await requestTv.Content.ReadAsStringAsync();
            var tvResult = JsonConvert.DeserializeObject<BaseResponseModel>(tvContent);
            if (tvResult.HttpStatusCode == HttpStatusCode.OK)
            {
                var movies = JsonConvert.DeserializeObject<RatingTopTvModel>(JsonConvert.SerializeObject(tvResult.Data));
                return View(movies);
            }
            return View(new RatingTopTvModel());
        }
        [Route("Home/Detail/{type}/{id}")]

        public async Task<ActionResult> Detail(detailModel model)
        {

            var requestDetail = await HttpRequestFactory.Post(apiUrl + "api/MovieApi/GetDetail", model);
        
            var detailContent = await requestDetail.Content.ReadAsStringAsync();
            var detailResult = JsonConvert.DeserializeObject<BaseResponseModel>(detailContent);
            if (detailResult.HttpStatusCode == HttpStatusCode.OK)
            {
                var moviedetail = JsonConvert.DeserializeObject<DetailTvsMovieModel>(JsonConvert.SerializeObject(detailResult.Data));
                return View(moviedetail);
            }
            return View(new DetailTvsMovieModel());
     
        }
    }
}