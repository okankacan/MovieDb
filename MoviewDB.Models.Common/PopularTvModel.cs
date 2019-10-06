using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MoviewDB.Models.Common
{
    [DataContract]
    public class PopularTvModel
    {

        [DataMember]
        public int page { get; set; }

        [DataMember]
        public int total_results { get; set; }

        [DataMember]
        public int total_pages { get; set; }
        [DataMember]
        public List<tvResults> results
        {
            get; set;
        }
    }
}