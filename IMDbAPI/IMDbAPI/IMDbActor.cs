using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbAPI
{
    /// <summary>
    /// Class to contain details about Actor/Actress
    /// </summary>
    class IMDbActor
    {
        private string _Name = null;
        private string _IMDbURL = null;
        private string _PhotoURL = null;
        private string _WikiURL =  null;

        /// <summary>
        /// Nameof the Actor
        /// </summary>
        public string Name
        {
            get { return this._Name; }
            set { this._Name = value; }
        }

        /// <summary>
        /// Link of IMDb Page of Actor
        /// </summary>
        public string IMDbURL
        {
            get { return this._IMDbURL; }
            set { this._IMDbURL = value; }
        }

        /// <summary>
        /// Link of Wikipedia Page of Actor
        /// </summary>
        public string WikiURL
        {
            get { return this._WikiURL; }
            set { this._WikiURL = value; }
        }

        /// <summary>
        /// Link of Photos of Actor
        /// </summary>
        public string PhotoURL
        {
            get { return this._PhotoURL; }
            set { this._PhotoURL = PhotoURL; }
        }
    }
}
