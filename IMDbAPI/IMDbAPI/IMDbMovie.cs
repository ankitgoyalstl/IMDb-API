using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbAPI
{
    /// <summary>
    /// Class to contain complete information of a movie
    /// </summary>
    public class IMDbMovie
    {
        private string _MovieName = null;
        private string _MovieCode = null;
        private List<string> _ActorNames = null;
        private List<string> _DirectorNames = null;
        private string _IMDbURL = null;
        private string _WikiURL = null;
        private string _CoverURL = null;
        private string _MovieRating = null;
        private List<string> _Genres = null;
        private string _ReleaseDate = null;
        private string _RunningTime = null;

        /// <summary>
        /// Name of Movie
        /// </summary>
        public string MovieName
        {
            get { return this._MovieName; }
            set { this._MovieName = value; }
        }

        /// <summary>
        /// Code of the Movie as on IMDb
        /// </summary>
        public string MovieCode
        {
            get { return this._MovieCode; }
            set { this._MovieCode = value; }
        }

        /// <summary>
        /// List of Actors in Movie
        /// </summary>
        public List<string> ActorNames
        {
            get { return this._ActorNames; }
            set { this._ActorNames = value; }
        }

        /// <summary>
        /// List of Movie Directors
        /// </summary>
        public List<string> DirectorNames
        {
            get { return this._DirectorNames; }
            set { this._DirectorNames = value; }
        }

        /// <summary>
        /// URL of Movie on IMDb
        /// </summary>
        public string IMDbURL
        {
            get { return this._IMDbURL; }
            set { this._IMDbURL = value; }
        }

        /// <summary>
        /// URL of Movie on Wikipedia
        /// </summary>
        public string WikiURL
        {
            get { return this._WikiURL; }
            set { this._WikiURL = value; }
        }

        /// <summary>
        /// URL of Cover of Movie
        /// </summary>
        public string CoverURL
        {
            get { return this._CoverURL; }
            set { this._CoverURL = value; }
        }

        /// <summary>
        /// Associated Genres of Movie
        /// </summary>
        public List<string> Genres
        {
            get { return this._Genres; }
            set { this._Genres = value; }
        }

        /// <summary>
        /// Movie Rating (Motion Picture Rating)
        /// </summary>
        public string MovieRating
        {
            get { return this._MovieRating; }
            set { this._MovieRating = value; }
        }

        /// <summary>
        /// Release Date of Movie
        /// </summary>
        public string ReleaseDate
        {
            get { return this._ReleaseDate; }
            set { this._ReleaseDate = value; }
        }

        /// <summary>
        /// Running Time of Movie
        /// </summary>
        public string RunningTime
        {
            get { return this._RunningTime; }
            set { this._RunningTime = value; }
        }
    }
}
