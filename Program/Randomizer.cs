using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBDRandomizer
{
    public partial class Randomizer : Form
    {
        public Randomizer()
        {
            InitializeComponent();

            // Set window title with the correct version
            this.Text = $"Dead by Daylight Randomiser Tool | v{Application.ProductVersion}";

            survivorPerkList.SmallImageList = new ImageList();
            survivorPerkList.SmallImageList.ImageSize = new Size(64, 64);
            killerPerkList.SmallImageList = new ImageList();
            killerPerkList.SmallImageList.ImageSize = new Size(64, 64);
        }

        private void onlyNewPerksEveryRollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Randomizer_Load(object sender, EventArgs e)
        {
            string survivorImageLocation = "Assets\\Survivor\\";
            string killerImageLocation = "Assets\\Killer\\";

            Common.LoadImages(survivorImageLocation, survivorPerkList);
            Common.LoadImages(killerImageLocation, killerPerkList);

            // hook up event handlers
            this.survivorPerkList.ItemChecked += SurvivorPerkList_ItemChecked;
            this.killerPerkList.ItemChecked += KillerPerkList_ItemChecked;

            // set initial text once perks are loaded
            UpdateSurvivorLabel();
            UpdateKillerLabel();
        }

        private void survivorSelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in survivorPerkList.Items)
            {
                item.Checked = true;
            }
        }

        private void survivorSelectNoneButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in survivorPerkList.Items)
            {
                item.Checked = false;
            }
        }

        private int GetNumberFromLabel(string text)
        {
            int start = text.IndexOf('[');
            int end = text.IndexOf(']');
            if (start >= 0 && end > start)
            {
                if (int.TryParse(text.Substring(start + 1, end - start - 1), out int val))
                    return val;
            }
            return 4; // default
        }

        private void survivorPerkCountTextbox_Leave(object sender, EventArgs e)
        {
            ApplyTextboxToLabel();
        }

        private void survivorPerkCountTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyTextboxToLabel();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void killerPerkCountTextbox_Leave(object sender, EventArgs e)
        {
            ApplyKillerTextboxToLabel();
        }

        private void killerPerkCountTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyKillerTextboxToLabel();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void killerPerkCountTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void killerSelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in killerPerkList.Items)
            {
                item.Checked = true;
            }
        }

        private void ApplyTextboxToLabel()
        {
            int value;

            if (int.TryParse(survivorPerkCountTextbox.Text, out value))
            {
                if (value < 1) value = 1;
                if (value > 4) value = 4;
            }
            else
            {
                value = 4;
            }

            UpdateSurvivorRandomizeLabel(value);
            survivorPerkCountTextbox.Visible = false;
        }

        private void ApplyKillerTextboxToLabel()
        {
            int value;
            if (int.TryParse(killerPerkCountTextbox.Text, out value))
            {
                if (value < 1) value = 1;
                if (value > 4) value = 4;
            }
            else
            {
                value = 4;
            }

            label9Number.Text = $"[{value}]";
            killerPerkCountTextbox.Visible = false;
        }
        
        private void killerSelectNoneButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in killerPerkList.Items)
            {
                item.Checked = false;
            }
        }

        private void survivorPerkCountTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void survivorRandomizeButton_Click(object sender, EventArgs e)
        {
            int perkCount = int.TryParse(survivorPerkCountTextbox.Text, out var val) ? val : 4;

            // Optional error handling: ensure not more than selected perks
            if (perkCount > survivorPerkList.CheckedItems.Count)
            {
                MessageBox.Show($"You selected fewer perks ({survivorPerkList.CheckedItems.Count}) than the desired randomise count ({perkCount}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPerks = Common.RandomizePerks(perkCount, survivorPerkList, onlyNewPerksEveryRollToolStripMenuItem.Checked);

            PictureBox[] pictures = { survivorPerkImage1, survivorPerkImage2, survivorPerkImage3, survivorPerkImage4 };
            Label[] labels = { survivorPerkLabel1, survivorPerkLabel2, survivorPerkLabel3, survivorPerkLabel4 };

            for (int i = 0; i < selectedPerks.Count; i++)
            {
                pictures[i].Image = selectedPerks[i].Img;
                labels[i].Text = selectedPerks[i].Name;
            }

            for (int i = selectedPerks.Count; i < 4; i++)
            {
                pictures[i].Image = null;
                labels[i].Text = "";
            }
        }

        private void label2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            survivorPerkCountTextbox.Visible = true;
            survivorPerkCountTextbox.BringToFront();
            survivorPerkCountTextbox.Focus();
            survivorPerkCountTextbox.SelectAll();
        }

        private void label9Number_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            killerPerkCountTextbox.Visible = true;
            killerPerkCountTextbox.BringToFront();
            killerPerkCountTextbox.Text = GetNumberFromLabel(label9Number.Text).ToString();
            killerPerkCountTextbox.Focus();
            killerPerkCountTextbox.SelectAll();
        }

        private void killerRandomizeButton_Click(object sender, EventArgs e)
        {
            int perkCount = GetNumberFromLabel(label9Number.Text);

            var selectedPerks = Common.RandomizePerks(perkCount, killerPerkList, onlyNewPerksEveryRollToolStripMenuItem.Checked);

            if (selectedPerks.Count < perkCount)
            {
                MessageBox.Show(
                    $"You selected fewer perks ({selectedPerks.Count}) than the desired randomise count ({perkCount}).",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            PictureBox[] pictures = { killerPerkImage1, killerPerkImage2, killerPerkImage3, killerPerkImage4 };
            Label[] labels = { killerPerkLabel1, killerPerkLabel2, killerPerkLabel3, killerPerkLabel4 };

            for (int i = 0; i < selectedPerks.Count; i++)
            {
                pictures[i].Image = selectedPerks[i].Img;
                labels[i].Text = selectedPerks[i].Name;
            }

            for (int i = selectedPerks.Count; i < 4; i++)
            {
                pictures[i].Image = null;
                labels[i].Text = "";
                    }
                }

        private void UpdateSurvivorLabel()
{
    int total = survivorPerkList.Items.Cast<ListViewItem>()
                 .Count(item => item.ImageIndex >= 0); // only items with an image
    int selected = survivorPerkList.CheckedItems.Count;

    this.label1.Text = $"1. Select available perks ({selected} of {total}):";
}
        private void UpdateSurvivorRandomizeLabel(int count)
        {
            label2Number.Text = $"[{count}]";
        }

private void UpdateKillerLabel()
{
    int total = killerPerkList.Items.Cast<ListViewItem>()
                 .Count(item => item.ImageIndex >= 0); // only items with an image
    int selected = killerPerkList.CheckedItems.Count;

    this.label10.Text = $"1. Select available perks ({selected} of {total}):";
}

        private void SurvivorPerkList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            UpdateSurvivorLabel();
        }

        private void KillerPerkList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            UpdateKillerLabel();
        }
    }
}

