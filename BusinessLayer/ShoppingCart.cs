﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using ShoppingHeart.BusinessLayer;
using System.Web.UI.WebControls;

namespace ShoppingHeart.BusinessLayer
{
    public class ShoppingCart
    {
        public string CategoryName;
        public int CategoryID;

        public string ProductName;
        public string ProductImage;
        public string ProductPrice;
        public string ProductDescription;

        public void AddNewCategory()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = DataLayer.DataAccess.AddParamater("@CategoryName", CategoryName, System.Data.SqlDbType.VarChar, 200);
            DataTable dt = DataLayer.DataAccess.ExecuteDTByProcedure("SP_AddNewCategory", parameters);
        }

        public void AddNewProduct()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = DataLayer.DataAccess.AddParamater("@ProductName", ProductName, System.Data.SqlDbType.VarChar, 300);
            parameters[1] = DataLayer.DataAccess.AddParamater("@ProductPrice", ProductPrice, System.Data.SqlDbType.Int, 100);
            parameters[2] = DataLayer.DataAccess.AddParamater("@ProductImage", ProductPrice, System.Data.SqlDbType.VarChar, 500);
            parameters[3] = DataLayer.DataAccess.AddParamater("@ProductDescrition", ProductPrice, System.Data.SqlDbType.VarChar, 1000);
            parameters[4] = DataLayer.DataAccess.AddParamater("@ProductID", ProductPrice, System.Data.SqlDbType.Int, 100);

            DataTable dt = DataLayer.DataAccess.ExecuteDTByProcedure("SP_AddNewProduct", parameters);
        }
        public DataTable GetCategories()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = DataLayer.DataAccess.ExecuteDTByProcedure("SP_GetAllCategories", parameters);
            return dt; 
             
        }
    }
}