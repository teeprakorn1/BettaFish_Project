using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Cart
/// </summary>
public class Cart
{
    public int Cart_ID { get; set; }
    public int Users_ID { get; set; }
    public int Product_ID { get; set; }
    public int Cart_Equipment_Quality { get; set; }
    public int Cart_Female_Quality { get; set; }
    public int Cart_Male_Quality { get; set; }

    public Cart(int Cart_ID, int Users_ID, int Product_ID, int Cart_Equipment_Quality,
        int Cart_Female_Quality,int Cart_Male_Quality)
    {
        this.Cart_ID = Cart_ID;
        this.Users_ID = Users_ID;
        this.Product_ID = Product_ID;
        this.Cart_Equipment_Quality = Cart_Equipment_Quality;
        this.Cart_Female_Quality = Cart_Female_Quality;
        this.Cart_Male_Quality = Cart_Male_Quality;
    }
}