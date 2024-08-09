using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    public int Users_ID { get; set; }
    public string Users_Username { get; set; }
    public string Users_Password { get; set; }
    public string Users_FName { get; set; }
    public string Users_LName { get; set; }
    public string Users_Email { get; set; }
    public string Users_Phone { get; set; }
    public DateTime Users_RegisDate { get; set; }
    public DateTime Users_BirtDate { get; set; }
    public int Users_ActiveStatus { get; set; }
    public int UserType_ID { get; set; }
    public string UserType_Name { get; set; }

    //ALL USER
    public User(int Users_ID, string Users_Username, string Users_Password, string Users_FName, string Users_LName, string Users_Email
        , string Users_Phone, DateTime Users_RegisDate, DateTime Users_BirtDate, int Users_ActiveStatus, int UserType_ID)
    {
        this.Users_ID = Users_ID;
        this.Users_Username = Users_Username;
        this.Users_Password = Users_Password;
        this.Users_FName = Users_FName;
        this.Users_LName = Users_LName;
        this.Users_Email = Users_Email;
        this.Users_Phone = Users_Phone;
        this.Users_RegisDate = Users_RegisDate;
        this.Users_BirtDate = Users_BirtDate;
        this.Users_ActiveStatus = Users_ActiveStatus;
        this.UserType_ID = UserType_ID;
    }

    //Login USER
    public User(int Users_ID, string Users_Username, string Users_Password, string Users_Email, int Users_ActiveStatus, string UserType_Name)
    {
        this.Users_ID = Users_ID;
        this.Users_Username = Users_Username;
        this.Users_Password = Users_Password;
        this.Users_Email = Users_Email;
        this.Users_ActiveStatus = Users_ActiveStatus;
        this.UserType_Name = UserType_Name;
    }
    public User(string Users_FName, string Users_LName, string Users_Phone)
    {
        this.Users_FName = Users_FName;
        this.Users_LName = Users_LName;
        this.Users_Phone = Users_Phone;
    }
}