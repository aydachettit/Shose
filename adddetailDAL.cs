using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DAL
{
    internal class adddetailDAL
    {
        private static adddetailDAL instance;
        public static adddetailDAL Instance
        {
            get
            {
                if(instance == null) instance = new adddetailDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private adddetailDAL() { }

        public List<adddetailDTO> getNotedetailList()
        {
            List<adddetailDTO> list = new List<adddetailDTO>();
            string query = "SELECT * FROM importnotedetail";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                adddetailDTO notedetail = new adddetailDTO(item);
                list.Add(notedetail);
            }

            return list;
        }
        public int getnumproductid(string id)
        {
            int num = 0;
            List<adddetailDTO> list = new List<adddetailDTO>();
            string query = "SELECT DISTINCT ProductID FROM importnotedetail WHERE ImportNoteID = '"+id+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                num++;
            }
            return num;
        }
        public string getProductname(string id)
        {
            string query = "SELECT ProductName FROM shoes WHERE ProductID ='" + id + "'";
            DataTable Data = DataProvider.Instance.ExecuteQuery(query);
            string name = "";
            foreach(DataRow item in Data.Rows)
            {
                name = item["ProductName"].ToString();
            }
            return name;
        }
        public int getProductAmount(string id)
        {
            string query = "SELECT ProductAmount FROM shoes WHERE ProductID ='" + id + "'";
            DataTable Data = DataProvider.Instance.ExecuteQuery(query);
            int num = 0;
            foreach (DataRow item in Data.Rows)
            {
                num = Convert.ToInt32(item["ProductAmount"]);
            }
            return num;
        }
        public float getProductSUMPRICE(string id)
        {
            string query = "SELECT SUM(ImportPrice) AS SUMPRICE FROM importnotedetail GROUP BY ImportNoteID HAVING ImportNoteID ='" + id + "'";
            DataTable Data = DataProvider.Instance.ExecuteQuery(query);
            float num = 0;
            foreach (DataRow item in Data.Rows)
            {
                num += float.Parse(item["SUMPRICE"].ToString());
            }
            return num;
        }
        public int updatepricetoshoes(string productid,float importprice)
        {
            return DataProvider.Instance.ExecuteNonQuery("UPDATE shoes SET ProductPrice = "+importprice+" WHERE ProductID ='"+productid+"'");
        }
        public int insertnotedetail(string notedetailid,string productid,string productname,int productamount,float importprice,int importquantity)
        {
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO importnotedetail VALUES('"+notedetailid+"','"+productid+"', N'"+productname+"',"+productamount+","+importprice+","+importquantity+")");
        }
        public int deletenotedetail(string notedetailid,string productid)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM importnotedetail WHERE ImportNoteID ='"+notedetailid+"' AND ProductID ='"+productid+"'");
        }
        
        
    }   
}
