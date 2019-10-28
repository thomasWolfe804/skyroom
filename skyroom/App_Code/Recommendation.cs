using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Recommendation
/// </summary>
public class Recommendation
{
    private String content;
    private int TenantID; 
    public Recommendation(String content, int TenantID)
    {
        setContent(content);
        setTID(TenantID);
    }
    //setters
    public void setContent(String content)
    {
        this.content = content;
    }
    public void setTID(int TenantID)
    {
        this.TenantID = TenantID;
    }
    //getters
    public String getContent()
    {
        return this.content;
    }
    public int getTID()
    {
        return this.TenantID;
    }
}