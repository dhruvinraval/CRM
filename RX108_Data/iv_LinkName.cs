using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class iv_LinkName : BusinessObject
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

        private char _ImgOrVideo;
        [Required(ErrorMessage = "Check For Image Or Video")]
        public char ImgOrVideo
        {
            get { return _ImgOrVideo; }
            set { _ImgOrVideo = value; }
        }

        private string _BriefName;
        [Required(ErrorMessage = "Enter Name Of Image Or video")]
        [StringLength(100, MinimumLength = 3)]
        public string BriefName
        {
            get { return _BriefName; }
            set { _BriefName = value; }
        }

        private string _ImgVideoPath;
        [Required(ErrorMessage = "Enter Video or Image Path")]
        [StringLength(100, MinimumLength = 3)]
        public string ImgVideoPath
        {
            get { return _ImgVideoPath; }
            set { _ImgVideoPath = value; }
        }

        private int? _ForTime;

        public int? ForTime
        {
            get { return _ForTime; }
            set { _ForTime = value; }
        }

        public iv_LinkName() { }
        private iv_LinkName(DataRow row) : base(row) { }
        protected override void Load(DataRow row)
        {
            if (row != null)
            {
                if (row.Table.Columns.Contains("disid"))
                    _disID = (int)row["disid"];
                if (row.Table.Columns.Contains("SrNo"))
                    _SrNo = (int)row["SrNo"];
                if (row.Table.Columns.Contains("ImgOrVideo"))
                    _ImgOrVideo = Convert.ToChar(row["ImgOrVideo"].ToString());
                if (row.Table.Columns.Contains("BriefName"))
                    _BriefName = row["BriefName"].ToString();
                if (row.Table.Columns.Contains("ImgVideoPath"))
                    _ImgVideoPath = (string)row["ImgVideoPath"];
                if (row.Table.Columns.Contains("ForTime"))
                {
                    int? j = null;
                    _ForTime = Convert.IsDBNull(row["ForTime"]) ? j : int.Parse(Convert.ToString(row["ForTime"]));
                }
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", SrNo, "p_ImgOrVideo", ImgOrVideo, "p_BriefName", BriefName, "p_ImgVideoPath", ImgVideoPath, "p_ForTime", ForTime };
            return Convert.ToInt32(dbg.ExecuteScalar("proc_iv_linkname_insertupdate", obj));
        }

        public static List<iv_LinkName> GetAll(int pgno, int rpp, int? sort, ref int total, string search)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "keyword", search, "sortorder", sort };
            DataTable dt = dbg.QueryForDataTablePaged("proc_iv_linkname_getall", pgno, rpp, out total, obj);
            return CreateListFromTable<iv_LinkName>(dt);
        }
        public static List<iv_LinkName> GetAll()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            DataTable dt = dbg.QueryForDataTable("proc_iv_linkname_getall");
            return CreateListFromTable<iv_LinkName>(dt);
        }

        public static iv_LinkName GetByID(int? srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            DataTable dt = dbg.QueryForDataTable("proc_iv_linkname_getbyid", obj);
            if (dt.Rows.Count > 0)
            {
                return new iv_LinkName(dt.Rows[0]);
            }
            return null;
        }

        public static int Delete(int srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            return dbg.ExecuteNonQuery("proc_iv_linkname_delete", obj);

        }
    }
}