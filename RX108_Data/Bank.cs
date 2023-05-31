using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class Bank : BusinessObject
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


        private string _BankName;
        [Required(ErrorMessage = "Enter Bank Name")]
        [StringLength(100, MinimumLength = 3)]
        public string BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }

        public Bank() { }
        private Bank(DataRow row)
        {
            Load(row);
        }
        public static Bank Create(DataRow row)
        {
            if (row != null)
                return new Bank(row);
            return null;
        }

        protected override void Load(DataRow row)
        {
            if (row != null)
            {
                if (row.Table.Columns.Contains("disid"))
                    _disID = (int)row["disid"];
                if (row.Table.Columns.Contains("SrNo"))
                    _SrNo = (int)row["SrNo"];
                if (row.Table.Columns.Contains("BankName"))
                    _BankName = (string)row["BankName"];
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_bank_insertupdate", "p_SrNo", _SrNo, "p_BankName", _BankName));
            return result;
        }

        public static List<Bank> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_bank_getall");
            return CreateListFromTable<Bank>(dt);
        }

        public static List<Bank> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_bank_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<Bank>(dt);
        }

        public static Bank GetById(int? srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_bank_getbyid", "p_SrNo", srnopass);
            if (dt.Rows.Count > 0)
                return new Bank(dt.Rows[0]);
            return null;
        }

        public static void BankDelete(int srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_bank_delete", "p_SrNo", srnopass);
        }

    }
}
