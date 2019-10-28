using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ViewedProperties
/// </summary>
public class ViewedProperties
{
    private int TenantID;
    private int PropertyID;
    public ViewedProperties(int TenantID, int PropertyID)
    {
        setTID(TenantID);
        setPID(PropertyID);
    }
    //Setters
    public void setTID(int TenantID)
    {
        this.TenantID = TenantID;
    }
    public void setPID(int PropertyID)
    {
        this.PropertyID = PropertyID;
    }
    //Getters
    public int getTID()
    {
        return this.TenantID;
    }
    public int getPID()
    {
        return this.PropertyID;
    }
}