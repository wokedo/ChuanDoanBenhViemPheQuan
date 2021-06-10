using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanDoanBenh
{
    public partial class DuLieu : Form
    {
        Connection cn = new Connection();
        int demHoKPT = 0;
        int demHoVPQ = 0;
        int demHoGPN = 0;
        int demHoBT = 0;

        int demKhacDomKPT = 0;
        int demKhacDomVPQ = 0;
        int demKhacDomGPN = 0;
        int demKhacDomBT = 0;

        int demBieuHienKPT = 0;
        int demBieuHienVPQ = 0;
        int demBieuHienGPN = 0;
        int demBieuHienBT = 0;

        int demSotKPT = 0;
        int demSotVPQ = 0;
        int demSotGPN = 0;
        int demSotBT = 0;

        int demHoHapKPT = 0;
        int demHoHapVPQ = 0;
        int demHoHapGPN = 0;
        int demHoHapBT = 0;

        int demXQuangKPT = 0;
        int demXQuangVPQ = 0;
        int demXQuangGPN = 0;
        int demXQuangBT = 0;

        int demSCDTKPT = 0;
        int demSCDTVPQ = 0;
        int demSCDTGPN = 0;
        int demSCDTBT = 0;

        int demDLCOKPT = 0;
        int demDLCOVPQ = 0;
        int demDLCOGPN = 0;
        int demDLCOBT = 0;

        int demKhiMauKPT = 0;
        int demKhiMauVPQ = 0;
        int demKhiMauGPN = 0;
        int demKhiMauBT = 0;

        int demKetQuaKPT = 0;
        int demKetQuaVPQ = 0;
        int demKetQuaGPN = 0;
        int demKetQuaBT = 0;

         double kqKPT = 0;
         double kqVPQ = 0;
         double kqGPN = 0;
         double kqBT = 0;


        public DuLieu()
        {
            InitializeComponent();
        }

        public void ChuanDoan_Load(object sender, EventArgs e)
        {
            cn.MoKetNoi();
            //Load combobox
            string[] Ho = { "không", "ít", "liên tục" };
            string[] KhacDom = { "Nhiều", "Ít hoặc không có" };
            string[] BieuHien = { "ớn lạnh", "mệt mỏi", "bình thường" };
            string[] Sot = { "nhẹ", "không", "cao" };
            string[] HoHap = { "khò khè", "khó thở", "bình thường" };
            string[] XQuang = { "Giãn phổi", "Tăng sáng", "Hình ảnh Phổi bẩn" };
            string[] SucCanDuongTho = { "Tăng ít", "Tăng nhiều" };
            string[] DLCO = { "Tăng nhiều", "Giảm nhiều" };
            string[] KhiMau = { "Thay đổi ít", "Thay đổi nhiều" };
            foreach (string s in Ho) cbb_Ho.Items.Add(s);
            foreach (string s in KhacDom) cbb_KhocDom.Items.Add(s);
            foreach (string s in BieuHien) cbb_BieuHien.Items.Add(s);
            foreach (string s in Sot) cbb_Sot.Items.Add(s);
            foreach (string s in HoHap) cbb_HoHap.Items.Add(s);
            foreach (string s in XQuang) cbb_XQuang.Items.Add(s);
            foreach (string s in SucCanDuongTho) cbb_SucCanDuongTho.Items.Add(s);
            foreach (string s in DLCO) cbb_DLCO.Items.Add(s);
            foreach (string s in KhiMau) cbb_KhiMau.Items.Add(s);
            cbb_Ho.SelectedIndex = 0;
            cbb_KhocDom.SelectedIndex = 0;
            cbb_BieuHien.SelectedIndex = 0;
            cbb_Sot.SelectedIndex = 0;
            cbb_HoHap.SelectedIndex = 0;
            cbb_XQuang.SelectedIndex = 0;
            cbb_SucCanDuongTho.SelectedIndex = 0;
            cbb_DLCO.SelectedIndex = 0;
            cbb_KhiMau.SelectedIndex = 0;
            //load combobox

            string select = "select * from ThongTin";
            SqlCommand cmd = new SqlCommand(select, cn.consql);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(rd["Stt"].ToString());
                item.SubItems.Add(rd["HoTen"].ToString());
                item.SubItems.Add(rd["Ho"].ToString());
                item.SubItems.Add(rd["KhacDom"].ToString());
                item.SubItems.Add(rd["BieuHien"].ToString());
                item.SubItems.Add(rd["Sot"].ToString());
                item.SubItems.Add(rd["HoHap"].ToString());
                item.SubItems.Add(rd["XQuang"].ToString());
                item.SubItems.Add(rd["SucCanDuongTho"].ToString());
                item.SubItems.Add(rd["DLCO"].ToString());
                item.SubItems.Add(rd["KhiMau"].ToString());
                item.SubItems.Add(rd["KetQua"].ToString());

                listView1.Items.Add(item);

            }
            rd.Close();
        }

        public void ThuatToan()
        {
            cn.MoKetNoi();

            string select = "select * from ThongTin";
            SqlCommand cmd = new SqlCommand(select, cn.consql);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                //THUẬT TOÁN-----------------------------------------------------
                if (rd["KetQua"].ToString().Equals("Khí phế thủng"))
                {
                    if (rd["Ho"].ToString().Equals(cbb_Ho.Text))
                    {
                        demHoKPT++;
                    }
                    if (rd["KhacDom"].ToString().Equals(cbb_KhocDom.Text))
                    {
                        demKhacDomKPT++;
                    }
                    if (rd["BieuHien"].ToString().Equals(cbb_BieuHien.Text))
                    {
                        demBieuHienKPT++;
                    }
                    if (rd["Sot"].ToString().Equals(cbb_Sot.Text))
                    {
                        demSotKPT++;
                    }
                    if (rd["HoHap"].ToString().Equals(cbb_HoHap.Text))
                    {
                        demHoHapKPT++;
                    }
                    if (rd["XQuang"].ToString().Equals(cbb_XQuang.Text))
                    {
                        demXQuangKPT++;
                    }
                    if (rd["SucCanDuongTho"].ToString().Equals(cbb_SucCanDuongTho.Text))
                    {
                        demSCDTKPT++;
                    }
                    if (rd["DLCO"].ToString().Equals(cbb_DLCO.Text))
                    {
                        demDLCOKPT++;
                    }
                    if (rd["KhiMau"].ToString().Equals(cbb_KhiMau.Text))
                    {
                        demKhiMauKPT++;
                    }
                    demKetQuaKPT++;
                }
                else if (rd["KetQua"].ToString().Equals("Viêm phế quản"))
                {
                    if (rd["Ho"].ToString().Equals(cbb_Ho.Text))
                    {
                        demHoVPQ++;
                    }
                    if (rd["KhacDom"].ToString().Equals(cbb_KhocDom.Text))
                    {
                        demKhacDomVPQ++;
                    }
                    if (rd["BieuHien"].ToString().Equals(cbb_BieuHien.Text))
                    {
                        demBieuHienVPQ++;
                    }
                    if (rd["Sot"].ToString().Equals(cbb_Sot.Text))
                    {
                        demSotVPQ++;
                    }
                    if (rd["HoHap"].ToString().Equals(cbb_HoHap.Text))
                    {
                        demHoHapVPQ++;
                    }
                    if (rd["XQuang"].ToString().Equals(cbb_XQuang.Text))
                    {
                        demXQuangVPQ++;
                    }
                    if (rd["SucCanDuongTho"].ToString().Equals(cbb_SucCanDuongTho.Text))
                    {
                        demSCDTVPQ++;
                    }
                    if (rd["DLCO"].ToString().Equals(cbb_DLCO.Text))
                    {
                        demDLCOVPQ++;
                    }
                    if (rd["KhiMau"].ToString().Equals(cbb_KhiMau.Text))
                    {
                        demKhiMauVPQ++;
                    }
                    demKetQuaVPQ++;
                }
                else if (rd["KetQua"].ToString().Equals("Giãn phế nang"))
                {
                    if (rd["Ho"].ToString().Equals(cbb_Ho.Text))
                    {
                        demHoGPN++;
                    }
                    if (rd["KhacDom"].ToString().Equals(cbb_KhocDom.Text))
                    {
                        demKhacDomGPN++;
                    }
                    if (rd["BieuHien"].ToString().Equals(cbb_BieuHien.Text))
                    {
                        demBieuHienGPN++;
                    }
                    if (rd["Sot"].ToString().Equals(cbb_Sot.Text))
                    {
                        demSotGPN++;
                    }
                    if (rd["HoHap"].ToString().Equals(cbb_HoHap.Text))
                    {
                        demHoHapGPN++;
                    }
                    if (rd["XQuang"].ToString().Equals(cbb_XQuang.Text))
                    {
                        demXQuangGPN++;
                    }
                    if (rd["SucCanDuongTho"].ToString().Equals(cbb_SucCanDuongTho.Text))
                    {
                        demSCDTGPN++;
                    }
                    if (rd["DLCO"].ToString().Equals(cbb_DLCO.Text))
                    {
                        demDLCOGPN++;
                    }
                    if (rd["KhiMau"].ToString().Equals(cbb_KhiMau.Text))
                    {
                        demKhiMauGPN++;
                    }
                    demKetQuaGPN++;
                }
                else if (rd["KetQua"].ToString().Equals("Bình thường"))
                {
                    if (rd["Ho"].ToString().Equals(cbb_Ho.Text))
                    {
                        demHoBT++;
                    }
                    if (rd["KhacDom"].ToString().Equals(cbb_KhocDom.Text))
                    {
                        demKhacDomBT++;
                    }
                    if (rd["BieuHien"].ToString().Equals(cbb_BieuHien.Text))
                    {
                        demBieuHienBT++;
                    }
                    if (rd["Sot"].ToString().Equals(cbb_Sot.Text))
                    {
                        demSotBT++;
                    }
                    if (rd["HoHap"].ToString().Equals(cbb_HoHap.Text))
                    {
                        demHoHapBT++;
                    }
                    if (rd["XQuang"].ToString().Equals(cbb_XQuang.Text))
                    {
                        demXQuangBT++;
                    }
                    if (rd["SucCanDuongTho"].ToString().Equals(cbb_SucCanDuongTho.Text))
                    {
                        demSCDTBT++;
                    }
                    if (rd["DLCO"].ToString().Equals(cbb_DLCO.Text))
                    {
                        demDLCOBT++;
                    }
                    if (rd["KhiMau"].ToString().Equals(cbb_KhiMau.Text))
                    {
                        demKhiMauBT++;
                    }
                    demKetQuaBT++;
                }
            }


            double P_KPT = (double)demKetQuaKPT / (demKetQuaKPT + demKetQuaVPQ + demKetQuaGPN + demKetQuaBT);
            double P_hoKPT = (double)demHoKPT / demKetQuaKPT;
            double P_khacdomKPT = (double)demKhacDomKPT / demKetQuaKPT;
            double P_bieuhienKPT = (double)demBieuHienKPT / demKetQuaKPT;
            double P_sotKPT = (double)demSotKPT / demKetQuaKPT;
            double P_hohapKPT = (double)demHoHapKPT / demKetQuaKPT;
            double P_xquangKPT = (double)demXQuangKPT / demKetQuaKPT;
            double P_scdtKPT = (double)demSCDTKPT / demKetQuaKPT;
            double P_dlcoKPT = (double)demDLCOKPT / demKetQuaKPT;
            double P_khimauKPT = (double)demKhiMauKPT / demKetQuaKPT;
            double xacsuatKPT = (double)P_hoKPT * P_khacdomKPT * P_bieuhienKPT * P_sotKPT * P_hohapKPT * P_xquangKPT * P_scdtKPT * P_dlcoKPT * P_khimauKPT;
            kqKPT = P_KPT * xacsuatKPT;

            double P_VPQ = (double)demKetQuaVPQ / (demKetQuaKPT + demKetQuaVPQ + demKetQuaGPN + demKetQuaBT);
            double P_hoVPQ = (double)demHoVPQ / demKetQuaVPQ;
            double P_khacdomVPQ = (double)demKhacDomVPQ / demKetQuaVPQ;
            double P_bieuhienVPQ = (double)demBieuHienVPQ / demKetQuaVPQ;
            double P_sotVPQ = (double)demSotVPQ / demKetQuaVPQ;
            double P_hohapVPQ = (double)demHoHapVPQ / demKetQuaVPQ;
            double P_xquangVPQ = (double)demXQuangVPQ / demKetQuaVPQ;
            double P_scdtVPQ = (double)demSCDTVPQ / demKetQuaVPQ;
            double P_dlcoVPQ = (double)demDLCOVPQ / demKetQuaVPQ;
            double P_khimauVPQ = (double)demKhiMauVPQ / demKetQuaVPQ;
            double xacsuatVPQ = (double)P_hoVPQ * P_khacdomVPQ * P_bieuhienVPQ * P_sotVPQ * P_hohapVPQ * P_xquangVPQ * P_scdtVPQ * P_dlcoVPQ * P_khimauVPQ;
            kqVPQ = P_VPQ * xacsuatVPQ;

            double P_GPN = (double)demKetQuaGPN / (demKetQuaKPT + demKetQuaVPQ + demKetQuaGPN + demKetQuaBT);
            double P_hoGPN = (double)demHoGPN / demKetQuaGPN;
            double P_khacdomGPN = (double)demKhacDomGPN / demKetQuaGPN;
            double P_bieuhienGPN = (double)demBieuHienGPN / demKetQuaGPN;
            double P_sotGPN = (double)demSotGPN / demKetQuaGPN;
            double P_hohapGPN = (double)demHoHapGPN / demKetQuaGPN;
            double P_xquangGPN = (double)demXQuangGPN / demKetQuaGPN;
            double P_scdtGPN = (double)demSCDTGPN / demKetQuaGPN;
            double P_dlcoGPN = (double)demDLCOGPN / demKetQuaGPN;
            double P_khimauGPN = (double)demKhiMauGPN / demKetQuaGPN;
            double xacsuatGPN = (double)P_hoGPN * P_khacdomGPN * P_bieuhienGPN * P_sotGPN * P_hohapGPN * P_xquangGPN * P_scdtGPN * P_dlcoGPN * P_khimauGPN;
            kqGPN = P_GPN * xacsuatGPN;

            double P_BT = (double)demKetQuaBT / (demKetQuaKPT + demKetQuaVPQ + demKetQuaGPN + demKetQuaBT);
            double P_hoBT = (double)demHoBT / demKetQuaBT;
            double P_khacdomBT = (double)demKhacDomBT / demKetQuaBT;
            double P_bieuhienBT = (double)demBieuHienBT / demKetQuaBT;
            double P_sotBT = (double)demSotBT / demKetQuaBT;
            double P_hohapBT = (double)demHoHapBT / demKetQuaBT;
            double P_xquangBT = (double)demXQuangBT / demKetQuaBT;
            double P_scdtBT = (double)demSCDTBT / demKetQuaBT;
            double P_dlcoBT = (double)demDLCOBT / demKetQuaBT;
            double P_khimauBT = (double)demKhiMauBT / demKetQuaBT;
            double xacsuatBT = (double)P_hoBT * P_khacdomBT * P_bieuhienBT * P_sotBT * P_hohapBT * P_xquangBT * P_scdtBT * P_dlcoBT * P_khimauBT;
            kqBT = P_BT * xacsuatBT;


            rd.Close();
        }


        private void DuLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            cn.DongKetNoi();
        }

        private void btn_ChuanDoan_Click(object sender, EventArgs e)
        {
            demHoKPT = 0;
            demHoVPQ = 0;
            demHoGPN = 0;
            demHoBT = 0;

            demKhacDomKPT = 0;
            demKhacDomVPQ = 0;
            demKhacDomGPN = 0;
            demKhacDomBT = 0;

            demBieuHienKPT = 0;
            demBieuHienVPQ = 0;
            demBieuHienGPN = 0;
            demBieuHienBT = 0;

            demSotKPT = 0;
            demSotVPQ = 0;
            demSotGPN = 0;
            demSotBT = 0;

            demHoHapKPT = 0;
            demHoHapVPQ = 0;
            demHoHapGPN = 0;
            demHoHapBT = 0;

            demXQuangKPT = 0;
            demXQuangVPQ = 0;
            demXQuangGPN = 0;
            demXQuangBT = 0;

            demSCDTKPT = 0;
            demSCDTVPQ = 0;
            demSCDTGPN = 0;
            demSCDTBT = 0;

            demDLCOKPT = 0;
            demDLCOVPQ = 0;
            demDLCOGPN = 0;
            demDLCOBT = 0;

            demKhiMauKPT = 0;
            demKhiMauVPQ = 0;
            demKhiMauGPN = 0;
            demKhiMauBT = 0;

            demKetQuaKPT = 0;
            demKetQuaVPQ = 0;
            demKetQuaGPN = 0;
            demKetQuaBT = 0;

            kqKPT = 0;
            kqVPQ = 0;
            kqGPN = 0;
            kqBT = 0;
            ThuatToan();

            txt_TiLeKPT.Text = kqKPT.ToString();
            txt_TiLeVPQ.Text = kqVPQ.ToString();
            txt_TiLeGPN.Text = kqGPN.ToString();
            txt_TiLeBT.Text = kqBT.ToString();

            if (kqKPT > kqVPQ && kqKPT > kqGPN && kqKPT > kqBT)
            {
                txt_MacBenh.Text = "Khí Phế Thủng";
            }
            else if (kqVPQ > kqKPT && kqVPQ > kqGPN && kqVPQ > kqBT)
            {
                txt_MacBenh.Text = "Viêm Phế Quản";
            }
            else if (kqGPN > kqVPQ && kqGPN > kqKPT && kqGPN > kqBT)
            {
                txt_MacBenh.Text = "Giãn Phế Nang";
            }
            else
            {
                txt_MacBenh.Text = "Bình Thường";
            }

        }
    }
}
