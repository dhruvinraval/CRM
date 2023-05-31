using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class complain: BusinessObject
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

        public string _Place;
        [Required(ErrorMessage = "Enter Place")]
        public string Place
        {
            get { return _Place; }
            set { _Place = value; }
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

        public string _Problem;
        [Required(ErrorMessage = "Enter Problem")]
        public string Problem
        {
            get { return _Problem; }
            set { _Problem = value; }
        }


        public string _SoftwareName;
        [Required(ErrorMessage = "Enter Software Name")]
        public string SoftwareName
        {
            get { return _SoftwareName; }
            set { _SoftwareName = value; }
        }

        public complain() { }
        private complain(DataRow row) : base(row) { }
        public static complain Create(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_complain_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new complain(dt.Rows[0]);
            return null;
        }
        public static complain Create(DataRow row)
        {
            if (row != null)
                return new complain(row);
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
                if (row.Table.Columns.Contains("Place"))
                    _Place = row["Place"].ToString();
                if (row.Table.Columns.Contains("ContactNo"))
                    _ContactNo = row["ContactNo"].ToString();
                if (row.Table.Columns.Contains("Problem"))
                    _Problem = row["Problem"].ToString();
                if (row.Table.Columns.Contains("SoftwareName"))
                    _SoftwareName = row["SoftwareName"].ToString();

            }
        }
        public static complain GetByID(int? SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_complain_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new complain(dt.Rows[0]);
            return null;
        }

        public int complain_insertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_complain_insertupdate",
            "p_SrNo", _SrNo, "p_Name", _Name, "p_Place",_Place,"p_ContactNo",_ContactNo, "p_SoftwareName", _SoftwareName, "p_Problem",_Problem));
            return result;
        }
        public static List<complain> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_complain_getall");
            return CreateListFromTable<complain>(dt);
        }

        public static List<complain> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_complain_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<complain>(dt);
        }
        public static void complainDelete(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_complain_delete", "p_SrNo", SrNo);
        }

    }
}
