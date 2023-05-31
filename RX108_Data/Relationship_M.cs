using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class Relationship_M : BusinessObject
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

        private string _Relationship;
        [Required(ErrorMessage = "Enter Relationship")]
        [StringLength(100, MinimumLength = 3)]
        public string Relationship
        {
            get { return _Relationship; }
            set { _Relationship = value; }
        }

        public Relationship_M() { }
        private Relationship_M(DataRow row)
        {
            Load(row);
        }
        public static Relationship_M Create(DataRow row)
        {
            if (row != null)
                return new Relationship_M(row);
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
                if (row.Table.Columns.Contains("Relationship"))
                    _Relationship = (string)row["Relationship"];
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_relationship_insertupdate", "p_SrNo", _SrNo, "p_Relationship", _Relationship));
            return result;
        }

        public static List<Relationship_M> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_relationship_getall");
            return CreateListFromTable<Relationship_M>(dt);
        }

        public static List<Relationship_M> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_relationship_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<Relationship_M>(dt);
        }

        public static Relationship_M GetById(int? srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_relationship_getbyid", "p_SrNo", srnopass);
            if (dt.Rows.Count > 0)
                return new Relationship_M(dt.Rows[0]);
            return null;
        }

        public static void RelationshipDelete(int srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_relationship_delete", "p_SrNo", srnopass);
        }
    }
}
