using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MoviewDB.Models.Common
{
    [DataContract]
    public class TopRatedMovieModel
    {

        [DataMember]
        public int page { get; set; }

        [DataMember]
        public int total_results { get; set; }

        [DataMember]
        public int total_pages { get; set; }

        [DataMember]
        public List<results> results { get; set; }
    }

    [DataContract]
    public class results
    {

        [DataMember]
        public double popularity { get; set; }

        [DataMember]
        public int vote_count { get; set; }

        [DataMember]
        public bool video { get; set; }

        [DataMember]
        public string poster_path { get; set; }

        [DataMember]
        public int id { get; set; }

        [DataMember]
        public bool adult { get; set; }

        [DataMember]
        public string backdrop_path { get; set; }

        [DataMember]
        public string original_language { get; set; }

        [DataMember]
        public string original_title { get; set; }

        [DataMember]
        public int[] genre_ids { get; set; }

        [DataMember]
        public string title { get; set; }

        [DataMember]
        public double vote_average { get; set; }

        [DataMember]
        public string overview { get; set; }

        [DataMember]
        public DateTime release_date { get; set; }
    }
}