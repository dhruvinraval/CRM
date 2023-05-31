using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class country : BusinessObject
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
        
        private string _CountryName;
        [Required(ErrorMessage = "Enter Country Name")]
        [StringLength(100, MinimumLength = 3 )]
        public string CountryName
        {
            get     { return _CountryName; }
            set { _CountryName = value; }
        }
        
        public country() { }
        private country(DataRow row) : base(row) { }
        public static country Create(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_country_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new country(dt.Rows[0]);
            return null;
        }
        public static country Create(DataRow row)
        {
            if (row != null)
                return new country(row);
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
                if (row.Table.Columns.Contains("CountryName"))
                    _CountryName = row["CountryName"].ToString();
            }
        }
        public static country GetByID(int? SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_country_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new country(dt.Rows[0]);
            return null;
        }

        public int country_insertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_country_insertupdate",
            "p_SrNo", _SrNo, "p_CountryName", _CountryName));
            return result;
        }
        public static List<country> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_country_getall");
            return CreateListFromTable<country>(dt);
        }
        
        public static List<country> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_country_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<country>(dt);
        }
        public static void CountryDelete(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_country_delete", "p_SrNo", SrNo);
        }
    }

    
}
