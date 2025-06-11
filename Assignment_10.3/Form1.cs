using Assignment_10._3.Data;
using Assignment_10._3.Model;
using Assignment_10._3.Services;

namespace Assignment_10._3
{
    public partial class Form1 : Form
    {
        CRUD crud = new CRUD();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCars.DataSource = crud.GetAllCars();
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;
            txtVin.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtVin.Text = (crud.GetMaxVin() + 1).ToString();
            txtMake.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtYear.Text = string.Empty;
            txtPrice.Text = string.Empty;
            btnSubmit.Enabled = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var vin = dgvCars.CurrentRow.Cells[0].Value;
            if (vin != null)
            {
                var car = crud.FindCar((int)vin);
                if (car != null)
                {
                    txtVin.Text = car.VIN.ToString();
                    txtMake.Text = car.Make;
                    txtModel.Text = car.Model;
                    txtYear.Text = car.Year.ToString();
                    txtPrice.Text = car.Price.ToString();
                    btnUpdate.Enabled = true;
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMake.Text) || string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            var car = new Car
            {
                VIN = int.Parse(txtVin.Text),
                Make = txtMake.Text,
                Model = txtModel.Text,
                Year = int.Parse(txtYear.Text),
                Price = double.Parse(txtPrice.Text)
            };
            crud.UpdateCar(car.VIN, car);
            dgvCars.DataSource = crud.GetAllCars();
            btnUpdate.Enabled = false;
            txtVin.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
            MessageBox.Show("Car updated successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var vin = dgvCars.CurrentRow.Cells[0].Value;
            if (vin != null)
            {
                crud.DeleteCar((int)vin);
                dgvCars.DataSource = crud.GetAllCars();
                txtVin.Text = string.Empty;
                txtMake.Text = string.Empty;
                txtModel.Text = string.Empty;
                txtYear.Text = string.Empty;
                txtPrice.Text = string.Empty;
                btnUpdate.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCars.DataSource = crud.GetAllCars();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMake.Text) || string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            var car = new Car
            {
                VIN = int.Parse(txtVin.Text),
                Make = txtMake.Text,
                Model = txtModel.Text,
                Year = int.Parse(txtYear.Text),
                Price = double.Parse(txtPrice.Text)
            };
            crud.AddCar(car);
            MessageBox.Show("Car added successfully!");
            dgvCars.DataSource = crud.GetAllCars();
            btnSubmit.Enabled = false;
            txtVin.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
        }
    }
}
