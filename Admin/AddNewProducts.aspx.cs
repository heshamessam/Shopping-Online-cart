using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ShoppingHeart.BusinessLayer;

namespace ShoppingHeart.Admin
{
    public partial class AddNewProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
              if(!IsPostBack)
            {
                GetCategories();
            }
        }

        private void GetCategories()
        {
            ShoppingCart k = new ShoppingCart();
            DataTable dt = k.GetCategories();
            if(dt.Rows.Count > 0)
            {
                ddlCategory.DataValueField = "CategoryID";
                ddlCategory.DataTextField = "CategoryName";
                ddlCategory.DataSource = dt;
                ddlCategory.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(uploadProductPhoto.PostedFile != null)
            {
                SaveProductPhoto();

                ShoppingCart k = new ShoppingCart
                {
                    ProductName = txtProductName.Text,
                    ProductImage = "~/ProductImages/" + uploadProductPhoto.FileName,
                    ProductPrice = txtProductPrice.Text,
                    ProductDescription = txtProductDescription.Text,
                    CategoryID = Convert.ToInt32(ddlCategory.SelectedValue)
                };
                k.AddNewProduct();
                ClearText();
            }
            else
            {

            }
        }
        private void ClearText()
        {
            txtProductName.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
        }

        private void SaveProductPhoto()
        {
            if (uploadProductPhoto.PostedFile != null)
            {
                string filename = uploadProductPhoto.PostedFile.FileName.ToString();
                string fileExt = System.IO.Path.GetExtension(uploadProductPhoto.FileName);

                if (filename.Length > 96)
                {
                    //Alert.Show("image name should not exceed 96 characters !");
                }

                else if (fileExt != ".jpeg" && fileExt != ".png" && fileExt != ".jpg")
                {

                    //Alert.Show("JPEG,PNG and JPEG are Allowed");

                }
                else if (uploadProductPhoto.PostedFile.ContentLength > 400000)
                {
                    //Alert.Show("size should be not greater than 4MB");
                }
                else
                {
                    uploadProductPhoto.SaveAs(Server.MapPath("~/ProductImages/" + filename));
                }
            }
        }
    }
}