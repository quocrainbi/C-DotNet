using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiDotNet.DTO;

namespace ThiDotNet.DAO
{
    public class Menu1DAO
    {
        private static Menu1DAO instance;

        public static Menu1DAO Instance
        {
            get { if (instance == null) instance = new Menu1DAO(); return Menu1DAO.instance; }
            private set { Menu1DAO.instance = value; }
        }

        private Menu1DAO() { }

        public List<Menu1> GetListMenuByTable(int id)
        {
            List<Menu1> listMenu = new List<Menu1>();

            string query = "SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu1 menu = new Menu1(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
