using System.Configuration;
using System.Data.SqlClient;
using System;
using System.Collections;
using System.Web;
using System.Collections.Generic;

public class ConnectionClass
{
    private static SqlConnection conn;
    private static SqlCommand command;

    static ConnectionClass()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }
    public static User UserLogin(string Users_Username, string Users_Password)
    {
        User user = null;
        string query = string.Format("SELECT COUNT(*) FROM Users WHERE Users_Username = '{0}' AND Users_Password = '{1}'", Users_Username, Users_Password);
        command.CommandText = query;
        try
        {
            conn.Open();
            int amountOfUsers = (int)command.ExecuteScalar();
            if (amountOfUsers == 1)
            {
                command.Parameters.Clear();

                query = string.Format("SELECT U.Users_ID,U.Users_Email,U.Users_ActiveStatus,T.UserType_Name" +
                    " FROM Users U INNER JOIN UserType T ON U.UserType_ID = T.UserType_ID WHERE Users_Username = '{0}'", Users_Username);
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int Users_ID = reader.GetInt32(0);
                    string Users_Email = reader.GetString(1);
                    int Users_ActiveStatus = reader.GetInt32(2);
                    string UserType_Name = reader.GetString(3);

                    user = new User(Users_ID, Users_Username, Users_Password, Users_Email, Users_ActiveStatus, UserType_Name);
                }
                reader.Close();
            }
            return user;
        }
        finally
        {
            conn.Close();
        }
    }
    public static int RegisterUser(string Users_Username, string Users_Password, string Users_Email)
    {
        int value = CheckUsername(Users_Username);

        try
        {

            if (value == 0)
            {//not
                conn.Open();
                string query = string.Format(@"INSERT INTO Users(Users_Username,Users_Password,Users_Email,UserType_ID) VALUES('{0}', '{1}', '{2}','{3}')", Users_Username, Users_Password, Users_Email, '1');
                command.CommandText = query;
                command.ExecuteNonQuery();
                return 1;
            }
            else
            {
                return 0;
            }

        }
        finally
        {
            conn.Close();
        }
    }

    private static int CheckUsername(string Users_Username)
    {
        string query = string.Format("SELECT COUNT(*) FROM Users WHERE Users_Username = '{0}'", Users_Username);

        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();

            if (value > 0)//has use ?
            {
                return 1;//has use
            }
            else
            {
                return 0;//not use
            }
        }
        finally
        {
            conn.Close();
        }
    }


    public static void Registeruser(string user_name, string password, string email, string user_type, string phone)
    {
        string query = string.Format(@"INSERT INTO users(user_name,password,email,user_type,phone) 
            VALUES('{0}','{1}','{2}','{3}','{4}')", user_name, password, email, user_type, phone);
        try
        {
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }
    }

    public static void InsertProduct(string Product_Name, int Product_Price, string Product_Detail, int Product_Male_Amount,
        int Product_Female_Amount, int Product_Equipment_Amount, string Product_Image, string SubCategory_Name)
    {
        string query = string.Format("SELECT SubCategory_ID FROM SubCategories WHERE SubCategory_Name = '{0}'", SubCategory_Name);
        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();
            query = string.Format(@"INSERT INTO Product(Product_Name,Product_Price,Product_Detail,Product_Male_Amount,
            Product_Female_Amount,Product_Equipment_Amount,Product_Image,SubCategory_ID)VALUES('{0}','{1}','{2}','{3}','{4}',
            '{5}','{6}','{7}')",
           Product_Name, Product_Price, Product_Detail, Product_Male_Amount, Product_Female_Amount,
            Product_Equipment_Amount, Product_Image, value);

            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }
    }

    public static Product SelectProduct(int Product_ID)
    {
        Product Product = null;
        string query = string.Format("SELECT COUNT(*) FROM Product WHERE Product_ID = '{0}'", Product_ID);


        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();

            if (value == 1)
            {
                query = string.Format(@"SELECT P.*,S.SubCategory_Name,M.MainCategory_Name FROM ((Product P
                    INNER JOIN SubCategories S ON P.SubCategory_ID = S.SubCategory_ID)
                    INNER JOIN MainCategories M ON S.MainCategory_ID = M.MainCategory_ID)
                    WHERE P.Product_ID = '{0}'", Product_ID);
                command.CommandText = query;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Product_ID = reader.GetInt32(0);
                    string Product_Name = reader.GetString(1);
                    int Product_Price = reader.GetInt32(2);
                    string Product_Detail = reader.GetString(3);
                    int Product_Equipment_Amount = reader.GetInt32(4);
                    int Product_Female_Amount = reader.GetInt32(5);
                    int Product_Male_Amount = reader.GetInt32(6);
                    DateTime Product_RegisDate = reader.GetDateTime(7);
                    string Product_Image = reader.GetString(8);
                    int Product_ActiveStatus = reader.GetInt32(9);
                    int SubCategory_ID = reader.GetInt32(10);
                    string SubCategory_Name = reader.GetString(11);
                    string MainCategory_Name = reader.GetString(12);

                    Product = new Product(Product_ID, Product_Name, Product_Detail, Product_Price, Product_Male_Amount
                    , Product_Female_Amount, Product_Equipment_Amount, Product_RegisDate, Product_Image,
                    Product_ActiveStatus, SubCategory_ID, SubCategory_Name, MainCategory_Name);
                }
                reader.Close();
            }
            return Product;
        }

        finally
        {
            conn.Close();
        }
    }

    public static void UpdateProduct(int Product_ID, string Product_Name, int Product_Price, string Product_Detail,
        int Product_Equipment_Amount, int Product_Female_Amount, int Product_Male_Amount, string Product_Image,
        int Product_ActiveStatus, string SubCategory_Name)
    {
        string query = string.Format("SELECT SubCategory_ID FROM SubCategories WHERE SubCategory_Name = '{0}'", SubCategory_Name);
        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();
            query = string.Format(@"UPDATE Product SET Product_Name ='{1}',Product_Price ='{2}',Product_Detail ='{3}',
            Product_Equipment_Amount ='{4}',Product_Female_Amount ='{5}',Product_Male_Amount ='{6}',Product_Image ='{7}',
            Product_ActiveStatus ='{8}',SubCategory_ID ='{9}' WHERE Product_ID = '{0}'",
          Product_ID, Product_Name, Product_Price, Product_Detail, Product_Equipment_Amount, Product_Female_Amount,
           Product_Male_Amount, Product_Image, Product_ActiveStatus, value);

            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }
    }

    public static ArrayList SelectProductTopSubName(String SubCategory_Name, int Product_ActiveStatus)
    {
        Product Product = null;
        ArrayList list = new ArrayList();
        string query = string.Format(@" SELECT P.*,S.SubCategory_Name,M.MainCategory_Name FROM ((Product P
                INNER JOIN SubCategories S ON P.SubCategory_ID = S.SubCategory_ID)
                INNER JOIN MainCategories M ON S.MainCategory_ID = M.MainCategory_ID)
                WHERE S.SubCategory_Name = '{0}' AND P.Product_ActiveStatus = '{1}'", SubCategory_Name, Product_ActiveStatus);

        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int Product_ID = reader.GetInt32(0);
                string Product_Name = reader.GetString(1);
                int Product_Price = reader.GetInt32(2);
                string Product_Detail = reader.GetString(3);
                int Product_Equipment_Amount = reader.GetInt32(4);
                int Product_Female_Amount = reader.GetInt32(5);
                int Product_Male_Amount = reader.GetInt32(6);
                DateTime Product_RegisDate = reader.GetDateTime(7);
                string Product_Image = reader.GetString(8);
                int SubCategory_ID = reader.GetInt32(10);
                SubCategory_Name = reader.GetString(11);
                string MainCategory_Name = reader.GetString(12);

                Product = new Product(Product_ID, Product_Name, Product_Detail, Product_Price, Product_Male_Amount
                , Product_Female_Amount, Product_Equipment_Amount, Product_RegisDate, Product_Image,
                Product_ActiveStatus, SubCategory_ID, SubCategory_Name, MainCategory_Name);
                list.Add(Product);
            }
        }
        finally
        {
            conn.Close();
        }

        return list;
    }
    public static int CartInsert(int Users_UserID, int Product_ID, int Product_Equipment_Quality,
        int Cart_Female_Quality, int Cart_Male_Quality)
    {
        string query = string.Format(@"SELECT COUNT(*) FROM Cart_Orders WHERE Users_ID = '{0}' AND Product_ID  = '{1}'", Users_UserID, Product_ID);
        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();
            if (value < 1)
            {
                query = string.Format(@"INSERT INTO Cart_Orders(Users_ID,Product_ID,
                    Cart_Equipment_Quality,Cart_Female_Quality,Cart_Male_Quality)
                    VALUES('{0}','{1}','{2}','{3}','{4}')",
                    Users_UserID, Product_ID, Product_Equipment_Quality,
                    Cart_Female_Quality, Cart_Male_Quality);
                command.CommandText = query;
                command.ExecuteNonQuery();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static ArrayList SelectCart(int Users_ID)
    {
        Cart cart = null;
        ArrayList list = new ArrayList();
        string query = string.Format(@"SELECT * FROM Cart_Orders WHERE Users_ID ='{0}'", Users_ID);

        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int Cart_ID = reader.GetInt32(0);
                int Product_ID = reader.GetInt32(2);
                int Cart_Equipment_Quality = reader.GetInt32(3);
                int Cart_Female_Quality = reader.GetInt32(4);
                int Cart_Male_Quality = reader.GetInt32(5);

                cart = new Cart(Cart_ID, Users_ID, Product_ID, Cart_Equipment_Quality
                    , Cart_Female_Quality, Cart_Male_Quality);
                list.Add(cart);
            }
            reader.Close();
            return list;
        }
        finally
        {
            conn.Close();
        }
    }


    public static int DropCart(int Users_UserID)
    {
        string query = string.Format(@"SELECT COUNT(*) FROM Cart_Orders WHERE Users_ID = '{0}'", Users_UserID);
        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();
            if (value != 0)
            {
                query = string.Format(@"DELETE FROM Cart_Orders WHERE Users_ID = '{0}'", Users_UserID);
                command.CommandText = query;
                command.ExecuteNonQuery();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static int PromotionInsert(string Promotion_CodeName, int Promotion_Percent)
    {
        string query = string.Format(@"SELECT COUNT(*) FROM Promotion WHERE Promotion_CodeName = '{0}'", Promotion_CodeName);
        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();
            if (value < 1)
            {
                query = string.Format(@"INSERT INTO Promotion(Promotion_CodeName,Promotion_Percent)
                    VALUES('{0}','{1}')", Promotion_CodeName, Promotion_Percent);
                command.CommandText = query;
                command.ExecuteNonQuery();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static Promotion SelectPromotion(int Promotion_ID)
    {
        Promotion promotion = null;
        string query = string.Format("SELECT COUNT(*) FROM Promotion WHERE Promotion_ID = '{0}'", Promotion_ID);


        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();

            if (value == 1)
            {
                query = string.Format(@"SELECT * FROM Promotion WHERE Promotion_ID = '{0}'", Promotion_ID);
                command.CommandText = query;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string Promotion_Name = reader.GetString(1);
                    int Promotion_Percent = reader.GetInt32(2);
                    DateTime Promotion_RegisDate = reader.GetDateTime(3);
                    int Promotion_Active_Status = reader.GetInt32(4);


                    promotion = new Promotion(Promotion_ID, Promotion_Name, Promotion_Percent, Promotion_RegisDate, Promotion_Active_Status);
                }
                reader.Close();
            }
            return promotion;
        }

        finally
        {
            conn.Close();
        }
    }

    public static int UpdatePromotion(int Promotion_ID, string Promotion_Name, int Promotion_Percent, int Promotion_Active_Status)
    {
        string query = string.Format(@"SELECT COUNT(*) FROM Promotion WHERE Promotion_ID = '{0}'", Promotion_ID);
        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();
            if (value == 1)
            {
                query = string.Format(@"UPDATE Promotion SET Promotion_CodeName ='{1}',Promotion_Percent ='{2}',
                                Promotion_ActiveStatus ='{3}' WHERE Promotion_ID = '{0}'", Promotion_ID, Promotion_Name,
                                Promotion_Percent, Promotion_Active_Status);
                command.CommandText = query;
                command.ExecuteNonQuery();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static int SelectPromotionByCodeName(String Promotion_CodeName, int Promotion_ActiveStatus)
    {
        string query = string.Format("SELECT COUNT(*) FROM Promotion WHERE Promotion_CodeName = '{0}'", Promotion_CodeName);


        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();

            if (value == 1)
            {
                query = string.Format(@"SELECT Promotion_Percent FROM Promotion WHERE
                            Promotion_CodeName = '{0}' AND Promotion_ActiveStatus = '{1}'",
                            Promotion_CodeName, Promotion_ActiveStatus);
                command.CommandText = query;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int Promotion_Percent = reader.GetInt32(0);
                    reader.Close();

                    return Promotion_Percent;
                }
                return 1;
            }
            return 1;
        }

        finally
        {
            conn.Close();
        }
    }

    public static User SelectUserOfUpdateProfile(int Users_ID)
    {
        User user = null;
        string query = string.Format("SELECT COUNT(*) FROM Users WHERE Users_ID = '{0}'", Users_ID);


        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();

            if (value == 1)
            {
                query = string.Format(@"SELECT Users_FName,Users_LName,Users_Phone FROM Users WHERE Users_ID = '{0}';", Users_ID);
                command.CommandText = query;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string Users_FName = reader.GetString(0);
                    string Users_LName = reader.GetString(1);
                    string Users_Phone = reader.GetString(2);
                    user = new User(Users_FName, Users_LName, Users_Phone);
                }
                reader.Close();
            }
            return user;
        }

        finally
        {
            conn.Close();
        }
    }

    public static int UpdateProfile(int Users_ID, string Users_FName, string Users_LName, string Users_Phone)
    {
        string query = string.Format(@"SELECT COUNT(*) FROM Users WHERE Users_ID = '{0}'", Users_ID);
        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();
            if (value == 1)
            {
                query = string.Format(@"UPDATE Users SET Users_FName ='{0}',Users_LName ='{1}',
                                Users_Phone ='{2}' WHERE Users_ID = '{3}'", Users_FName, Users_LName,
                                Users_Phone, Users_ID);
                command.CommandText = query;
                command.ExecuteNonQuery();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static void InsertAddress(string Address_Name, string Address_Detail, int Users_ID)
    {
        try
        {
            conn.Open();
            string query = string.Format(@"INSERT INTO [Address](Address_Name,Address_Detail,Users_ID)VALUES('{0}','{1}',{2})",
           Address_Name, Address_Detail, Users_ID);

            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }
    }

    public static ArrayList SelectAddress(int Users_ID)
    {
        Address address = null;
        ArrayList list = new ArrayList();

        try
        {
            conn.Open();
            string query = string.Format(@"SELECT * FROM [Address] WHERE Users_ID = '{0}'", Users_ID);
            command.CommandText = query;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int Address_ID = reader.GetInt32(0);
                string Address_Name = reader.GetString(1);
                string Address_Detail = reader.GetString(2);

                address = new Address(Address_ID, Address_Name, Address_Detail, Users_ID);
                list.Add(address);
            }
            reader.Close();
            return list;
        }
        finally
        {
            conn.Close();
        }
    }

    public static Address SelectAddressByAddress_NameAndUsers_ID(string Address_Name, int Users_ID)
    {
        Address address = null;
        string query = string.Format("SELECT COUNT(*) FROM [Address] WHERE Address_Name = '{0}' AND Users_ID = '{1}'", Address_Name, Users_ID);


        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();

            if (value == 1)
            {
                query = string.Format(@"SELECT * FROM [Address] WHERE Address_Name = '{0}' AND Users_ID = '{1}'", Address_Name, Users_ID);
                command.CommandText = query;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int Address_ID = reader.GetInt32(0);
                    string Address_Detail = reader.GetString(2);

                    address = new Address(Address_ID, Address_Name, Address_Detail, Users_ID);
                }
                reader.Close();
            }
            return address;
        }

        finally
        {
            conn.Close();
        }
    }

    public static void UpdateAddress(int Address_ID, int UserID, string Address_Name, string Address_Detail)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string query = @"UPDATE Address 
                        SET Address_Name = @AddressName, Address_Detail = @AddressDetail
                        WHERE Address_ID = @AddressID AND Users_ID = @UserID";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@AddressName", Address_Name);
                command.Parameters.AddWithValue("@AddressDetail", Address_Detail);
                command.Parameters.AddWithValue("@AddressID", Address_ID);
                command.Parameters.AddWithValue("@UserID", UserID);

                command.ExecuteNonQuery();
            }
        }
    }

    public static int DropAddress(int Address_ID)
    {
        string query = string.Format(@"SELECT COUNT(*) FROM Address WHERE Address_ID = '{0}'", Address_ID);
        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();
            if (value != 0)
            {
                query = string.Format(@"DELETE FROM Address WHERE Address_ID = '{0}'", Address_ID);
                command.CommandText = query;
                command.ExecuteNonQuery();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static ArrayList SelectProductLikeName(String Search_value, int Product_ActiveStatus)
    {
        Product Product = null;
        ArrayList list = new ArrayList();
        string query = string.Format(@"  SELECT P.*,S.SubCategory_Name,M.MainCategory_Name FROM ((Product P
                INNER JOIN SubCategories S ON P.SubCategory_ID = S.SubCategory_ID)
                INNER JOIN MainCategories M ON S.MainCategory_ID = M.MainCategory_ID)
                WHERE P.Product_Name LIKE '%{0}%' OR M.MainCategory_Name LIKE '%{0}%' 
				OR M.MainCategory_Name LIKE '%{0}%' OR P.Product_Detail LIKE '%{0}%' 
				AND P.Product_ActiveStatus = '{1}'", Search_value, Product_ActiveStatus);

        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int Product_ID = reader.GetInt32(0);
                string Product_Name = reader.GetString(1);
                int Product_Price = reader.GetInt32(2);
                string Product_Detail = reader.GetString(3);
                int Product_Equipment_Amount = reader.GetInt32(4);
                int Product_Female_Amount = reader.GetInt32(5);
                int Product_Male_Amount = reader.GetInt32(6);
                DateTime Product_RegisDate = reader.GetDateTime(7);
                string Product_Image = reader.GetString(8);
                int SubCategory_ID = reader.GetInt32(10);
                string SubCategory_Name = reader.GetString(11);
                string MainCategory_Name = reader.GetString(12);

                Product = new Product(Product_ID, Product_Name, Product_Detail, Product_Price, Product_Male_Amount
                , Product_Female_Amount, Product_Equipment_Amount, Product_RegisDate, Product_Image,
                Product_ActiveStatus, SubCategory_ID, SubCategory_Name, MainCategory_Name);
                list.Add(Product);
            }
        }
        finally
        {
            conn.Close();
        }

        return list;
    }
    public static int InsertPayment(string Payment_Image,int PaymentStatus_ID)
    {
        try
        {
            conn.Open();
            string query = string.Format(@"INSERT INTO Payment(Payment_Image,PaymentStatus_ID)
                VALUES('{0}','{1}')",
           Payment_Image, PaymentStatus_ID);
            command.CommandText = query;
            command.ExecuteNonQuery();

            query = string.Format(@"SELECT Payment_ID FROM Payment WHERE Payment_Image = '{0}' AND
                                PaymentStatus_ID = '{1}'",
           Payment_Image, PaymentStatus_ID);
            command.CommandText = query;
            return (int)command.ExecuteScalar();
        }
        finally
        {
            conn.Close();
        }
    }

    public static int InsertDelivery(String Address_Name, int DeliveryType_ID, int DeliveryStatus_ID)
    {
        try
        {
            conn.Open();
            string query = string.Format(@"SELECT Address_ID FROM Address WHERE Address_Name = '{0}'",
           Address_Name);
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();
           query = string.Format(@"INSERT INTO Delivery(Address_ID,DeliveryType_ID,DeliveryStatus_ID)
                VALUES('{0}','{1}','{2}')",
           value, DeliveryType_ID, DeliveryStatus_ID);
           command.CommandText = query;
           command.ExecuteNonQuery();

            query = string.Format(@"SELECT Delivery_ID FROM Delivery WHERE Address_ID ='{0}' 
                    AND DeliveryStatus_ID = '{1}'",
           value, DeliveryStatus_ID);
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            int i=0;
            if (reader.Read())
            {
                i = reader.GetInt32(0);
            }
            reader.Close();

            query = string.Format(@"UPDATE Delivery SET DeliveryStatus_ID = '2'
                   WHERE Delivery_ID = '{0}'", DeliveryType_ID);
            command.CommandText = query;
            return i;
        }
        finally
        {
            conn.Close();
        }
    }

    public static void InsertOrders(int User_ID,int OrderStatus_ID, int Payment_ID,int Delivery_ID)
    {
        try
        {
            conn.Open();
            string query = string.Format(@"INSERT INTO Orders(Users_ID,OrderStatus_ID,
                            Payment_ID,Delivery_ID)
                            VALUES('{0}','{1}','{2}','{3}')",
           User_ID, OrderStatus_ID, Payment_ID, Delivery_ID);

            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }
    }

    public static int SelectOrdersByUsers(int Users_ID,int Payment_ID)
    {
        int Orders_ID = 0;
        string query = string.Format(@"SELECT COUNT(*) FROM Orders WHERE Users_ID = '{0}'
                        AND Payment_ID = '{1}'"
            , Users_ID, Payment_ID);


        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();

            if (value == 1)
            {
                query = string.Format(@"SELECT Orders_ID FROM Orders WHERE Users_ID = '{0}' AND 
                                    Payment_ID = '{1}'",
                    Users_ID, Payment_ID);
                command.CommandText = query;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Orders_ID = reader.GetInt32(0);
                }
                reader.Close();
            }
            return Orders_ID;
        }

        finally
        {
            conn.Close();
        }
    }

    public static int OrderDetailInsert(int OrderDetail_Price,
        int OrderDetail_Equipment_Quality, int OrderDetail_Male_Quality,
        int OrderDetail_Female_Quality,int Orders_ID,int Product_ID)
    {
        string query = string.Format(@"SELECT COUNT(*) FROM OrderDetail WHERE Orders_ID = '{0}'
                    AND Product_ID  = '{1}'", Orders_ID, Product_ID);
        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();
            if (value < 1)
            {
                query = string.Format(@"INSERT INTO OrderDetail(Orders_ID,Product_ID,
                    OrderDetail_Price,OrderDetail_Equipment_Quality,OrderDetail_Male_Quality,
                    OrderDetail_Female_Quality)
                    VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                    Orders_ID, Product_ID, OrderDetail_Price,
                    OrderDetail_Equipment_Quality, OrderDetail_Male_Quality,
                    OrderDetail_Female_Quality);
                command.CommandText = query;
                command.ExecuteNonQuery();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static int UpdateOrders(Double TotalPrice,int Orders_ID)
    {
        string query = string.Format(@"SELECT COUNT(*) FROM Orders WHERE Orders_ID = '{0}'", Orders_ID);
        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();
            if (value == 1)
            {
                query = string.Format(@"UPDATE Orders SET Orders_TotalPrice ='{0}'
                            WHERE Orders_ID = '{1}'", TotalPrice, Orders_ID);
                command.CommandText = query;
                command.ExecuteNonQuery();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static ArrayList SelectOrdersID(int Users_ID)
    {
        Orders orders = null;
        ArrayList list = new ArrayList();

        try
        {
            conn.Open();
            string query = string.Format(@"SELECT Orders_ID FROM [Orders] WHERE Users_ID = '{0}'", Users_ID);
            command.CommandText = query;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int Orders_ID = reader.GetInt32(0);

                orders = new Orders(Orders_ID);
                list.Add(orders);
            }
            reader.Close();
            return list;
        }
        finally
        {
            conn.Close();
        }
    }

    public static Orders SelectOrdersByID(int Orders_ID)
    {
        Orders orders = null;

        try
        {
            conn.Open();
                string query = string.Format(@"SELECT p.*,d.Address_ID,s.OrderStatus_Name,ps.Payment_Image FROM (((Orders p 
                    INNER JOIN OrderStatus s ON  p.OrderStatus_ID = s.OrderStatus_ID)
                    INNER JOIN Delivery d ON  d.Delivery_ID = p.Delivery_ID)
                    INNER JOIN Payment ps ON  p.Payment_ID = ps.Payment_ID)
                    WHERE Orders_ID ='{0}'", Orders_ID);
                command.CommandText = query;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Double Orders_TotalPrice = reader.GetDouble(1);
                    DateTime Orders_RegisDate = reader.GetDateTime(2);
                    int Users_ID = reader.GetInt32(3);
                    int Payment_ID = reader.GetInt32(4);
                    int OrderStatus_ID = reader.GetInt32(5);
                    int Delivery_ID = reader.GetInt32(6);
                    int Address_ID = reader.GetInt32(7);
                    string OrderStatus_Name = reader.GetString(8);
                    string Payment_Image = reader.GetString(9);

                orders = new Orders(Orders_ID,Orders_TotalPrice, Orders_RegisDate, Users_ID, Payment_ID,
                        OrderStatus_ID, Delivery_ID, Address_ID, OrderStatus_Name, Payment_Image);
                }
                reader.Close();

            return orders;
        }

        finally
        {
            conn.Close();
        }
    }

    public static void UpdateProductAmount(int Product_ID, int item, int male, int female)
    {
        string query = string.Format(@"SELECT COUNT(*) FROM Product WHERE Product_ID = '{0}'", Product_ID);
        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();
            if (value == 1)
            {
                query = string.Format(@"UPDATE Product 
                SET Product.Product_Equipment_Amount='{0}',Product.Product_Male_Amount='{1}',Product.Product_Female_Amount='{2}'
                WHERE Product_ID = '{3}'", item, male, female, Product_ID);
                command.CommandText = query;
                command.ExecuteNonQuery();;
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static void UpdateOrdersById(int Orders_ID,int OrderStatus_ID)
    {
        string query = string.Format("SELECT COUNT(*) FROM Orders WHERE Orders_ID = '{0}'", Orders_ID);
        try
        {
            conn.Open();
            command.CommandText = query;
            int value = (int)command.ExecuteScalar();
            if (value == 1)
            {
                query = string.Format(@"UPDATE Orders SET OrderStatus_ID ='{0}' WHERE Orders_ID = '{1}'",
              OrderStatus_ID, Orders_ID);

                command.CommandText = query;
                command.ExecuteNonQuery();
            }
        }
        finally
        {
            conn.Close();
        }
    }
}

