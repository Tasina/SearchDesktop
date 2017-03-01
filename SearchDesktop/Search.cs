using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchDesktop
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            SetupForm();
            SetupItems();
            PopulateItems();
        }
        private void SetupForm()
        {
            ControlBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void SetupItems()
        {
            btnClose.BackColor = Color.FromArgb(50, Color.White);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);

            btnMinimaz.BackColor = Color.FromArgb(50, Color.White);
            btnMinimaz.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);


            btnHelp.BackColor = Color.FromArgb(50, Color.White);
            btnHelp.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);

            btnSearch.BackColor = Color.FromArgb(50, Color.Black);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.Black);

            btnOpenFile.BackColor = Color.FromArgb(50, Color.White);
            btnOpenFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);

            InfoPanel.BackColor = Color.FromArgb(75, Color.Black);

            lblFileName.BackColor = Color.Transparent;
            lblFilePath.BackColor = Color.Transparent;
            lblInfo.BackColor = Color.Transparent;
            lblSnippet.BackColor = Color.Transparent;


            lblFileName.Parent = InfoPanel;

        }

        private void PopulateItems()
        {

            string[] myItems = { "Item", "Column1Text /n awgag", "Column1Text /n awgag", "Column1Text /n awgag", "Column1Text /n awgag", "Column1Text /n awgag" };

            ColumnHeader item;
            item = new ColumnHeader();
            item.Text = "Item";
            item.TextAlign = HorizontalAlignment.Left;
            item.Width = 390;

            Result.Columns.Add(item);
            Result.View = View.Details;

            //ListViewItem Litem = new ListViewItem("Column1Text /n awgag");
            //Litem.SubItems.Add("Column1Text /n awgag");
            //Result.Items.Add(Litem);


            if (myItems != null)
            {
                foreach (string file in myItems)
                {
                    ListViewItem Litem = new ListViewItem(file);
                    Litem.SubItems.Add(file);
                    Result.Items.Add(Litem);
                }
            }



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }



        //Topbar Options
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimaz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
