using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class DocTag : BusinessObject
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

        private string _DocTagName;
        [Required(ErrorMessage = "Enter Document Tag Name")]
        [StringLength(100, MinimumLength = 3)]
        public string DocTagName
        {
            get { return _DocTagName; }
            set { _DocTagName = value; }
        }

        public DocTag() { }
        private DocTag(DataRow row)
        {
            Load(row);
        }
        public static DocTag Create(DataRow row)
        {
            if (row != null)
                return new DocTag(row);
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
                if (row.Table.Columns.Contains("DocTagName"))
                    _DocTagName = (string)row["DocTagName"];
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_doctag_insertupdate", "p_SrNo", _SrNo, "p_DocTagName", _DocTagName));
            return result;
        }

        public static List<DocTag> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_doctag_getall");
            return CreateListFromTable<DocTag>(dt);
        }

        public static List<DocTag> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_doctag_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<DocTag>(dt);
        }

        public static DocTag GetById(int? srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_doctag_getbyid", "p_SrNo", srnopass);
            if (dt.Rows.Count > 0)
                return new DocTag(dt.Rows[0]);
            return null;
        }

        public static void DocTagDelete(int srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_doctag_delete", "p_SrNo", srnopass);
        }


    }
}
