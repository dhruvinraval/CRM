using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class ImageVideo
    {
        public int? srno { get; set; }

        public char imgorvideo { get; set; }

        public string briefname { get; set; }

        public string imgvideopath { get; set; }

        public int fortime { get; set; }

        //public List<ProductMaster> productmaster { get; set; }

        //public int ExecuteScalar()
        //{
        //    DatabaseGateway cn = new DatabaseGateway();
        //    object[] ins = { "p_SrNo", srno, "p_ImgOrVideo", imgorvideo, "p_BriefName", briefname, "p_ImgVideoPath", imgvideopath, "p_ForTime", fortime};
        //    return Convert.ToInt32(cn.ExecuteScalar("proc_iv_linkname_insertupdate", ins));
        //}

        //public object QueryForDataTable()
        //{
        //    DatabaseGateway cn = new DatabaseGateway();
        //    return cn.QueryForDataTable("proc_iv_linkname_getall");
        //}
    }
}
