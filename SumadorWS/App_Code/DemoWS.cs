using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for DemoWS
/// </summary>
[WebService(Namespace = "http://demo.suma.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class DemoWS : System.Web.Services.WebService {

    public DemoWS () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public int suma(int num1, int num2)
    {
        return num1 + num2;
    }
    
}
