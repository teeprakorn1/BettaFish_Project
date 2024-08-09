using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Admin_Admin_Promotion_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserType_Name"] != null)
        {
            if (Session["UserType_Name"].ToString() != "Admin")
            {
                Response.Redirect("~/main.aspx");
            }
        }
        else
        {
            Response.Redirect("~/main.aspx");
        }
    }

    private void PromotionStatus_Checkbox()
    {
        if (PromotionStatus_True.Checked && PromotionStatus_False.Checked)
        {
            PromotionStatus_True.Checked = false;
            PromotionStatus_False.Checked = false;
        }
    }

    protected void AddPromotion_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/Admin/Admin_Promotion_Add.aspx");
    }

    protected void UpdatePromotion_btn_Click(object sender, EventArgs e)
    {
        if (PromotionID_TxtBox.Text != "")
        {
            int value = ConnectionClass.UpdatePromotion(Convert.ToInt32(PromotionID_TxtBox.Text),
                PromotionCode_TxtBox.Text, Convert.ToInt32(PromotionPercent_TxtBox.Text), Convert.ToInt32(PromotionStatus_True.Checked));

            if(value == 1)
            {
                Page_Load(sender, e);
            }
        }
    }

    protected void SearchData_btn_Click(object sender, EventArgs e)
    {
        if (SearchPromotion_TxtBox.Text != "")
        {
            Promotion Promotion = ConnectionClass.SelectPromotion(Convert.ToInt32(SearchPromotion_TxtBox.Text));
            if (Promotion != null)
            {
                PromotionID_TxtBox.Text = Promotion.Promotion_ID.ToString();
                PromotionCode_TxtBox.Text = Promotion.Promotion_CodeName;
                PromotionPercent_TxtBox.Text = Promotion.Promotion_Percent.ToString();
                PromotionStatus_True.Checked = false;
                PromotionStatus_False.Checked = false;

                if (Promotion.Promotion_ActiveStatus == 1)//Check PromotionStatus
                {
                    PromotionStatus_True.Checked = true;
                    PromotionStatus_False.Checked = false;
                }
                else if (Promotion.Promotion_ActiveStatus == 0)
                {
                    PromotionStatus_True.Checked = false;
                    PromotionStatus_False.Checked = true;
                }
                else
                {
                    PromotionStatus_True.Checked = false;
                    PromotionStatus_False.Checked = false;
                }
            }


        }

    }

    protected void PromotionStatus_False_CheckedChanged(object sender, EventArgs e)
    {
        PromotionStatus_Checkbox();
    }

    protected void PromotionStatus_True_CheckedChanged(object sender, EventArgs e)
    {
        PromotionStatus_Checkbox();
    }
}