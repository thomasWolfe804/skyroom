using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Messages
{
    private int messageID;
    private int favPropID;
    private int favTenantID;
    private string messageContent;
    private DateTime dateTime; 

    public Messages(int messageID, int favPropID, int favTenantID, string messageContent)
    {
        setMessageID(messageID);
        setFavPropID(favPropID);
        setFavTenantID(favTenantID);
        setMessageContent(messageContent);
        setDateTime(DateTime.Now); 
    }

    // Setters for Messages class

    public void setMessageID(int messageID)
    {
        this.messageID = messageID;
    }

    public void setFavPropID(int favPropID)
    {
        this.favPropID = favPropID;
    }

    public void setFavTenantID(int favTenatID)
    {
        this.favTenantID = favTenantID;
    }

    public void setMessageContent(string messageContent)
    {
        this.messageContent = messageContent;
    }

    public void setDateTime(DateTime dateTime)
    {
        this.dateTime = dateTime; 
    }

    // Getters for Messages class
    
    public int getMessageID()
    {
        return this.messageID;
    }

    public int getFavPropID()
    {
        return this.favPropID;
    }

    public int getFavTenantID()
    {
        return this.favTenantID;
    }

    public string getMessageContent()
    {
        return this.messageContent;
    }

    public DateTime GetDate()
    {
        return this.dateTime;
    }

}