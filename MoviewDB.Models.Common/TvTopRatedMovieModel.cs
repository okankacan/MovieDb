using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MoviewDB.Models.Common
{
    [DataContract]
    public class TvTopRatedMovieModel
    {
        [DataMember]
        public int page { get; set; }

        [DataMember]
        public int total_results { get; set; }

        [DataMember]
        public int total_pages { get; set; }

        [DataMember]
        public List<tvResults> results { get; set; }
    }

    [DataContract]
    public class tvResults
    {
        [DataMember]
        public string original_name { get; set; }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public double popularity { get; set; }
        [DataMember]
        public int vote_count { get; set; }

        [DataMember]
        public double vote_average { get; set; }
        [DataMember]
        public DateTime? first_air_date { get; set; }
        [DataMember]
        public string poster_path { get; set; }
        [DataMember]
        public int[] genre_ids { get; set; }
        [DataMember]
        public string original_language { get; set; }

        [DataMember]
        public string backdrop_path { get; set; }
        [DataMember]
        public string overview { get; set; }
        [DataMember]
        public string[] origin_country { get; set; }


    }
}