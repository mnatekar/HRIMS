using System;
using System.Collections.Generic;
using System.Text;
using Dev.A4;
using Dev.A4.Enums;
using Dev.A4.Exceptions;
using Dev.A4.General;
using Dev.A4.Interfaces;
using Dev.A4.Internal;
using Dev.A4.Storages;
using Dev.A4.DataTypes;
using System.Data;
using System.Data.SqlClient;
        {           
            List<SqlParameter> a = new List<SqlParameter>();
            a.Add(new SqlParameter("@LoginID", SqlDbType.Int));
            a[a.Count - 1].Value = LoginID;
            oDB.CallSPROC("uspUpdateManagerFlag", a);
            return "";
        }
        public static string updateManagerReviewRating(int LoginID)
        {
            List<SqlParameter> a = new List<SqlParameter>();
            a.Add(new SqlParameter("@LoginID", SqlDbType.Int));
            a[a.Count - 1].Value = LoginID;
            oDB.CallSPROC("uspUpdateManagerFlag", a);
            return "";
        }