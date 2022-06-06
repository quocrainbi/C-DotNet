using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiDotNet.DAO;
using ThiDotNet.DTO;

namespace ThiDotNet.View
{
    public partial class fAdmin : Form
    {
        BindingSource foodlist = new BindingSource();
        BindingSource categorylist = new BindingSource();

        public fAdmin()
        {
            InitializeComponent();

            Load();
        }
        void LoadListBillByDate(DateTime checkin, DateTime checkout)
        {
            dgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkin, checkout);
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        #region Method

        // PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
            return listFood;
        }
        void LoadFoodList()
        {
            foodlist.DataSource = FoodDAO.Instance.GetFoodList();
        }
        void AddFoodBinding()
        {
            txbNameFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbPriceFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryIntoCb(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void Load()
        {
            dgvFood.DataSource = foodlist;
            dgvCategory.DataSource = categorylist;

            LoadFoodList();
            LoadCategoryIntoCb(cbCategoryAdmin);
            AddFoodBinding();


            LoadCategoryList();
            AddCategoryBinding();
        }

        void LoadCategoryList()
        {
            categorylist.DataSource = CategoryDAO.Instance.GetCategoryList();
        }
        void AddCategoryBinding()
        {
            txbNameCategory.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }
        List<Category> SearchCategoryByName(string name)
        {
            List<Category> listFood = CategoryDAO.Instance.SearchCategoryByName(name);
            return listFood;
        }

        #endregion

        #region Event
        private void bntShowFood_Click(object sender, EventArgs e)
        {
            LoadFoodList();
        }

        private void txbNameFood_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFood.SelectedCells.Count > 0 && dgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value != null)
                {
                    int id = (int)dgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    cbCategoryAdmin.SelectedItem = category;
                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbCategoryAdmin.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbCategoryAdmin.SelectedIndex = index;
                }
            }
            catch { }

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbNameFood.Text;
            int ctgid = (cbCategoryAdmin.SelectedItem as Category).ID;
            float price = float.Parse(txbPriceFood.Text);

            if (FoodDAO.Instance.InsertFood(name, ctgid, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadFoodList();
                if (insertFood != null)
                {
                    insertFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            int foodid = (int)dgvFood.CurrentRow.Cells["id"].Value;
            string name = txbNameFood.Text;
            int ctgid = (cbCategoryAdmin.SelectedItem as Category).ID;
            float price = float.Parse(txbPriceFood.Text);

            if (FoodDAO.Instance.UpdateFood(foodid, name, ctgid, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadFoodList();
                if (updateFood != null)
                {
                    updateFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void bntSearchFood_Click(object sender, EventArgs e)
        {
            foodlist.DataSource = SearchFoodByName(txbSearchFood.Text);
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int foodid = (int)dgvFood.CurrentRow.Cells["id"].Value;
            if (FoodDAO.Instance.DeleteFood(foodid))
            {
                MessageBox.Show("Xóa món thành công");
                LoadFoodList();
                if (deleteFood != null)
                {
                    deleteFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }


        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadCategoryList();
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbNameCategory.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm category thành công");

                LoadCategoryList();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int ctgid = (int)dgvCategory.CurrentRow.Cells["id"].Value;
            string name = txbNameCategory.Text;

            if (CategoryDAO.Instance.UpdateCategory(ctgid, name))
            {
                MessageBox.Show("Sửa category thành công");

                LoadCategoryList();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int ctgid = (int)dgvCategory.CurrentRow.Cells["id"].Value;
            if (CategoryDAO.Instance.DeleteCategory(ctgid))
            {
                MessageBox.Show("Xóa category thành công");
                LoadCategoryList();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            categorylist.DataSource = SearchCategoryByName(txbSearchCategory.Text);
        }
        #endregion


    }
}
