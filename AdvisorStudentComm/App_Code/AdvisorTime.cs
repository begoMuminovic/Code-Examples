using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

/// <summary>
/// Summary description for AdvisorTime
/// </summary>
public class AdvisorTime
{
    public DateTime Time { get; set; };
    public int Hours { get; set; };
    

    
    public AdvisorTime()
    {
        AdvisingDBEntities dbcon = new AdvisingDBEntities();
        


        //
        // TODO: Add constructor logic here
        //
    }
}