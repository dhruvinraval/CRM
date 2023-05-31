using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class ContactUs : BusinessObject
    {
        private int _disID;
        public int DisID
        {
            get { return _disID; }
            set { _disID = value; }
        }
        private int? _SrNo;
        public int? SrNo
        {
            get { return _SrNo; }
            set { _SrNo = value; }
        }

        public string _Name;
        [Required(ErrorMessage = "Enter Name")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        public string _ContactNo;
        [Required(ErrorMessage = "Enter Contact No")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Contact No must be 10 digits")]
        [RegularExpression(@"^[0-9]*(?:\.[0-9]*)?$", ErrorMessage = "Only Numeric Values are Allowed for e.g : 123456")]
        public string ContactNo
        {
            get { return _ContactNo; }
            set { _ContactNo = value; }
        }

        public string _Email;
        
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }


        public string _Subject;
        [Required(ErrorMessage = "Enter Subject")]
        public string Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }

        public string _Remarks;
        
        public string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }



        public ContactUs() { }
        private ContactUs(DataRow row) : base(row) { }
        public static ContactUs Create(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_contactus_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new ContactUs(dt.Rows[0]);
            return null;
        }
        public static ContactUs Create(DataRow row)
        {
            if (row != null)
                return new ContactUs(row);
            return null;
        }

        //public string CountryName { get; set; }
        protected override void Load(DataRow row)
        {
            if (row != null)
            {
                if (row.Table.Columns.Contains("disid"))
                    _disID = (int)row["disid"];
                if (row.Table.Columns.Contains("SrNo"))
                    _SrNo = (int)row["SrNo"];
                if (row.Table.Columns.Contains("Name"))
                    _Name = row["Name"].ToString();
                if (row.Table.Columns.Contains("ContactNo"))
                    _ContactNo = row["ContactNo"].ToString();
                if (row.Table.Columns.Contains("Email"))
                    _Email = row["Email"].ToString();
                if (row.Table.Columns.Contains("Subject"))
                    _Subject = row["Subject"].ToString();
                if (row.Table.Columns.Contains("Remarks"))
                    _Remarks = row["Remarks"].ToString();

            }
        }
        public static ContactUs GetByID(int? SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_contactus_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new ContactUs(dt.Rows[0]);
            return null;
        }

        public int contactus_insertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_contactus_insertupdate",
            "p_SrNo", _SrNo, "p_Name", _Name, "p_ContactNo", _ContactNo, "p_Email",_Email,"p_Subject",_Subject,"p_Remarks",_Remarks));
            return result;
        }
        public static List<ContactUs> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_contactus_getall");
            return CreateListFromTable<ContactUs>(dt);
        }

        public static List<ContactUs> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_contactus_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<ContactUs>(dt);
        }
        public static void contactusDelete(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_contactus_delete", "p_SrNo", SrNo);
        }
    }
}
