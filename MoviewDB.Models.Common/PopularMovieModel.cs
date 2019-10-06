using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MoviewDB.Models.Common
{
     [DataContract]
    public class PopularMovieModel
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

   
}