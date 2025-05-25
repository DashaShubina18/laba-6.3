using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using laba6_3;



namespace laba6_3
{
    public partial class fBicycle : Form
    {
        private BaseBicycle bicycle;
        public fBicycle(BaseBicycle)
        {
            InitializeComponent();
            this.bicycle = bicycle;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {

            bicycle.Model = tbModel.Text.Trim();
            bicycle.Year = int.Parse(tbYear.Text.Trim());
            bicycle.Colour = tbColour.Text.Trim();
            bicycle.Price = double.Parse(tbPrice.Text.Trim());
            bicycle.FrameLoadCapacity = int.Parse(tbFrameLoadCapacity.Text.Trim());
            bicycle.Weight = double.Parse(tbWeight.Text.Trim());
            bicycle.WasUsed = chbWasUsed.Checked;
            bicycle.WasDamaged = chbWasDamaged.Checked;

            DialogResult = DialogResult.OK;
            this.Close();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void fBicycle_Load(object sender, EventArgs e)
        {

            if (bicycle != null)
            {
                tbModel.Text = bicycle.Model;
                tbYear.Text = bicycle.Year.ToString();
                tbColour.Text = bicycle.Colour;
                tbFrameLoadCapacity.Text = bicycle.FrameLoadCapacity.ToString();
                tbPrice.Text = bicycle.Price.ToString("0.00");
                tbWeight.Text = bicycle.Weight.ToString("0.00");
                chbWasUsed.Checked = bicycle.WasUsed;
                chbWasDamaged.Checked = bicycle.WasDamaged;
            }

        }


    }
}

