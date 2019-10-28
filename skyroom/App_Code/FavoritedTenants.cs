using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FavoritedTenants
/// </summary>
public class FavoritedTenants
{
    private int TenantID;
    private int HostID;
    public FavoritedTenants(int TenantID, int HostID)
    {
        setTID(TenantID);
        setHID(HostID);
    }
    //Setters
    public void setTID(int TenantID)
    {
        this.TenantID = TenantID;
    }
    public void setHID(int HostID)
    {
        this.HostID = HostID;
    }
    //Getters
    public int getTID()
    {
        return this.TenantID;
    }
    public int getHID()
    {
        return this.HostID;
    }
}