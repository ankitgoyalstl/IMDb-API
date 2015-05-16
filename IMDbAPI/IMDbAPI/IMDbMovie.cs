using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbAPIInternal
{
    /// <summary>
    /// 
    /// </summary>
    class IMDbMovie
    {
        private string _MovieName = null;
        private List<IMDbActor> _Actors = null;
        private List<IMDbDirector> _Directors = null;
        private string _IMDbURL = null;
        private string _WikiURL = null;
        private string _CoverURL = null;
        private string _MovieRating = null;
        private List<string> _Genres = null;
        private string _ReleaseDate = null;
        private string _RunningTime = null;

        public string MovieName
        {
            get { return this._MovieName; }
            set { this._MovieName = value; }
        }

        public List<IMDbActor> Actors
        {
            get { return this._Actors; }
            set { this._Actors = value; }
        }

        public List<IMDbDirector> Directors
        {
            get { return this._Directors; }
            set { this._Directors = value; }
        }

        public string IMDbURL
        {
            get { return this._IMDbURL; }
            set { this._IMDbURL = value; }
        }

        public string WikiURL
        {
            get { return this._WikiURL; }
            set { this._WikiURL = value; }
        }

        public string CoverURL
        {
            get { return this._CoverURL; }
            set { this._CoverURL = value; }
        }

        public List<string> Genres
        {
            get { return this._Genres; }
            set { this._Genres = value; }
        }

        public string MovieRating
        {
            get { return this._MovieRating; }
            set { this._MovieRating = value; }
        }

        public string ReleaseDate
        {
            get { return this._ReleaseDate; }
            set { this._ReleaseDate = value; }
        }

        public string RunningTime
        {
            get { return this._RunningTime; }
            set { this._RunningTime = value; }
        }
    }
}
