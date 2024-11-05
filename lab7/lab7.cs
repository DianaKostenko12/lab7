using lab7.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class lab7 : Form
    {
        private List<Car> cars = new List<Car>();
        private List<Express> Expresss = new List<Express>();
        private int carIndex = 0;
        private int ExpressIndex = 0;

        public lab7()
        {
            InitializeComponent();
            string[] gearbox = { "Механічна", "Автоматична" };
            comboBox1.Items.AddRange(gearbox);

            string[] routes = { "Київ-Ромни", "Харків-Львів", "Тернопіль-Донецьк", "Херсон-Луцьк", "Житомир-Дніпро"};
            txtExpressRoute.Items.AddRange(routes);

            string[] serviceTypes = { "Люкс", "Купе", "Плацкарт"};
            txtExpressServiceClass.Items.AddRange(serviceTypes);
        }

        public void btnAddCar_Click(object sender, EventArgs e)
        {
            Car newCar = new Car(
                txtCarBrand.Text,
                Convert.ToInt32(txtCarSpeed.Text),
                Convert.ToInt32(txtCarYear.Text),
                txtCarModel.Text,
                txtCarFuelType.Text,
                Convert.ToInt32(txtCarDoors.Text),
                comboBox1.Text,
                txtCarColor.Text);

            cars.Add(newCar);
            UpdateCarDisplay();
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            if (cars.Count > 0)
            {
                cars.RemoveAt(carIndex);
                if (carIndex >= cars.Count) carIndex--;
                UpdateCarDisplay();
            }
        }

        private void btnNextCar_Click(object sender, EventArgs e)
        {
            if (cars.Count > 0)
            {
                carIndex = (carIndex + 1) % cars.Count;
                UpdateCarDisplay();
            }
        }

        private void btnPreviousCar_Click(object sender, EventArgs e)
        {
            if (cars.Count > 0)
            {
                carIndex = (carIndex - 1 + cars.Count) % cars.Count;
                UpdateCarDisplay();
            }
        }

        private void UpdateCarDisplay()
        {
            if (cars.Count > 0)
            {
                var car = cars[carIndex];
                txtCarBrand.Text = car.Brand;
                txtCarModel.Text = car.Model;
                txtCarFuelType.Text = car.FuelType;
                txtCarDoors.Text = car.Doors.ToString();
                txtCarColor.Text = car.Color;
                txtCarSpeed.Text = car.Speed.ToString();
                txtCarYear.Text = car.Year.ToString();
                comboBox1.Text = car.GearBox;
            }
            else
            {
                txtCarBrand.Clear();
                txtCarModel.Clear();
                txtCarFuelType.Clear();
                txtCarDoors.Clear();
                txtCarColor.Clear();
                txtCarSpeed.Clear();
                txtCarYear.Clear();
                comboBox1.SelectedIndex = -1;
            }
        }


        private void btnAddExpress_Click(object sender, EventArgs e)
        {
            bool txtHighSpeed = radioButton1.Checked ? true : false;
           
            Express newExpress = new Express(
                txtExpressBrand.Text,
                Convert.ToInt32(txtExpressSpeed.Text),
                Convert.ToInt32(txtExpressYear.Text),
                txtExpressModel.Text,
                Convert.ToInt32(txtExpressCarriages.Text),
                Convert.ToInt32(txtExpressPassengerCapacity.Text),
                txtExpressRoute.Text,
                Convert.ToDouble(txtExpressTravelTime.Text),
                txtHighSpeed,
                txtExpressServiceClass.Text,
                txtExpressCatering.Text,
                wifiAvailable.Checked);

            Expresss.Add(newExpress);
            UpdateExpressDisplay();
        }

        private void btnRemoveExpress_Click(object sender, EventArgs e)
        {
            if (Expresss.Count > 0)
            {
                Expresss.RemoveAt(ExpressIndex);
                if (ExpressIndex >= Expresss.Count) ExpressIndex--;
                UpdateExpressDisplay();
            }
        }

        private void UpdateExpressDisplay()
        {
            expressPanel.Controls.Clear();
            //foreach (var express in Express)
            //{

            //}
            if (Expresss.Count > 0)
            {
                var Express = Expresss[ExpressIndex];
                txtExpressBrand.Text = Express.Brand;
                txtExpressModel.Text = Express.Model;
                txtExpressCarriages.Text = Express.Carriages.ToString();
                txtExpressPassengerCapacity.Text = Express.PassengerCapacity.ToString();
                txtExpressRoute.Text = Express.Route;
                txtExpressTravelTime.Text = Express.TravelTime.ToString();
                radioButton1.Checked = Express.IsHighSpeed;
                radioButton2.Checked = !Express.IsHighSpeed;
                txtExpressServiceClass.Text = Express.ServiceClass;
                txtExpressCatering.Text = Express.Catering.ToString();
                wifiAvailable.Checked = Express.WiFIAvailable;
            }
            else
            {
                txtExpressBrand.Clear();
                txtExpressModel.Clear();
                txtExpressCarriages.Clear();
                txtExpressPassengerCapacity.Clear();
                txtExpressRoute.SelectedIndex = -1;
                txtExpressTravelTime.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                txtExpressServiceClass.SelectedIndex = -1;
                txtExpressCatering.Clear();
                wifiAvailable.Checked = false;
            }
        }
    }
}

