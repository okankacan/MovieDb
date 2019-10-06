using System.Runtime.Serialization;

namespace MoviewDB.Models.Common
{
    [DataContract]
    public class RatingTopMovieModel
    {

        [DataMember]
        public TopRatedMovieModel topRatedMovie{ get; set; }

        [DataMember]
        public NowPlayingMovieModel nowPlayingMovie { get; set; }

        [DataMember]

        public PopularMovieModel popularMovie { get; set; }
    }
}