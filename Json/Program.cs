using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;




namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie
              {
                Name = "Bad Boys",
                Year = 1995
              };
            
        File.WriteAllText(@"c:\movie.json", JsonConvert.SerializeObject(movie));
        }
    }
}
