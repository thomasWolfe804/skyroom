using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class FavoritedProperties
{
    private int FavTenantID;
    private int TenantID;
    private int HostID;

    public FavoritedProperties()
    {
        setFavTenantID(FavTenantID);
        setTenantID(TenantID);
        setHostID(HostID);
    }

    // Setters
    public void setFavTenantID(int FavTenantID)
    {
        this.FavTenantID = FavTenantID;
    }

    public void setTenantID(int TenantID)
    {
        this.TenantID = TenantID;
    }

    public void setHostID(int HostID)
    {
        this.HostID = HostID;
    }

    // Getters
    public int getFavTenantID()
    {
        return this.getFavTenantID();
    }

    public int getTenantID()
    {
        return this.getTenantID();
    }

    public int getHostID()
    {
        return this.getHostID();
    }
}