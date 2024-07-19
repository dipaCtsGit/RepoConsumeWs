using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TestWS
{
    /// <summary>
    /// Summary description for SrGetRemnd
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SrGetRemnd : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetRemainder(float x, float y)
        {
            try
            {
                float r;

                if (x ==0 || y==0 )
                {
                    return "Cannot divide by zero.";
                }
                else
                {
                    if (x>y)                    
                        r = x % y;                   
                    else
                        r = y % x;

                    return "The remainder is : " + r;
                }

            }
            catch(Exception ex)
            {
                return "Error in" + ex.Message;
            }
        }
    }
}
