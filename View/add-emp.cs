using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HRMngt.View
{
    public partial class add_emp : Form, IUserview
    {

        //Properties
        public string userID {
            get { return txtId.Text; }
            set { txtId.Text = value; }
            }
            
        public string name { 
            get { return txtHoten.Text; }
            set { txtHoten.Text = value; }
        }
        public string email { 
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string phone
        {
            get { return txtSodienthoai.Text; } 
            set { txtSodienthoai.Text = value; }
        }
        public string address { 
            get { return txtDiachi.Text; }

            set { txtDiachi.Text = value; }

        }
        public string birthday
        {
            get { return txtNgaysinh.Text; }
            set { txtNgaysinh.Text = value;}
        }
        public string sex
        {
            get { return txtGioitinh.Text; }
            set { txtGioitinh.Text = value; }
        }
        public string position
        {
            get { return txtVitri.Text; }
            set { txtVitri.Text = value; }
        }
        public int deal_salary {
            get { return Convert.ToInt32(txtLuong.Text); }
            set { txtLuong.Text = value.ToString(); }
        }
        public string username { get { return txtTendangnhap.Text; }  set { txtTendangnhap.Text = value; } }
        public string password { get { return txtMatkhau.Text; } set { txtMatkhau.Text = value; } }
        public string contract_type { get { return txtLoaihopdong.Text; } set { txtLoaihopdong.Text = value; } }
        public string on_boarding { get { return txtOnBoard.Text; } set { txtOnBoard.Text = value; } }
        public string close_date { get { return txtNgayhethan.Text; } set { txtNgayhethan.Text = value; } }
        public string scan_contract { get { return txtHopdongscan.Text; } set { txtHopdongscan.Text = value; } }
        public string note { get { return txtGhichu.Text; } set { txtGhichu.Text = value; } }
        public string ava { get { return avatar.Text; } set { avatar.Text = value; } }
        public string status { get { return txtTrangthai.Text; } set { txtTrangthai.Text = value; } }

        public add_emp()
        {
            InitializeComponent();

        }


        //Event
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void txtNavSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNavSearch.Text == "Nhập tìm kiếm của bạn ...")
            {
                txtNavSearch.Text = "";
                txtNavSearch.ForeColor = Color.Black;
            }

        }

        private void txtNavSearch_Leave(object sender, EventArgs e)
        {
            if (txtNavSearch.Text == "")
            {
                txtNavSearch.Text = "Nhập tìm kiếm của bạn ...";
                txtNavSearch.ForeColor = Color.Black;
            }
        }

        //Method
        public void SetUserListBindingSource(BindingSource userList)
        {
            throw new NotImplementedException();
        }
    }
}
