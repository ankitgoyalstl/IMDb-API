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

        public static List<IMDbActor> GetActorsList(IMDbMovie movieData)
        {
            List<IMDbActor> actorsList = null;

            if(string.IsNullOrEmpty(movieData.MovieCode) || string.IsNullOrWhiteSpace(movieData.MovieCode))
            {
                return actorsList;
            }

            string moviePageURL = IMDbUtils.GetCompleteIMDbURL("/title/" + movieData.MovieCode);
            string pageContent = IMDbUtils.GetPage(moviePageURL);

            Regex actorNameRegex = new Regex("<a href=\"(.*)\"\nitemprop='url'> <span class.*\"name\">(.+)</span>");
            MatchCollection regexMatchCollection = actorNameRegex.Matches(pageContent);
            if (regexMatchCollection == null)
            {
                return actorsList;
            }
            else
            {
                actorsList = new List<IMDbActor>();
            }

            foreach (Match regexMatch in regexMatchCollection)
            {
                IMDbActor actorItem = new IMDbActor();
                actorItem.IMDbURL = regexMatch.Groups[1].Value.ToString();
                actorItem.IMDbURL = Regex.Replace(actorItem.IMDbURL, @"/\?ref_=tt_cl_t\d+", "");
                actorItem.IMDbCode = actorItem.IMDbURL.Replace("/name/", "").ToString();
                actorItem.IMDbURL = IMDbUtils.GetCompleteIMDbURL(actorItem.IMDbURL);
                actorItem.Name = regexMatch.Groups[2].Value.ToString();

                actorsList.Add(actorItem);
            }

            return actorsList;
        }
    }
}
