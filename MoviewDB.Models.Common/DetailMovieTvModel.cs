
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MoviewDB.Models.Common
{
    [DataContract]
    public class DetailMovieTvModel
    {
        [DataMember]
        public string backdrop_path { get; set; }
        [DataMember]

        public string poster_path { get; set; }
        [DataMember]

        public string original_title { get; set; }
        [DataMember]

        public string[] created_by { get; set; }
        [DataMember]
        public int[] episode_run_time { get; set; }
        [DataMember]
        public DateTime? first_air_date { get; set; }
        [DataMember]
        public List<Genres> genre { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]

        public string overview { get; set; }
        [DataMember]
        public string homepage { get; set; }
        [DataMember]
        public int id { get; set; }
        [DataMember]

        public bool in_production { get; set; }
        [DataMember]
        public string[] languages { get; set; }
        [DataMember]
        public DateTime last_air_date { get; set; }
        [DataMember]
        public Last_episode_to_air last_episode_to_air { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string next_episode_to_air { get; set; }
        [DataMember]
        public List<Networks> networks { get; set; }
        [DataMember]
        public int number_of_episodes { get; set; }
        [DataMember]
        public int number_of_seasons { get; set; }
        [DataMember]
        public string[] origin_country { get; set; }
        [DataMember]
        public string original_language { get; set; }
        [DataMember]
        public string original_name { get; set; }
   
       

        [DataMember]
        public double popularity { get; set; }


    }
    [DataContract]
    public class Genres
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
    }
    [DataContract]
    public class Last_episode_to_air
    {
        [DataMember]
        public DateTime air_date { get; set; }
        [DataMember]
        public int episode_number { get; set; }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string overview { get; set; }
        [DataMember]
        public string production_code { get; set; }
        [DataMember]
        public int season_number { get; set; }
        [DataMember]
        public int show_id { get; set; }
        [DataMember]
        public string still_path { get; set; }
        [DataMember]
        public double vote_average { get; set; }
        [DataMember]

        public int vote_count { get; set; }
    }
    [DataContract]
    public class Networks
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string logo_path { get; set; }
        [DataMember]

        public string origin_country { get; set; }
    }
}