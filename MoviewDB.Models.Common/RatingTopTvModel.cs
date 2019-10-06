using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MoviewDB.Models.Common
{
    [DataContract]
    public class RatingTopTvModel
    {
        [DataMember]
        public PopularTvModel tvPopularMovie { get; set; }
        [DataMember]
        public TvTopRatedMovieModel tvTopRatedMovie { get; set; }
    }
}