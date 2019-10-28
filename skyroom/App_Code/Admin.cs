using System;

public class Admin
{
    private int AdminID;

	public Admin(int AdminID)
	{
        setAdminID(AdminID);
	}

    public void setAdminID(int AdminID)
    {
        this.AdminID = AdminID;
    }
    public int getAdminId()
    {
        return this.AdminID;
    }
}
