using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Promotion
/// </summary>
public class Promotion
{
    public int Promotion_ID { get; set; }
    public string Promotion_CodeName { get; set; }
    public int Promotion_Percent { get; set; }
    public DateTime Promotion_RegisDate { get; set; }
    public int Promotion_ActiveStatus { get; set; }

    public Promotion(int Promotion_ID, string Promotion_CodeName, int Promotion_Percent,
        DateTime Promotion_RegisDate, int Promotion_ActiveStatus)
    {
        this.Promotion_ID = Promotion_ID;
        this.Promotion_CodeName = Promotion_CodeName;
        this.Promotion_Percent = Promotion_Percent;
        this.Promotion_RegisDate = Promotion_RegisDate;
        this.Promotion_ActiveStatus = Promotion_ActiveStatus;
    }
}