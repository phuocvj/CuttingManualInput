using AutoUpdaterDotNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuttingManualInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isAdvClick = false;
        string Password = "PHUOC.IT";
        #region DB
        public bool EXE_INPUT_DELETE(string ARG_TYPE, string ARG_FACTORY, string ARG_PLANT, string ARG_LINE, string ARG_MLINE, string ARG_YMD, string ARG_PROC, string ARG_STYLE, string ARG_RESOURCE, string ARG_HOUR, string ARG_PART,string ARG_SIZE)
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                System.Data.DataSet ds_ret;

                string process_name = "SEPHIROTH.P_CUTTING_MANUAL_INPUT";
                MyOraDB.ReDim_Parameter(13);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "ARG_TYPE";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_PLANT";
                MyOraDB.Parameter_Name[3] = "ARG_LINE";
                MyOraDB.Parameter_Name[4] = "ARG_MLINE";
                MyOraDB.Parameter_Name[5] = "ARG_YMD";
                MyOraDB.Parameter_Name[6] = "ARG_PROC";
                MyOraDB.Parameter_Name[7] = "ARG_STYLE";
                MyOraDB.Parameter_Name[8]  = "ARG_RESOURCE";
                MyOraDB.Parameter_Name[9]  = "ARG_HOUR";
                MyOraDB.Parameter_Name[10] = "ARG_PART";
                MyOraDB.Parameter_Name[11] = "ARG_SIZE";
                MyOraDB.Parameter_Name[12] = "ARG_USER";

                MyOraDB.Parameter_Type[0] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[11] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[12] = (char)OracleType.VarChar;

                MyOraDB.Parameter_Values[0] = ARG_TYPE;
                MyOraDB.Parameter_Values[1] = ARG_FACTORY;
                MyOraDB.Parameter_Values[2] = ARG_PLANT;
                MyOraDB.Parameter_Values[3] = ARG_LINE;
                MyOraDB.Parameter_Values[4] = ARG_MLINE;
                MyOraDB.Parameter_Values[5] = ARG_YMD;
                MyOraDB.Parameter_Values[6] = ARG_PROC;
                MyOraDB.Parameter_Values[7] = ARG_STYLE;
                MyOraDB.Parameter_Values[8] = ARG_RESOURCE;
                MyOraDB.Parameter_Values[9] = ARG_HOUR;
                MyOraDB.Parameter_Values[10] = ARG_PART;
                MyOraDB.Parameter_Values[11] = ARG_SIZE;
                MyOraDB.Parameter_Values[12] =Environment.MachineName;


                MyOraDB.Add_Modify_Parameter(true);
                ds_ret = MyOraDB.Exe_Modify_Procedure();
                if (ds_ret == null) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable SELECT_DATA(string ARG_TYPE, string ARG_FACTORY, string ARG_PLANT, string ARG_LINE, string ARG_MLINE, string ARG_YMD, string ARG_PROC, string ARG_STYLE, string ARG_RESOURCE, string ARG_HOUR, string ARG_PART)
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                System.Data.DataSet ds_ret;

                string process_name = "SEPHIROTH.P_CUTTING_MANUAL_SELECT";
                MyOraDB.ReDim_Parameter(12);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "ARG_TYPE";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_PLANT";
                MyOraDB.Parameter_Name[3] = "ARG_LINE";
                MyOraDB.Parameter_Name[4] = "ARG_MLINE";
                MyOraDB.Parameter_Name[5] = "ARG_YMD";
                MyOraDB.Parameter_Name[6] = "ARG_PROC";
                MyOraDB.Parameter_Name[7] = "ARG_STYLE";
                MyOraDB.Parameter_Name[8] = "ARG_RESOURCE";
                MyOraDB.Parameter_Name[9] = "ARG_HOUR";
                MyOraDB.Parameter_Name[10] = "ARG_PART";
                MyOraDB.Parameter_Name[11] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[11] = (char)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_TYPE;
                MyOraDB.Parameter_Values[1] = ARG_FACTORY;
                MyOraDB.Parameter_Values[2] = ARG_PLANT;
                MyOraDB.Parameter_Values[3] = ARG_LINE;
                MyOraDB.Parameter_Values[4] = ARG_MLINE;
                MyOraDB.Parameter_Values[5] = ARG_YMD;
                MyOraDB.Parameter_Values[6] = ARG_PROC;
                MyOraDB.Parameter_Values[7] = ARG_STYLE;
                MyOraDB.Parameter_Values[8] = ARG_RESOURCE;
                MyOraDB.Parameter_Values[9] = ARG_HOUR;
                MyOraDB.Parameter_Values[10] = ARG_PART;
                MyOraDB.Parameter_Values[11] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();
                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }
        #endregion
        private void btnAdv_Click(object sender, EventArgs e)
        {
            
        }
        private void BindingCboPlant()
        {
            DataTable dtSource = SELECT_DATA("QPLANT", "2110", "", "", "", "", "", "", "", "", "");
            if (dtSource != null && dtSource.Rows.Count > 0)
            {
                cboPlant.DataSource = dtSource;
                cboPlant.DisplayMember = dtSource.Columns[1].ColumnName;
                cboPlant.ValueMember = dtSource.Columns[0].ColumnName;
                cboPlant.SelectedIndex = 1;
                cboPlant.SelectedIndex = 0;
            }
        }

        private void BindingCboHH()
        {
            DataTable dtSource = SELECT_DATA("QHH", "2110", "", "", "", "", "", "", "", "", "");
            if (dtSource != null && dtSource.Rows.Count > 0)
            {
                cboHH.DataSource = dtSource;
                cboHH.DisplayMember = dtSource.Columns[1].ColumnName;
                cboHH.ValueMember = dtSource.Columns[0].ColumnName;
                cboHH.SelectedIndex = 0;
            }
        }

        private void BindingCboLine(string PlantCode)
        {

            DataTable dtSource = SELECT_DATA("QLINE", PlantCode, "", "", "", "", "", "", "", "", "");
            if (dtSource != null && dtSource.Rows.Count > 0)
            {
                cboLine.DataSource = dtSource;
                cboLine.DisplayMember = dtSource.Columns[1].ColumnName;
                cboLine.ValueMember = dtSource.Columns[0].ColumnName;
                cboLine.SelectedIndex = 0;
            }
        }
        private void BindingCboProc()
        {
            DataTable dtSource = SELECT_DATA("QPROC", "2110", "", "", "", "", "", "", "", "", "");
            if (dtSource != null && dtSource.Rows.Count > 0)
            {
                cboProc.DataSource = dtSource;
                cboProc.DisplayMember = dtSource.Columns[1].ColumnName;
                cboProc.ValueMember = dtSource.Columns[0].ColumnName;
                cboProc.SelectedIndex = 0;
            }
        }
        private void BindingCboStyle(string ARG_DATE, string ARG_PROC, string ARG_PLANT, string ARG_LINE)
        {
            DataTable dtSource = SELECT_DATA("QSTYLE", "2110", ARG_PLANT, ARG_LINE, "", ARG_DATE, ARG_PROC, "", "", "", "");
            if (dtSource != null && dtSource.Rows.Count > 0)
            {
                cboStyle.DataSource = dtSource;
                cboStyle.DisplayMember = dtSource.Columns[1].ColumnName;
                cboStyle.ValueMember = dtSource.Columns[0].ColumnName;
                cboStyle.SelectedIndex = 0;
            }
        }
        private void BindingCboMline(string ARG_PLANT, string ARG_LINE)
        {
            DataTable dtSource = SELECT_DATA("QMLINE", "2110", ARG_PLANT, ARG_LINE, "", "", "", "", "", "", "");
            if (dtSource != null && dtSource.Rows.Count > 0)
            {
                cboMline.DataSource = dtSource;
                cboMline.DisplayMember = dtSource.Columns[1].ColumnName;
                cboMline.ValueMember = dtSource.Columns[0].ColumnName;
                cboMline.SelectedIndex = 0;
            }
        }
        private void BindingCboResource(string ARG_PLANT, string ARG_LINE, string ARG_DATE, string ARG_PROC)
        {
            DataTable dtSource = SELECT_DATA("QRESOURCE", "2110", ARG_PLANT, ARG_LINE, "", ARG_DATE, ARG_PROC, "", "", "", "");
            if (dtSource != null && dtSource.Rows.Count > 0)
            {
                cboResource.DataSource = dtSource;
                cboResource.DisplayMember = dtSource.Columns[1].ColumnName;
                cboResource.ValueMember = dtSource.Columns[0].ColumnName;
                cboResource.SelectedIndex = 0;
            }
        }
        private void BindingCboPart(string ARG_PLANT, string ARG_LINE, string ARG_DATE, string ARG_STYLE, string ARG_PROC, string ARG_RESOURCE)
        {
            DataTable dtSource = SELECT_DATA("QPART", "2110", ARG_PLANT, ARG_LINE, "", ARG_DATE, ARG_PROC, ARG_STYLE, ARG_RESOURCE, "", "");
            if (dtSource != null && dtSource.Rows.Count > 0)
            {
                cboPart.DataSource = dtSource;
                cboPart.DisplayMember = dtSource.Columns[1].ColumnName;
                cboPart.ValueMember = dtSource.Columns[0].ColumnName;
                cboPart.SelectedIndex = 0;
            }
        }
        private void BindingCboSize(string ARG_PLANT, string ARG_LINE, string ARG_MLINE, string ARG_DATE, string ARG_STYLE, string ARG_PROC, string ARG_RESOURCE, string ARG_HOUR, string ARG_PART)
        {
            DataTable dtSource = SELECT_DATA("QSIZE", "2110", ARG_PLANT, ARG_LINE, ARG_MLINE, ARG_DATE, ARG_PROC, ARG_STYLE, ARG_RESOURCE, ARG_HOUR, ARG_PART);
            if (dtSource != null && dtSource.Rows.Count > 0)
            {
                cboSize.DataSource = dtSource;
                cboSize.DisplayMember = dtSource.Columns[1].ColumnName;
                cboSize.ValueMember = dtSource.Columns[0].ColumnName;
                cboSize.SelectedIndex = 0;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                AutoUpdater.Synchronous = true;
                AutoUpdater.ShowSkipButton = false;
                AutoUpdater.ShowRemindLaterButton = false;
                
                //System.Timers.Timer timer = new System.Timers.Timer
                //{
                //    Interval = 8 * 60 * 1000, 
                //    SynchronizingObject = this
                //};
                //timer.Elapsed += delegate
                //{
                //    AutoUpdater.Start("ftp://211.54.128.12/freeware/Tmp/Phuoc/Tool/Update.xml", new NetworkCredential("ftpsystem", "csiftpsystem"));
                //};
                //timer.Start();


                DataTable dt = SELECT_DATA("PASSWORD", "2110", "", "", "", "", "", "", "", "", "");

                if (dt != null && dt.Rows.Count > 0)
                    Password = dt.Rows[0]["PASSWD"].ToString();
                else
                {
                    MessageBox.Show(this, "Không thể kết nối mạng", "Network Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BindingCboPlant();
                BindingCboProc();
                BindingCboHH();
                lblUserName.Text = Dns.GetHostName() + "\n" + Dns.GetHostByName(Environment.MachineName).AddressList[0];
                AutoUpdater.Start("ftp://211.54.128.12/freeware/Tmp/Phuoc/Tool/Update.xml", new NetworkCredential("ftpsystem", "csiftpsystem"));
            }
            catch
            {

            }

        }
        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            try
            {
                if (args.IsUpdateAvailable)
                {
                    DialogResult dialogResult;
                    if (args.Mandatory.Value)
                    {
                        dialogResult =
                            MessageBox.Show(
                                $@"There is new version {args.CurrentVersion} available. You are using version {args.InstalledVersion}. This is required update. Press Ok to begin updating the application.", @"Update Available",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else
                    {
                        dialogResult =
                            MessageBox.Show(
                                $@"There is new version {args.CurrentVersion} available. You are using version {
                                        args.InstalledVersion
                                    }. Do you want to update the application now?", @"Update Available",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                    }

                    // Uncomment the following line if you want to show standard update dialog instead.
                    // AutoUpdater.ShowUpdateForm(args);

                    if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
                    {
                        try
                        {
                            if (AutoUpdater.DownloadUpdate(args))
                            {
                                Application.Exit();
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(@"There is no update available please try again later.", @"No update available",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
            
        }
        private void btnInput_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtPass.Text))
            {
                if (txtPass.Text.Equals(Password))
                {
                    DialogResult dl = MessageBox.Show(this, "Manual Input?", "Cutting Input!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dl == DialogResult.Yes)
                    {
                        string PLANT, LINE, MLINE = "0", ASY_YMD, PROC, STYLE = "0", RESOURCE = "0", HOUR = "0", PART = "0", SIZE = "0";
                        PLANT = cboPlant.SelectedValue.ToString();
                        LINE = cboLine.SelectedValue.ToString();
                        PROC = cboProc.SelectedValue.ToString();
                        ASY_YMD = dtpDate.Value.ToString("yyyyMMdd");

                        MLINE = cboMline.SelectedValue.ToString()==""?"0": cboMline.SelectedValue.ToString();
                        STYLE = cboStyle.SelectedValue.ToString() == "" ? "0" : cboStyle.SelectedValue.ToString();
                        RESOURCE = cboResource.SelectedValue.ToString() == "" ? "0" : cboResource.SelectedValue.ToString(); 
                        HOUR = cboHH.SelectedValue.ToString() == "" ? "0" : cboHH.SelectedValue.ToString();
                        PART = cboPart.SelectedValue.ToString() == "" ? "0" : cboPart.SelectedValue.ToString(); 
                        SIZE = cboSize.SelectedValue.ToString() == "" ? "0" : cboSize.SelectedValue.ToString();
                        //INSERT DATA
                        if (EXE_INPUT_DELETE("I", "VJ", PLANT, LINE, MLINE, ASY_YMD, PROC, STYLE, RESOURCE, HOUR, PART, SIZE))
                        {
                           
                            string Condition = string.Concat("Plant:", PLANT, " Line: ", LINE, " Stitching Line: ", MLINE);
                            string sStyle = @"<head>
		                                            <style type='text/css'>
			                                            .tg  {font-size:12px; width:100%;border-width: 1px; border-collapse: collapse;}
                                                        .tg td{font-size:12px;font-family:Calibri;bgcolor:#ffffff;border-width: 1px;padding: 8px;border-style: solid;border-color: #9dcc7a;white-space: nowrap}
                                                        .tg th{border-color:#9dcc7a;border-style:solid;border-width:1px;background-color:#0080a0;color: #ffffff; font-family:Arial, sans-serif;font-size:12px;
                                                          font-weight:bold;overflow:hidden;padding:5px 10px;word-break:normal;}
                                                        .tg .tg-0lax{text-align:center;}
                                                        .tg .tg-1lax{text-align:left;}
                                                        .tg .tg-2lax{text-align:right;}
                                                        .tg .tg-total{text-align:right;background-color:yellow;color: #000000;}
                                                         </style></head>";
                            string Body = string.Format(@"<html>
                                                        {0}
                                        <body><table class='tg'>
                                        <tbody>
                                        <tr>
                                        <th class='tg-0lax'>Date Time</th>
                                        <th class='tg-0lax'>User</th>
                                        <th class='tg-0lax'>Condition</th>
                                        <th class='tg-0lax'>Content</th>
                                        </tr>
                                        <tr>
                                        <td class='tg-0lax'>{1}</td>
                                        <td class='tg-0lax'>{2}</td>
                                        <td class='tg-0lax'>{3}</td>
                                        <td class='tg-0lax'>{4}</td>
                                        </tr>
                                        </tbody>
                                        </table></body></html> ", sStyle, DateTime.Now, Dns.GetHostName() + "/" + Dns.GetHostByName(Environment.MachineName).AddressList[0], Condition, "Vừa TÔ TAY dữ liệu Cutting");
                            CreateMail("MANUAL INPUT CUTTING", Body, null);
                            MessageBox.Show("INPUT SUCCESSFULLY!!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "Liên hệ Sang.IT để biết password?!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show(this, "Liên hệ Sang.IT để biết password?!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtPass.Focus();
            }

        }

        private void btnTestUpdate_Click(object sender, EventArgs e)
        {


        }

        private void cboPlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                BindingCboLine(cboPlant.SelectedValue.ToString());
                BindingCboMline(cboPlant.SelectedValue.ToString(), cboLine.SelectedValue.ToString());
                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void cboProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                BindingCboStyle(dtpDate.Value.ToString("yyyyMMdd"), cboProc.SelectedValue.ToString(), cboPlant.SelectedValue.ToString(), cboLine.SelectedValue.ToString());
                BindingCboResource(cboPlant.SelectedValue.ToString(), cboLine.SelectedValue.ToString(), dtpDate.Value.ToString("yyyyMMdd"), cboProc.SelectedValue.ToString());
                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void cboLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                BindingCboStyle(dtpDate.Value.ToString("yyyyMMdd"), cboProc.SelectedValue.ToString(), cboPlant.SelectedValue.ToString(), cboLine.SelectedValue.ToString());
                BindingCboResource(cboPlant.SelectedValue.ToString(), cboLine.SelectedValue.ToString(), dtpDate.Value.ToString("yyyyMMdd"), cboProc.SelectedValue.ToString());
                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void cboResource_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                BindingCboPart(cboPlant.SelectedValue.ToString(), cboLine.SelectedValue.ToString(), dtpDate.Value.ToString("yyyyMMdd"), cboStyle.SelectedValue.ToString(), cboProc.SelectedValue.ToString(), cboResource.SelectedValue.ToString());
                BindingCboSize(cboPlant.SelectedValue.ToString(), cboLine.SelectedValue.ToString(), cboMline.SelectedValue.ToString(), dtpDate.Value.ToString("yyyyMMdd"), cboStyle.SelectedValue.ToString(), cboProc.SelectedValue.ToString(), cboResource.SelectedValue.ToString(), cboHH.SelectedValue.ToString(), cboPart.SelectedValue.ToString());
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void cboMline_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                BindingCboSize(cboPlant.SelectedValue.ToString(), cboLine.SelectedValue.ToString(), cboMline.SelectedValue.ToString(), dtpDate.Value.ToString("yyyyMMdd"), cboStyle.SelectedValue.ToString(), cboProc.SelectedValue.ToString(), cboResource.SelectedValue.ToString(), cboHH.SelectedValue.ToString(), cboPart.SelectedValue.ToString());
                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                BindingCboPlant();
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void cboHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                BindingCboSize(cboPlant.SelectedValue.ToString(), cboLine.SelectedValue.ToString(), cboMline.SelectedValue.ToString(), dtpDate.Value.ToString("yyyyMMdd"), cboStyle.SelectedValue.ToString(), cboProc.SelectedValue.ToString(), cboResource.SelectedValue.ToString(), cboHH.SelectedValue.ToString(), cboPart.SelectedValue.ToString());
                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void cboPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                BindingCboSize(cboPlant.SelectedValue.ToString(), cboLine.SelectedValue.ToString(), cboMline.SelectedValue.ToString(), dtpDate.Value.ToString("yyyyMMdd"), cboStyle.SelectedValue.ToString(), cboProc.SelectedValue.ToString(), cboResource.SelectedValue.ToString(), cboHH.SelectedValue.ToString(), cboPart.SelectedValue.ToString());
                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(Password))
            {
                txtPass.BackColor = Color.Lime;
                txtPass.ForeColor = Color.White;
            }
            else
            {
                txtPass.BackColor = Color.Red;
                txtPass.ForeColor = Color.Yellow;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtPass.Text))
            {
                if (txtPass.Text.Equals(Password))
                {
                    DialogResult dl = MessageBox.Show(this, "Manual Input?", "Delete Input!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dl == DialogResult.Yes)
                    {
                        string PLANT, LINE, MLINE = "0", ASY_YMD, PROC, STYLE = "0", RESOURCE = "0", HOUR = "0", PART = "0", SIZE = "0";
                        PLANT = cboPlant.SelectedValue.ToString();
                        LINE = cboLine.SelectedValue.ToString();
                        PROC = cboProc.SelectedValue.ToString();
                        ASY_YMD = dtpDate.Value.ToString("yyyyMMdd");

                        MLINE = cboMline.SelectedValue.ToString() == "" ? "0" : cboMline.SelectedValue.ToString();
                        STYLE = cboStyle.SelectedValue.ToString() == "" ? "0" : cboStyle.SelectedValue.ToString();
                        RESOURCE = cboResource.SelectedValue.ToString() == "" ? "0" : cboResource.SelectedValue.ToString();
                        HOUR = cboHH.SelectedValue.ToString() == "" ? "0" : cboHH.SelectedValue.ToString();
                        PART = cboPart.SelectedValue.ToString() == "" ? "0" : cboPart.SelectedValue.ToString();
                        SIZE = cboSize.SelectedValue.ToString() == "" ? "0" : cboSize.SelectedValue.ToString();
                        //INSERT DATA
                        if (EXE_INPUT_DELETE("D", "VJ", PLANT, LINE, MLINE, ASY_YMD, PROC, STYLE, RESOURCE, HOUR, PART, SIZE))
                        {
                           
                            string Condition = string.Concat("Plant:", PLANT, " Line: ", LINE, " Stitching Line: ", MLINE);
                            string sStyle = @"<head>
		                                            <style type='text/css'>
			                                            .tg  {font-size:12px; width:100%;border-width: 1px; border-collapse: collapse;}
                                                        .tg td{font-size:12px;font-family:Calibri;bgcolor:#ffffff;border-width: 1px;padding: 8px;border-style: solid;border-color: #9dcc7a;white-space: nowrap}
                                                        .tg th{border-color:#9dcc7a;border-style:solid;border-width:1px;background-color:#0080a0;color: #ffffff; font-family:Arial, sans-serif;font-size:12px;
                                                          font-weight:bold;overflow:hidden;padding:5px 10px;word-break:normal;}
                                                        .tg .tg-0lax{text-align:center;}
                                                        .tg .tg-1lax{text-align:left;}
                                                        .tg .tg-2lax{text-align:right;}
                                                        .tg .tg-total{text-align:right;background-color:yellow;color: #000000;}
                                                         </style></head>";
                            string Body = string.Format(@"<html>
                                                        {0}
                                        <body><table class='tg'>
                                        <tbody>
                                        <tr>
                                        <th class='tg-0lax'>Date Time</th>
                                        <th class='tg-0lax'>User</th>
                                        <th class='tg-0lax'>Condition</th>
                                        <th class='tg-0lax'>Content</th>
                                        </tr>
                                        <tr>
                                        <td class='tg-0lax'>{1}</td>
                                        <td class='tg-0lax'>{2}</td>
                                        <td class='tg-0lax'>{3}</td>
                                        <td class='tg-0lax'>{4}</td>
                                        </tr>
                                        </tbody>
                                        </table></body></html> ", sStyle, DateTime.Now, Dns.GetHostName() + "/" + Dns.GetHostByName(Environment.MachineName).AddressList[0], Condition,"Vừa xóa dữ liệu Cutting");
                             CreateMail("MANUAL INPUT CUTTING", Body, null);
                             MessageBox.Show("DELETED SUCCESSFULLY!!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "Liên hệ Sang.IT để biết password?!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show(this, "Liên hệ Sang.IT để biết password?!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtPass.Focus();
            }
        }
        readonly string[] _emailTest = { "nuoc.it@changshininc.com", "nghia.it@changshininc.com" };
        private void CreateMail(string Subject, string htmlBody, DataTable dtEmail)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
                Microsoft.Office.Interop.Outlook.MailItem mailItem = (Microsoft.Office.Interop.Outlook.MailItem)app.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                mailItem.Subject = Subject;
                Microsoft.Office.Interop.Outlook.Recipients oRecips = (Microsoft.Office.Interop.Outlook.Recipients)mailItem.Recipients;
                Microsoft.Office.Interop.Outlook.Recipient oRecip = (Microsoft.Office.Interop.Outlook.Recipient)oRecips.Add("SANG.IT@CHANGSHININC.COM");
                oRecip.Resolve();
                oRecips = null;
                mailItem.BCC = "phuoc.it@changshininc.com";
                mailItem.HTMLBody = htmlBody;
                mailItem.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceHigh;
                mailItem.Send();
                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
        }
        
        private void label3_DoubleClick(object sender, EventArgs e)
        {
            //string sStyle = @"<head>
		          //                                  <style type='text/css'>
			         //                                   .tg  {font-size:12px; width:100%;border-width: 1px; border-collapse: collapse;}
            //                                            .tg td{font-size:12px;font-family:Calibri;bgcolor:#ffffff;border-width: 1px;padding: 8px;border-style: solid;border-color: #9dcc7a;white-space: nowrap}
            //                                            .tg th{border-color:#9dcc7a;border-style:solid;border-width:1px;background-color:#0080a0;color: #ffffff; font-family:Arial, sans-serif;font-size:12px;
            //                                              font-weight:bold;overflow:hidden;padding:5px 10px;word-break:normal;}
            //                                            .tg .tg-0lax{text-align:center;}
            //                                            .tg .tg-1lax{text-align:left;}
            //                                            .tg .tg-2lax{text-align:right;}
            //                                            .tg .tg-total{text-align:right;background-color:yellow;color: #000000;}
            //                                             </style></head>";
            //string Body = string.Format(@"<html>
            //                                            {0}
            //                            <body><table class='tg'>
            //                            <tbody>
            //                            <tr>
            //                            <th class='tg-0lax'>Date Time</th>
            //                            <th class='tg-0lax'>User</th>
            //                            <th class='tg-0lax'>Condition</th>
            //                            <th class='tg-0lax'>Content</th>
            //                            </tr>
            //                            <tr>
            //                            <td class='tg-0lax'>{1}</td>
            //                            <td class='tg-0lax'>{2}</td>
            //                            <td class='tg-0lax'>{3}</td>
            //                            <td class='tg-0lax'>{4}</td>
            //                            </tr>
            //                            </tbody>
            //                            </table></body></html> ", sStyle, DateTime.Now, Dns.GetHostName() + "/" + Dns.GetHostByName(Environment.MachineName).AddressList[0], "TEST", "Vừa xóa dữ liệu Cutting");
            //CreateMail("MANUAL INPUT CUTTING", Body, null);
        }
    }
}
