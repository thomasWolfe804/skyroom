using System;

public class Tenant
{
    //Attributes
    private int TenantID;
    private String PetFriendly;
    private String ChoreFriendly;
    private String BackgroundStatus;
    private String TenantType;
    //Constructor
	public Tenant(int TenantID,String PetFriendly,String ChoreFriendly,String BackgroundStatus,String TenantType)
	{
        setTenantId(TenantID);
        setPetFriendly(PetFriendly);
        setChoreFriendly(ChoreFriendly);
        setBackgroundStatus(BackgroundStatus);
        setHostType(TenantType);
    }
    //Setters
    public void setTenantId(int TenantID)
    {
        this.TenantID = TenantID;
    }
    public void setPetFriendly(String PetFriendly)
    {
        this.PetFriendly = PetFriendly;
    }
    public void setChoreFriendly(String ChoreFriendly)
    {
        this.ChoreFriendly = ChoreFriendly;
    }
    public void setBackgroundStatus(String BackgroundStatus)
    {
        this.BackgroundStatus = BackgroundStatus;
    }
    public void setTenantType(String TenantType)
    {
        this.TenantType = TenantType;
    }
    //Getters
    public int getHostId()
    {
        return this.HostID;
    }
    public String getPetFriendly()
    {
        return this.PetFriendly;
    }
    public String getChoreFriendly()
    {
        return this.ChoreFriendly;
    }
    public String getBackgroundStatus()
    {
        this.BackgroundStatus;
    }
    public String getHostType()
    {
        this.HostType;
    }
}
