using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Model
{
    public class Users
    {
        //Fields
        public string userID;
        public string name;
        public string email;
        public string phone;
        public string address;
        public string birthday;
        public string sex;
        public string position;
        public int deal_salary;
        public string username;
        public string password;
        public string contract_type;
        public string on_boarding;
        public string close_date;
        public string scan_contract;
        public string note;
        public string ava;
        public string status;
        

        //properties

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }

        }
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public int Deal_salary
        {
            get { return deal_salary; }
            set { deal_salary = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Contract_type
        {
            get { return contract_type; }
            set { contract_type = value; }
        }
        public string On_boarding
        {
            get { return on_boarding; }
            set { on_boarding = value; }
        }
        public string Close_date
        {
            get { return close_date; }
            set { close_date = value; }
        }
        public string Scan_contract
        {
            get { return scan_contract; }
            set { scan_contract = value; }
        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        public string Ava
        {
            get { return ava; }
            set { ava = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }



    }
}
