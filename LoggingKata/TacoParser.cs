using System;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            var tacoBell = new TacoBell();
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            tacoBell.Name = ShouldParseName(line);
            var point = new Point();
            
            point.Latitude = ShouldParseLatitude(line);
            point.Longitude = ShouldParseLongitude(line);
            tacoBell.Location=point;
            return tacoBell;



        }
       

        public double ShouldParseLatitude(string line)
        {
            var corridinates = line.Split(',');
            return double.Parse(corridinates[0]);
        }

        public double ShouldParseLongitude(string line)
        {
            var corridinates = line.Split(',');
            return double.Parse(corridinates[1]);
           
        }
        public string ShouldParseName(string line)
        {
            var corridinates = line.Split(',');
            return corridinates[2];

        }

    }
}

// grab the latitude from your array at index 0//DONE

// grab the longitude from your array at index 1//DONE
// grab the name from your array at index 2//DONE

// Your going to need to parse your string as a `double`
// which is similar to parsing a string as an `int`

// You'll need to create a TacoBell class
// that conforms to ITrackable


// Then, you'll need an instance of the TacoBell class
// With the name and point set correctly



// Then, return the instance of your TacoBell class
// Since it conforms to ITrackable