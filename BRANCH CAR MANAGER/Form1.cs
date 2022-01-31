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
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  
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
        

        private void buttonCars_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonManagers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonCompanies_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonAccesses_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
