using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MoviewDB.Models.Common
{
    [DataContract]
    public class NowPlayingMovieModel
    {
        [DataMember]
        public List<results> results { get; set; }

    }
}