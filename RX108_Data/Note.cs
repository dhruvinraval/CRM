using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class Note : BusinessObject
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


        private string _NoteName;
        [Required(ErrorMessage = "Enter Note Name")]
        [StringLength(100, MinimumLength = 3)]
        public string NoteName
        {
            get { return _NoteName; }
            set { _NoteName = value; }
        }

        public Note() { }
        private Note(DataRow row)
        {
            Load(row);
        }
        public static Note Create(DataRow row)
        {
            if (row != null)
                return new Note(row);
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
                if (row.Table.Columns.Contains("NoteName"))
                    _NoteName = (string)row["NoteName"];
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_note_insertupdate", "p_SrNo", _SrNo, "p_NoteName", _NoteName));
            return result;
        }

        public static List<Note> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_note_getall");
            return CreateListFromTable<Note>(dt);
        }

        public static List<Note> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_note_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<Note>(dt);
        }

        public static Note GetById(int? srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_note_getbyid", "p_SrNo", srnopass);
            if (dt.Rows.Count > 0)
                return new Note(dt.Rows[0]);
            return null;
        }

        public static void NoteDelete(int srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_note_delete", "p_SrNo", srnopass);
        }
    }
}
