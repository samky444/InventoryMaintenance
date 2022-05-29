using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {       // Samuel and Fatima -- 05/28/2022
        public frmNewItem()
        {
            InitializeComponent();
        }

        // Add a statement here that declares the inventory item.         

        private InvItem invItem = null;  // initial value of null
        public InvItem GetNewItem() // public method that displays the form as a dialog box
        {
            this.ShowDialog();
            return invItem; // Add a method here that gets and returns a new item.
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())  // creates a new InvItem and closses if the data is valid
            {
                invItem = new InvItem(Convert.ToInt32(txtItemNo.Text),
                txtDescription.Text, Convert.ToDecimal(txtPrice.Text));
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewItem_Load(object sender, EventArgs e)
        {

        }
    }
}
