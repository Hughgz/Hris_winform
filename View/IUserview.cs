using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.View
{
    public interface IUserview
    {
        //Properties - Fields
        string userID { get; set; }
        string name { get; set; }
        string email { get; set; }
        string phone { get; set; }    
        string address { get; set; }
        string birthday { get; set; }
        string sex { get; set; }
        string position { get; set; }
        int deal_salary { get; set; }
        string username { get; set; }
        string password { get; set; }
        string contract_type { get; set; }
        string on_boarding { get; set; }
        string close_date { get; set; }
        string scan_contract { get; set; }
        string note { get; set; }
        string ava { get; set; }
        string status { get; set; }

        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetUserListBindingSource(BindingSource userList);
        void Show();
        
    }
}
