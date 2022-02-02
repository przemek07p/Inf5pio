using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRANCH_CAR_MANAGER
{
    public partial class BRANCH : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public BRANCH()
        {
            InitializeComponent();
            random = new Random();
            buttonBack.Visible = false;
        }

        private void BRANCH_CAR_MANAGER_Load(object sender, EventArgs e)
        {

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(Theme.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Theme.ColorList.Count);
            }
            tempIndex = index;
            string color = Theme.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Theme.PrimaryColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = Theme.PrimaryColor;
                    panelLogo.BackColor = Theme.ChangeColorBrightness(Theme.PrimaryColor, -0.3);
                    Theme.PrimaryColor = color;
                    Theme.SecondaryColor = Theme.ChangeColorBrightness(color, -0.3);
                    buttonBack.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMainPanel.Controls.Add(childForm);
            this.panelMainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void buttonCars_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCars(), sender);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUsers(), sender);
        }

        private void buttonManagers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormManagers(), sender);
        }

        private void buttonCompanies_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCompanies(), sender);
        }

        private void buttonAccesses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAccesses(), sender);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            panelTitleBar.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            buttonBack.Visible = false;
        }
    }
}
