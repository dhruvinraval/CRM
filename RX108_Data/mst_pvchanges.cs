using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class mst_pvchanges:BusinessObject
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


        private int _Mst_ProductVerSrNo;
        [Required(ErrorMessage = "Select Product version")]
        public int Mst_ProductVerSrNo
        {
            get { return _Mst_ProductVerSrNo; }
            set { _Mst_ProductVerSrNo = value; }
        }

        private int _Mst_Product_Module_SrNo;
        [Required(ErrorMessage = "Select Product Module")]
        public int Mst_Product_Module_SrNo
        {
            get { return _Mst_Product_Module_SrNo; }
            set { _Mst_Product_Module_SrNo = value; }
        }



        private string _WhatChanges;
        [Required(ErrorMessage = "Enter Product Version Changes")]
        [StringLength(250, MinimumLength = 3)]
        public string WhatChanges
        {
            get { return _WhatChanges; }
            set { _WhatChanges = value; }
        }

        private int _VideoLink;
        public int VideoLink
        {
            get { return _VideoLink; }
            set { _VideoLink = value; }
        }

        private string _Remark;
        [StringLength(250)]
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        public mst_pvchanges() { }
        private mst_pvchanges(DataRow row) : base(row) { }
        protected override void Load(DataRow row)
        {
            if (row != null)
            {
                if (row.Table.Columns.Contains("disid"))
                    _disID = (int)row["disid"];
                if (row.Table.Columns.Contains("SrNo"))
                    _SrNo = (int)row["SrNo"];
                if (row.Table.Columns.Contains("Mst_ProductVerSrNo"))
                    _Mst_ProductVerSrNo = Convert.ToInt32(row["Mst_ProductVerSrNo"]);
                if (row.Table.Columns.Contains("Mst_Product_Module_SrNo"))
                    _Mst_Product_Module_SrNo = Convert.ToInt32(row["Mst_Product_Module_SrNo"]);
                if (row.Table.Columns.Contains("WhatChanges"))
                    _WhatChanges = row["WhatChanges"].ToString();
                if (row.Table.Columns.Contains("VideoLink"))
                    _VideoLink = int.Parse(Convert.ToString(row["VideoLink"]));
                if (row.Table.Columns.Contains("Remark"))
                    _Remark = row["Remark"].ToString();
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway dbg = new DatabaseGateway();    
            object[] obj = { "p_SrNo", SrNo, "p_Mst_ProductVerSrNo", Mst_ProductVerSrNo, "p_Mst_Product_Module_SrNo", Mst_Product_Module_SrNo, "p_WhatChanges", WhatChanges, "p_VideoLink", VideoLink, "p_Remark", Remark };
            return Convert.ToInt32(dbg.ExecuteScalar("proc_mst_pvchanges_insertupdate", obj));
        }

        public static List<mst_pvchanges> GetAll(int pgno, int rpp, int? sort, ref int total, string search)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "keyword", search, "sortorder", sort };
            DataTable dt = dbg.QueryForDataTablePaged("proc_mst_pvchanges_getall", pgno, rpp, out total, obj);
            return CreateListFromTable<mst_pvchanges>(dt);
        }
        public static List<mst_pvchanges> GetAll()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            DataTable dt = dbg.QueryForDataTable("proc_mst_pvchanges_getall");
            return CreateListFromTable<mst_pvchanges>(dt);
        }

        public static mst_pvchanges GetByID(int? srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            DataTable dt = dbg.QueryForDataTable("proc_mst_pvchanges_getbyid", obj);
            if (dt.Rows.Count > 0)
            {
                return new mst_pvchanges(dt.Rows[0]);
            }
            return null;
        }

        public static int Delete(int srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            return dbg.ExecuteNonQuery("proc_mst_pvchanges_delete", obj);

        }

    }
}
