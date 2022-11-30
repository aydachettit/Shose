using Shoes.DAL;
using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.BLL
{
    internal class adddetailBLL
    {
        private static adddetailBLL instance;
        public static adddetailBLL Instance
        {
            get
            {
                if (instance == null) instance = new adddetailBLL();
                return instance;
            }
            private set { instance = value; }
        }
        private adddetailBLL() { }

        public List<adddetailDTO> getadddetaillist(string ID)
        {
            List<adddetailDTO> list = new List<adddetailDTO>();
            List<adddetailDTO> list0 = adddetailDAL.Instance.getNotedetailList();
            foreach (adddetailDTO item in list0)
            {
                if (ID == item.NotedetailId)
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public int insertdetail(string noteid, string productid, string productname, int productamount, float productprice, int quantity)
        {
            return adddetailDAL.Instance.insertnotedetail(noteid, productid, productname, productamount, productprice, quantity);
        }
        public int deletedetail(string noteid, string productid)
        {
            return adddetailDAL.Instance.deletenotedetail(noteid, productid);
        }
        public int updatetoshoes(string productid, float price)
        {
            return adddetailDAL.Instance.updatepricetoshoes(productid, price);
        }
        public string getproductname(string productid)
        {
            return adddetailDAL.Instance.getProductname(productid);
        }
        public int getproductamount(string productid)
        {
            return adddetailDAL.Instance.getProductAmount(productid);
        }
        public int getproductidcount(string id)
        {
            return adddetailDAL.Instance.getnumproductid(id);
        }
        public float gettotalhd(string id)
        {
            return adddetailDAL.Instance.getProductSUMPRICE(id);
        }
        public int checknotedetailid(string notedetailid)
        {
            if (notedetailid.StartsWith("NID"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void checkinsert(string id)
        {

        }
    }
}
