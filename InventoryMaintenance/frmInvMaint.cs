using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        private List<InvItem> invItem = null; // list st to null

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
           // A statement here that gets the list of items.
            invItem = InvItemDB.GetItems();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            foreach (InvItem i in invItem)
            {
                lstItems.Items.Add(i.GetDisplayText());

            }
        }

        // Samuel and Fatima - 05/28/2022
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add code here that creates an instance of the New Item form
            // and then gets a new item from that form.
            frmNewItem newItemForm = new frmNewItem();
            InvItem invItem = newItemForm.GetNewItem();
            if (invItem != null)
            {
                invItem.Add(invItem);
                InvItemDB.SaveItems(invItem);
                FillItemListBox();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e, InvItem invItem)
        {
            // Add code here that displays a dialog box to confirm
            // the deletion and then removes the item from the list,
            // saves the list of products, and refreshes the list box
            // if the deletion is confirmed.

            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                InvItem InvItem = (InvItem)invItem;
                string message = "Are you sure you want to delete" + "?";
                DialogResult button = MessageBox.Show(message, " Confirm Delete",

                    MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    invItem.Remove(invItem);
                    InvItemDB.SaveItems(invItem);
                    FillItemListBox();
                }

                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
