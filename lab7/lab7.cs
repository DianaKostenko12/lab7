﻿using lab7.Models;
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
        private int expressIndex = 0;

        public lab7()
        {
            InitializeComponent();
            string[] gearbox = { "Механічна", "Автоматична" };
            comboBox1.Items.AddRange(gearbox);

            string[] routes = { "Київ-Ромни", "Харків-Львів", "Тернопіль-Донецьк", "Херсон-Луцьк", "Житомир-Дніпро" };
            txtExpressRoute.Items.AddRange(routes);

            string[] serviceTypes = { "Люкс", "Купе", "Плацкарт" };
            txtExpressServiceClass.Items.AddRange(serviceTypes);

            
            InitializeExpressData();
            ShowExpress();
            //btnNextExpress.Click += BtnNextExpress_Click;
            //btnPreviousExpress.Click += BtnPreviousExpress_Click;
        }

        private void InitializeExpressData()
        {
            Expresss.Add(new Express("Hyundai", 180, 2020, "H1", 10, 200, "Київ-Ромни", 2.5, true, "Люкс", "Закуски", true));
            Expresss.Add(new Express("Siemens", 220, 2018, "S2", 8, 150, "Харків-Львів", 3.0, false, "Купе", "Закуски та напої", true));
            Expresss.Add(new Express("Bombardier", 200, 2019, "B1", 12, 250, "Тернопіль-Донецьк", 4.0, true, "Плацкарт", "Без", false));
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

            //Express newExpress = new Express(
            //    txtExpressBrand.Text,
            //    Convert.ToInt32(txtExpressSpeed.Text),
            //    Convert.ToInt32(txtExpressYear.Text),
            //    txtExpressModel.Text,
            //    Convert.ToInt32(txtExpressCarriages.Text),
            //    Convert.ToInt32(txtExpressPassengerCapacity.Text),
            //    txtExpressRoute.Text,
            //    Convert.ToDouble(txtExpressTravelTime.Text),
                
            //    txtExpressServiceClass.Text,
            //    txtExpressCatering.Text,
            //    wifiAvailable.Checked);

            //Expresss.Add(newExpress);
            //expressIndex = Expresss.Count - 1;
            //UpdateExpressDisplay();
        }

        private void ShowFirstExpress(int index)
        {
            if (index == -1)
            {
                txtExpressBrand.Text = " ";
                txtExpressSpeed.Text = " ";
                txtExpressYear.Text = " ";
                txtExpressModel.Text = " ";
                txtExpressCarriages.Text = " ";
                txtExpressPassengerCapacity.Text = " ";
                txtExpressRoute.Text = " ";
                txtExpressTravelTime.Text = " ";
                highSpeed1.Checked = false;
                txtExpressServiceClass.SelectedIndex = -1;
                txtExpressCatering.Text = " ";
                wifiAvailable.Checked = false;
            }
            else
            { 
                var express = Expresss[index];
                txtExpressBrand.Text = express.Brand;
                txtExpressSpeed.Text = express.Speed.ToString();
                txtExpressYear.Text = express.Year.ToString();
                txtExpressModel.Text = express.Model;
                txtExpressCarriages.Text = express.Carriages.ToString();
                txtExpressPassengerCapacity.Text = express.PassengerCapacity.ToString();
                txtExpressRoute.Text = express.Route;
                txtExpressTravelTime.Text = express.TravelTime.ToString();
                highSpeed1.Checked = express.IsHighSpeed;
                txtExpressServiceClass.Text = express.ServiceClass;
                txtExpressCatering.Text = express.Catering;
                wifiAvailable.Checked = express.WiFIAvailable;
            }
        }

        private void ShowSecondExpress(int index)
        {
            if (index == -1)
            {
                txtExpressBrand1.Text = " ";
                txtExpressSpeed1.Text = " ";
                txtExpressYear1.Text = " ";
                txtExpressModel1.Text = " ";
                txtExpressCarriages1.Text = " ";
                txtExpressPassengerCapacity1.Text = " ";
                txtExpressRoute1.Text = " ";
                txtExpressTravelTime1.Text = " ";
                highSpeed2.Checked = false;
                txtExpressServiceClass1.SelectedIndex = -1;
                txtExpressCatering1.Text = " ";
                wifiAvailable1.Checked = false;
            }
            else
            {
                var express = Expresss[index];
                txtExpressBrand1.Text = express.Brand;
                txtExpressSpeed1.Text = express.Speed.ToString();
                txtExpressYear1.Text = express.Year.ToString();
                txtExpressModel1.Text = express.Model;
                txtExpressCarriages1.Text = express.Carriages.ToString();
                txtExpressPassengerCapacity1.Text = express.PassengerCapacity.ToString();
                txtExpressRoute1.Text = express.Route;
                txtExpressTravelTime1.Text = express.TravelTime.ToString();
                highSpeed2.Checked = express.IsHighSpeed;
                txtExpressServiceClass1.Text = express.ServiceClass;
                txtExpressCatering1.Text = express.Catering;
                wifiAvailable1.Checked = express.WiFIAvailable;
            }
        }
        private void ShowThirdExpress(int index)
        {
            if (index == -1)
            {
                txtExpressBrand2.Text = " ";
                txtExpressSpeed2.Text = " ";
                txtExpressYear2.Text = " ";
                txtExpressModel2.Text = " ";
                txtExpressCarriages2.Text = " ";
                txtExpressPassengerCapacity2.Text = " ";
                txtExpressRoute2.Text = " ";
                txtExpressTravelTime2.Text = " ";
                highSpeed3.Checked = false;
                txtExpressServiceClass2.SelectedIndex = -1;
                txtExpressCatering2.Text = " ";
                wifiAvailable2.Checked = false;
            }
            else
            {
                var express = Expresss[index];
                txtExpressBrand2.Text = express.Brand;
                txtExpressSpeed2.Text = express.Speed.ToString();
                txtExpressYear2.Text = express.Year.ToString();
                txtExpressModel2.Text = express.Model;
                txtExpressCarriages2.Text = express.Carriages.ToString();
                txtExpressPassengerCapacity2.Text = express.PassengerCapacity.ToString();
                txtExpressRoute2.Text = express.Route;
                txtExpressTravelTime2.Text = express.TravelTime.ToString();
                highSpeed3.Checked = express.IsHighSpeed;
                txtExpressServiceClass2.Text = express.ServiceClass;
                txtExpressCatering2.Text = express.Catering;
                wifiAvailable2.Checked = express.WiFIAvailable;
            }
        }

        private void ShowExpress()
        {
            if (Expresss.Count > 0)
            {
                ShowFirstExpress(0);
                if (Expresss.Count > 1) ShowSecondExpress(1);
                if (Expresss.Count > 2) ShowThirdExpress(2);
            }
            else
            {
                ShowFirstExpress(-1);
                ShowSecondExpress(-1);
                ShowThirdExpress(-1);
            }
        }

        private void btnRemoveExpress_Click(object sender, EventArgs e)
        {
            if (Expresss.Count > 0)
            {
                Expresss.RemoveAt(expressIndex);
                if (expressIndex >= Expresss.Count) expressIndex--;
                UpdateExpressDisplay();
            }
        }

        private void UpdateExpressDisplay()
        {
            if (Expresss.Count > 0)
            {
                var express = Expresss[expressIndex];

                txtExpressBrand.Text = express.Brand;
                txtExpressModel.Text = express.Model;
                txtExpressCarriages.Text = express.Carriages.ToString();
                txtExpressPassengerCapacity.Text = express.PassengerCapacity.ToString();
                txtExpressRoute.Text = express.Route;
                txtExpressTravelTime.Text = express.TravelTime.ToString();
                //h.Checked = false;
                txtExpressServiceClass.Text = express.ServiceClass;
                txtExpressCatering.Text = express.Catering;
                wifiAvailable.Checked = express.WiFIAvailable;
            }
            else
            {
                ClearExpressDisplay();
            }
        }

        private void ClearExpressDisplay()
        {
            txtExpressBrand.Clear();
            txtExpressModel.Clear();
            txtExpressCarriages.Clear();
            txtExpressPassengerCapacity.Clear();
            txtExpressRoute.SelectedIndex = -1;
            txtExpressTravelTime.Clear();
            //hi.Checked = false;
            txtExpressServiceClass.SelectedIndex = -1;
            txtExpressCatering.Clear();
            wifiAvailable.Checked = false;
        }
        private void RemoveExpress(Express express)
        {
            Expresss.Remove(express);
            UpdateExpressDisplay();
        }

        private void BtnNextExpress_Click(object sender, EventArgs e)
        {
            if (Expresss.Count > 0)
            {
                expressIndex = (expressIndex + 1) % Expresss.Count;
                UpdateExpressDisplay();
            }
        }

        private void BtnPreviousExpress_Click(object sender, EventArgs e)
        {
            if (Expresss.Count > 0)
            {
                expressIndex = (expressIndex - 1 + Expresss.Count) % Expresss.Count;
                UpdateExpressDisplay();
            }
        }
    }
}

