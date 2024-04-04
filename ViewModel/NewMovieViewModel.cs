using Nest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nest.ViewModel
{
    public class NewMovieViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}