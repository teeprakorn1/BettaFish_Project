using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    public int Product_ID { get; set; }
    public string Product_Name { get; set; }
    public string Product_Detail { get; set; }
    public int Product_Price { get; set; }
    public int Product_Male_Amount { get; set; }
    public int Product_Female_Amount { get; set; }
    public int Product_Equipment_Amount { get; set; }
    public DateTime Product_RegisDate { get; set; }
    public string Product_Image { get; set; }
    public int Product_ActiveStatus { get; set; }
    public int SubCategory_ID { get; set; }
    public string SubCategory_Name { get; set; }
    public string MainCategory_Name { get; set; }

    public Product(int Product_ID,string Product_Name, string Product_Detail, int Product_Price, int Product_Male_Amount
        , int Product_Female_Amount, int Product_Equipment_Amount, DateTime Product_RegisDate,string Product_Image,
        int Product_ActiveStatus, int SubCategory_ID, string SubCategory_Name, string MainCategory_Name)
    {
        this.Product_ID = Product_ID;
        this.Product_Name = Product_Name;
        this.Product_Detail = Product_Detail;
        this.Product_Price = Product_Price;
        this.Product_Male_Amount = Product_Male_Amount;
        this.Product_Female_Amount = Product_Female_Amount;
        this.Product_Equipment_Amount = Product_Equipment_Amount;
        this.Product_RegisDate = Product_RegisDate;
        this.Product_Image = Product_Image;
        this.Product_ActiveStatus = Product_ActiveStatus;
        this.SubCategory_ID = SubCategory_ID;
        this.SubCategory_Name = SubCategory_Name;
        this.MainCategory_Name = MainCategory_Name;
    }
}
