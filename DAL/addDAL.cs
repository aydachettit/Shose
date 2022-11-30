using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Shoes.DTO;

namespace Shoes.DAL
{
    internal class addDAL
    {
        private static addDAL instance;
        public static addDAL Instance
        {
            get
            {
                if(instance == null) instance = new addDAL();
                return instance;
            }
            private set { instance = value; }
        }
        private addDAL() { }

        public List<addDTO> getaddList()
        {
            List<addDTO> list = new List<addDTO> ();

            string query = "SELECT * from importnote";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                addDTO add = new addDTO(row);
                list.Add(add);
            }

            return list;
        }
        public int insertadd(string NoteId,string supplierId,string date)
        {
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO importnote VALUES('"+NoteId+"', '"+supplierId+"','"+date+"') ");
        }
        public int updateadd(string NoteId,string supplierId,string date)
        {
            return DataProvider.Instance.ExecuteNonQuery("UPDATE importnote SET SupplierID = '"+supplierId+"', ImportDate = '"+date+"' WHERE ImportNoteID = '"+NoteId+"'");
        }
        public int deleteadd(string NoteId)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM importnote WHERE ImportNoteID = '"+NoteId+"'");
        }

        public string getnumsupplierid()
        {
            string query = "SELECT DISTINCT SupplierID FROM importnote";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int count = data.Rows.Count;
            return count.ToString();
        }
        public void checkinsertadd(string NoteId,string supplierId,string date)
        {
            string query = "SELECT DISTINCT SupplierID FROM supplier";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int count = data.Rows.Count;
            if (count > 0)
            {
                insertadd(NoteId, supplierId, date);
            }
            else
            {
                MessageBox.Show("Chưa có nhà cung cấp!");
            }
        }
        public void checkupdateadd(string NoteId,string supplierId,string date)
        {
            int flag = 0;
            string query = "SELECT DISTINCT SupplierID FROM supplier";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                if (supplierId == row["SupplierID"].ToString())
                {
                    updateadd(NoteId,supplierId,date);
                    flag = 1;
                    break;
                }
            } 
            
            if(flag == 0)
            {
                MessageBox.Show("Nhà cung cấp này hiện chưa có!");
            }

        }
    }
}
