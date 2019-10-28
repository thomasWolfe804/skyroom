using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class PropertyRoom
{
    private int roomID;
    private int propertyID;
    private double monthlyPrice;

    public PropertyRoom()
    {
        setRoomID(roomID);
        setPropertyID(propertyID);
        setMonthlyPrice(monthlyPrice);
    }

    // Setters
    public void setRoomID(int roomID)
    {
        this.roomID = roomID;
    }

    public void setPropertyID(int propertyID)
    {
        this.propertyID = propertyID;
    }

    public void setMonthlyPrice(double monthlyPrice)
    {
        this.monthlyPrice = monthlyPrice;
    }

    // Getters
    public int getRoomID()
    {
        return this.roomID;
    }

    public int getPropertyID()
    {
        return this.propertyID;
    }

    public double getMonthlyPrice()
    {
        return this.monthlyPrice;
    }
}