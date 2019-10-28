using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Appointment
/// </summary>
public class Appointment
{
    private int apptID;
    private String date;
    private int favTenantID;
    private int favPropID;
    
    public Appointment(int apptID, String date, int favTenantID, int favePropID)
    {
        setApptID(apptID);
        setDate(date);
        setFavTenantID(favTenantID);
        setFavPropID(favePropID);

    }

    //apptID
    public int getApptID()
    {
        return this.apptID;
    }

    public void setApptID(int apptID)
    {
        this.apptID = apptID;
    }

    //date
    public String getDate()
    {
        return this.date;
    }

    public void setDate(String date)
    {
        this.date = date;
    }

    //favTenantID
    public int getFavTenantID()
    {
        return this.favTenantID;
    }

    public void setFavTenantID(int favTenantID)
    {
        this.favTenantID = favTenantID;
    }

    //favPropID
    public int getFavPropID()
    {
        return this.favPropID;
    }

    public void setFavPropID(int favPropID)
    {
        this.favPropID = favPropID;
    }
}
