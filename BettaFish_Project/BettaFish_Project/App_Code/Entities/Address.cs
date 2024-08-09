using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Address
/// </summary>
public class Address
{
    public int Address_ID { get; set; }
    public string Address_Name { get; set; }
    public string Address_Detail { get; set; }
    public int Users_ID { get; set; }

    public Address(int Address_ID, string Address_Name, string Address_Detail, int User_ID)
    {
        this.Address_ID = Address_ID;
        this.Address_Name = Address_Name;
        this.Address_Detail = Address_Detail;
        this.Users_ID = User_ID;
    }
}