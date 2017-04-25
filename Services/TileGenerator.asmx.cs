using Microsoft.DeepZoomTools;
using System.Collections.Generic;
using System.IO;
using System.Web.Services;

namespace TileGenerator.Services
{
    /// <summary>
    /// Summary description for TileGenerator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TileGenerator : System.Web.Services.WebService
    {

        [WebMethod]
        public void CreateTiles(string url, string destination)
        {
            if (!File.Exists(destination))
            {
                ImageCreator creator = new ImageCreator();
                CollectionCreator cc = new CollectionCreator();
                creator.Create(url, destination);
                cc.Create(new List<string> { destination }, "C:\\tu\\dzc_output.xml");
                return;
            }
        }
    }
}
