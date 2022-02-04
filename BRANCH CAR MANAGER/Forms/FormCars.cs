using database.entities;
using database.repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BRANCH_CAR_MANAGER.Forms
{
    public partial class FormCars : Form
    {
        readonly IUnitOfWork _unitOfWork;

        public FormCars()
        {
           
            InitializeComponent();
            LoadTheme();
        }

       
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Theme.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Theme.SecondaryColor;
                }
            }
            label4.ForeColor = Theme.SecondaryColor;
            label5.ForeColor = Theme.PrimaryColor;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Wyswietl_Click();
        }

        private void Wyswietl_Click()
        {
            throw new NotImplementedException();
        }

        private void Wyswietl_Click(object sender, EventArgs e)
        {
            PobierzDane();
        }
       public void PobierzDane()
        {
            Car item = _unitOfWork.CarRepository.GetById(1);
            
        }
    }
}
