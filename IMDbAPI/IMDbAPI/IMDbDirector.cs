using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbAPIInternal
{
    class IMDbDirector
    {
        private string _Name = null;
        private string _IMDbURL = null;

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
    }
}
