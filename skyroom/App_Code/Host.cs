using System;

public class Host
{
    //Attributes
    private int HostID;
    private String PetFriendly;
    private String BackgroundStatus;
    private String HostType;
    //Constructor
	public Host(int HostID, String PetFriendly, String BackgroundStatus,String HostType)
	{
        setHostId(HostID);
        setPetFriendly(PetFriendly);
        setBackgroundStatus(BackgroundStatus);
        setHostType(HostType);
	}
    //Setters
    public void setHostId(int HostID)
    {
        this.HostID = HostID;
    }
    public void setPetFriendly(String PetFriendly)
    {
        this.PetFriendly = PetFriendly;
    }
    public void setBackgroundStatus(String BackgroundStatus)
    {
        this.BackgroundStatus = BackgroundStatus;
    }
    public void setHostType(String HostType)
    {
        this.HostType = HostType;
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
    public String getBackgroundStatus()
    {
        this.BackgroundStatus;
    }
    public String getHostType()
    {
        this.HostType;
    }
}
