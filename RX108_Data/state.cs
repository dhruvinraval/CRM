using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class state : BusinessObject
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
        //[Required(ErrorMessage = "Enter Country Name")]
        public int _Mst_Country_SrNo;
        [Required(ErrorMessage = "Select Country Name")]
        
        public int Mst_Country_SrNo
        {
            get { return _Mst_Country_SrNo; }
            set { _Mst_Country_SrNo = value; }
        }
        private string _StateName;
        [Required(ErrorMessage = "Enter State Name")]
        [StringLength(100, MinimumLength = 3)]
        public string StateName
        {
            get { return _StateName; }
            set { _StateName = value; }
        }

        public state() { }
        private state(DataRow row) : base(row) { }
        public static state Create(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_state_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new state(dt.Rows[0]);
            return null;
        }
        public static state Create(DataRow row)
        {
            if (row != null)
                return new state(row);
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
                if (row.Table.Columns.Contains("Mst_Country_SrNo"))
                    _Mst_Country_SrNo = (int)row["Mst_Country_SrNo"];
                if (row.Table.Columns.Contains("StateName"))
                    _StateName = row["StateName"].ToString();
            }
        }
        public static state GetByID(int? SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_state_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new state(dt.Rows[0]);
            return null;
        }

        public int state_insertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_state_insertupdate",
            "p_SrNo", _SrNo, "p_Mst_Country_SrNo", _Mst_Country_SrNo, "p_StateName", _StateName));
            return result;
        }
        public static List<state> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_state_getall");
            return CreateListFromTable<state>(dt);
        }

        public static List<state> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_state_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<state>(dt);
        }
        public static void stateDelete(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_state_delete", "p_SrNo", SrNo);
        }

    }
}
