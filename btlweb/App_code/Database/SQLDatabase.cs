//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data;
//using System.Data.OleDb;

//namespace btlweb
//{
//    public class SQLDatabase
//    {
//        private static string constr = String.Empty;
//        public static string ConnectionString
//        {
//            get { return constr; }  
//            set { constr = value; }
//        }
//        //Khởi tạo đối tượng OLeDB chứa chuỗi kết nối
//        public static OleDbConnection GetConnection()
//        {
//            OleDbConnection conn = new OleDbConnection();
//            conn.ConnectionString = constr;
//            conn.Open();
//            return conn;
//        }
//        //trả về câu truy vấn không cần trả về kết quả vd như delete, 
//        public static void ExcuteNoneQuery(OleDbCommand cmd)
//        {
//            if(cmd.Connection == null)
//            {
//                using(da)
//            }
//        }
//    }

//}