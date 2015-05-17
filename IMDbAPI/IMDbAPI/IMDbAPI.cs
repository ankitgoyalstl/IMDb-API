using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMDbAPIInternal;
using System.Text.RegularExpressions;

namespace IMDbAPI
{
    public class IMDbAPI
    {
        public static List<IMDbMovie> GetMovieList(string movieName, string movieYear)
        {
            List<IMDbMovie> movieList = null;
            string searchPageURL = IMDbUtils.GenerateMovieSearchURL(movieName, movieYear);
            string pageContent = IMDbUtils.GetPage(searchPageURL);

            Regex movieNameRegex = new Regex("<a href=\"(/title/tt\\d{7}/)\">(.*)</a>");
            MatchCollection regexMatchCollection = movieNameRegex.Matches(pageContent);
            if(regexMatchCollection == null)
            {
                return movieList;
            }
            else
            {
                movieList = new List<IMDbMovie>();
            }

            foreach (Match regexMatch in regexMatchCollection)
            {
                IMDbMovie movieItem = new IMDbMovie();
                movieItem.IMDbURL = IMDbUtils.GetCompleteIMDbURL(regexMatch.Groups[1].Value.ToString());
                movieItem.MovieCode = regexMatch.Groups[1].Value.ToString().Replace("/title/", "").Replace("/", "").ToString();
                movieItem.MovieName = regexMatch.Groups[2].Value.ToString();

                movieList.Add(movieItem);
            }

            return movieList;
        }
    }
}
