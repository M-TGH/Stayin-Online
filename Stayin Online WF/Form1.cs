using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Stayin_Online_WF
{
    public partial class Form1 : Form
    {
        List<SiteItem> sites = new List<SiteItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridViewMain_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowCount == 1) {
                Int32 index = e.RowIndex - 1;
                Boolean active = dataGridViewMain[0, index] == null ? (Boolean)dataGridViewMain[0, index].Value : false;
                String target = dataGridViewMain[1, index] == null ?  (String)dataGridViewMain[1, index].Value : "";
                String status = dataGridViewMain[2, index] == null ? (String)dataGridViewMain[2, index].Value : "";
                String interval = dataGridViewMain[3, index] == null ? (String)dataGridViewMain[3, index].Value : "";
                Int32 position = index;
                SiteItem tempSite = new SiteItem(active, target, status, interval, position);
                tempSite.StatusChanged += siteStatusChanged;
                sites.Add(tempSite);
            }
            else
            {
                for (var i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
                {
                    Boolean active = (Boolean)dataGridViewMain[0, i].Value;
                    String target = (String)dataGridViewMain[1, i].Value;
                    String status = (String)dataGridViewMain[2, i].Value;
                    String interval = (String)dataGridViewMain[3, i].Value;
                    Int32 position = i;
                    SiteItem tempSite = new SiteItem(active, target, status, interval, position);
                    tempSite.StatusChanged += siteStatusChanged;
                    sites.Add(tempSite);
                }
            }
        }

        private void siteStatusChanged(object sender, EventArgs e)
        {
            SiteItem obj = (SiteItem)sender;
            Int32 position = obj.Position;
            dataGridViewMain[2, position].Value = obj.Status;
        }

        private void dataGridViewMain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
          {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0) {
                Int32 column = e.ColumnIndex;
                switch (column)
                {
                    case 0:
                        try
                        {
                            sites[e.RowIndex].Active = (Boolean)dataGridViewMain[e.ColumnIndex, e.RowIndex].Value;
                        }
                        catch(MissingFieldException err)
                        {
                            MessageBox.Show(err.Message);
                        }
                        break;
                    case 1:
                        try
                        {
                            sites[e.RowIndex].Target = (String)dataGridViewMain[e.ColumnIndex, e.RowIndex].Value;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message);
                            dataGridViewMain[0, e.RowIndex].Value = false;
                        }
                        break;
                    case 2:
                        sites[e.RowIndex].Status = (String)dataGridViewMain[e.ColumnIndex, e.RowIndex].Value;
                        break;
                    case 3:
                        sites[e.RowIndex].Interval = (String)dataGridViewMain[e.ColumnIndex, e.RowIndex].Value;
                        break;
                    default:
                        break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IEnumerable<SiteItem> results = sites.Where(s => s.Active == true);
            foreach (SiteItem site in results)
            {
                site.Tick++;
            }
        }
    }
}
