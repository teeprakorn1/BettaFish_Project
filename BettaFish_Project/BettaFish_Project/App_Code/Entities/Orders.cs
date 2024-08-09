using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Orders
/// </summary>
public class Orders
{
    public int Orders_ID { get; set; }

    public double Orders_TotalPrice { get; set; }
    public DateTime Orders_RegisDate { get; set; }
    public int Users_ID { get; set; }
    public int Payment_ID { get; set; }
    public int OrderStatus_ID { get; set; }
    public int Delivery_ID { get; set; }
    public int Address_ID { get; set; }
    public string OrderStatus_Name { get; set; }
    public string Payment_Image { get; set; }

    public Orders(int Orders_ID)
    {
        this.Orders_ID = Orders_ID;
    }
    public Orders(int Orders_ID,double Orders_TotalPrice, DateTime Orders_RegisDate, int Users_ID,
        int Payment_ID, int OrderStatus_ID, int Delivery_ID ,int Address_ID, string OrdersStatus_Name,string Payment_Image)
    {
        this.Orders_ID = Orders_ID;
        this.Orders_TotalPrice = Orders_TotalPrice;
        this.Orders_RegisDate = Orders_RegisDate;
        this.Users_ID = Users_ID;
        this.Payment_ID = Payment_ID;
        this.OrderStatus_ID = OrderStatus_ID;
        this.Delivery_ID = Delivery_ID;
        this.Address_ID = Address_ID;
        this.OrderStatus_Name = OrdersStatus_Name;
        this.Payment_Image = Payment_Image;
    }
}