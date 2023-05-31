using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class Feedback : BusinessObject
    {
        private int _disID;
        public int DisID
        {
            get { return _disID; }
            set { _disID = value; }
        }
        [Key]
        private int? _SrNo;
        public int? SrNo
        {
            get { return _SrNo; }
            set { _SrNo = value; }
        }

        private string _FirstName;
        [Required(ErrorMessage = "Enter First Name")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private string _LastName;
        [Required(ErrorMessage = "Enter Last Name")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        private string _Email;
        [Required(ErrorMessage = "Enter Email")]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _Suggestion;
        [Required(ErrorMessage = "Check Suggestion for")]
        public string Suggestion
        {
            get { return _Suggestion; }
            set { _Suggestion = value; }
        }
        private string _Subject;
        [Required(ErrorMessage = "Enter Subject")]
        public string Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }
        private string _Message;
        [Required(ErrorMessage = "Enter Message")]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
        public Feedback() { }
        private Feedback(DataRow row) : base(row) { }
        public static Feedback Create(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_feedback_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new Feedback(dt.Rows[0]);
            return null;
        }
        public static Feedback Create(DataRow row)
        {
            if (row != null)
                return new Feedback(row);
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
                if (row.Table.Columns.Contains("FirstName"))
                    _FirstName = row["FirstName"].ToString();
                if (row.Table.Columns.Contains("LastName"))
                    _LastName = row["LastName"].ToString();
                if (row.Table.Columns.Contains("Email"))
                    _Email = row["Email"].ToString();
                if (row.Table.Columns.Contains("Suggestion"))
                    _Suggestion = row["Suggestion"].ToString();
                if (row.Table.Columns.Contains("Subject"))
                    _Subject = row["Subject"].ToString();
                if (row.Table.Columns.Contains("Message"))
                    _Message = row["Message"].ToString();
            }
        }

        public static Feedback GetByID(int? SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_feedback_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new Feedback(dt.Rows[0]);
            return null;
        }

        public int Feedback_insertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_feedback_insertupdate",
            "p_SrNo", _SrNo, "p_FirstName", _FirstName,"p_LastName",_LastName,"p_Email",_Email, "p_Suggestion", _Suggestion, "p_Subject",_Subject,"p_Message",_Message));
            return result;
        }
        public static List<Feedback> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_feedback_getall");
            return CreateListFromTable<Feedback>(dt);
        }

        public static List<Feedback> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_feedback_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<Feedback>(dt);
        }
        public static void FeedbackDelete(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_feedback_delete", "p_SrNo", SrNo);
        }
    }
}
