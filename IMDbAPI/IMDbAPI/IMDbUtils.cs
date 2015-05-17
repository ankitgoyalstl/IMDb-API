using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IMDbAPIInternal
{
    class IMDbUtils
    {
        private const string searchBaseURL = "http://www.imdb.com/search/title?release_date={year},{year}&sort=moviemeter,asc&title={movieName}&title_type=feature&view=simple";
        private const string imdbBaseURL = "http://www.imdb.com";
        /// <summary>
        /// Function to Read a WebPage
        /// </summary>
        /// <param name="pageUrl"> URL of the WebPage </param>
        /// <returns> HTML of the WebPage </returns>
        public static string GetPage(string pageUrl)
        {
            string pageContent = string.Empty;
            try
            {
                WebRequest webRequest = WebRequest.Create(pageUrl);
                WebResponse webResponse = webRequest.GetResponse();

                webRequest.Method = "GET";
                webRequest.Timeout = 5000;
                using (StreamReader streamReader = new StreamReader(webResponse.GetResponseStream()))
                {
                    pageContent = streamReader.ReadToEnd();
                    streamReader.Close();
                }

                webResponse.Close();
            }
            catch (Exception ex)
            {
                // Handle Exception
                pageContent = string.Empty;
            }

            return pageContent;
        }

        /// <summary>
        /// Function to Generate URL which geerates Search results
        /// </summary>
        /// <param name="movieName"> Name of the Movie </param>
        /// <param name="releaseYear"> Release Year of the Movie </param>
        /// <returns> URL of the Results Page </returns>
        public static string GenerateMovieSearchURL(string movieName, string releaseYear)
        {
            string pageURL = searchBaseURL;
            pageURL = pageURL.Replace("{year}", releaseYear);
            pageURL = pageURL.Replace("{movieName}", movieName);
            return pageURL;
        }

        /// <summary>
        /// Function to get complete IMDb URL from a partial one
        /// </summary>
        /// <param name="urlLink"> Partial URL </param>
        /// <returns> Complete URL </returns>
        public static string GetCompleteIMDbURL(string urlLink)
        {
            return (imdbBaseURL + urlLink);
        }
    }
}
