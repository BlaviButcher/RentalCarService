using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Waikato_Driveways
{
    
    public partial class RentalForm : Form
    {
        //####################################################################
        //# Instance Variable
        private DateTime _wofDue;
        private DateTime _dateDue;
        private BindingList<RentalCar> _list;
        //Variable to hold whether the code can create object after checking for errors
        private bool proceed = true;
        //Begin in fleet view
        static bool _maintainanceView = false;
        //####################################################################
        //# Constructor
        public RentalForm()
        {
            InitializeComponent();
            //Bind combo boxes to Enum list
            _vehicleTypeComboBox.DataSource = Enum.GetValues(typeof(VehicleType));
            _navigationComboBox.DataSource = Enum.GetValues(typeof(NavigationType));
            _fuelTypeComboBox.DataSource = Enum.GetValues(typeof(FuelType));
            _lentTypeComboBox.DataSource = Enum.GetValues(typeof(LentType));
            //If all of list == true then code may run
            
            //Initialize the RentalCars list.
            _list = new BindingList<RentalCar>();
            //assign list to be data source
            _listBox.DataSource = _list;

            InitialiseListOfCars();

        }


        //####################################################################
        //# Private Methods


        private void InitialiseListOfCars()
        {
            //Initialise starting cars in lot
            
            _list.Add(new RentalCar("8DF9G1", VehicleType.Budget_Hatchback, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("25/1/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GD", VehicleType.Budget_Hatchback, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("24/1/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GR", VehicleType.Budget_Hatchback, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("10/2/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GT", VehicleType.Campervan, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("25/1/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GY", VehicleType.Campervan, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("1/4/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GU", VehicleType.Campervan, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("30/10/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GI", VehicleType.Economy_Sedan, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("23/1/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GO", VehicleType.Economy_Sedan, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("10/5/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GP", VehicleType.Economy_Sedan, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("10/7/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GA", VehicleType.FourWheel_Drive, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("10/8/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GS", VehicleType.FourWheel_Drive, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("23/1/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GG", VehicleType.FourWheel_Drive, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("10/2/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GH", VehicleType.MiniBus, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("10/4/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GJ", VehicleType.MiniBus, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("10/3/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GK", VehicleType.MiniBus, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("10/11/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GL", VehicleType.Budget_Hatchback, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("10/12/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GZ", VehicleType.Budget_Hatchback, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("10/6/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GX", VehicleType.Budget_Hatchback, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("10/5/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GC", VehicleType.Budget_Hatchback, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("26/1/2020"), LentType.In, DateTime.Parse("10/10/10")));
            _list.Add(new RentalCar("8DF9GV", VehicleType.Budget_Hatchback, NavigationType.Has_GPS, FuelType.Electric, 10, DateTime.Parse("10/6/2020"), LentType.In, DateTime.Parse("10/10/10")));



        }
        //Try parsing everything before creating object to find errors
        private void TryParsing()
        {
            //Stops program from creating object
            

            //WofDueDate has error when parsing (if)
            if (!DateTime.TryParse(_wofDueTextBox.Text, out _wofDue))
            {

                MessageBox.Show("Date of 'WOF Due' is in incorrect format.");
                proceed = false;
            }
            else
            {
                
            }
            //DateDueBack has error when parsing (if)
            if (!DateTime.TryParse(_wofDueTextBox.Text, out _dateDue))
            {

                MessageBox.Show("Date of 'WOF Due' is in incorrect format.");
                proceed = false;
            }
            else
            {

            }
        }

        /// <summary>
        /// Checks to see if a rego plate is already in the business
        /// Checks that length of rego plate is appropriate (6-8 inclusive)
        /// </summary>
        /// <returns></returns>
        private string CheckRegoPlate()
        {

            //Make regoplate uppercase
            string regoPlate = _regoTextBox.Text.ToUpper();
            int count = 0;
            
            //count characters in string
            foreach (char c in regoPlate)
            {
                count++;    
            }
            //If less than six - error
            if (count < 6)
            {
                MessageBox.Show("The regastration is to short. Please enter regastration between 6 and 8 characters inclusive");
                proceed = false;
            }
            //If greater than 8 - error
            else if (count > 8)
            {
                MessageBox.Show("The regastration is to long. Please enter regastration between 6 and 8 characters inclusive");
                proceed = false;
            }
            //Check if rego plate is already in the system
            
            foreach (RentalCar car in _list)
            {
                if (car.RegoPlateNumber == regoPlate)
                {
                    MessageBox.Show("This registration place is already in the business.");
                    proceed = false;
                    break;
                }
                
            }

            return regoPlate;
        }
        /// <summary>
        /// Cleans up look of GPS
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public string MakeNavigationPretty(RentalCar car)
        {
            string cleanGps;
            if (car.NavigationSystem == NavigationType.Has_GPS)
            {
                cleanGps = "Has GPS";
            }
            else
            {
                cleanGps = "No GPS";
            }
            return cleanGps;
        }

        private void AddCarToFleet()
        {
            //Check for errors
            TryParsing();
            //Check for errors in date. Convert to string
            
            string regoPlate = CheckRegoPlate();
            //Create object and add to list
            if (proceed == true)
            {
                
                //Create car object
                RentalCar car = new RentalCar(regoPlate, (VehicleType)_vehicleTypeComboBox.SelectedItem, (NavigationType)_navigationComboBox.SelectedItem,
                    (FuelType)_fuelTypeComboBox.SelectedItem, decimal.Parse(_rentalRateTextBox.Text), _wofDue, (LentType)_lentTypeComboBox.SelectedItem, _dateDue);

                //Add object to list
                _list.Add(car);
                
            }
            proceed = true;
                
        }
        //####################################################################
        //# Event Handlers
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            AddCarToFleet();
        }


        /// <summary>
        /// If line of listbox is clicked, ouput its properties to controlboxes/textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If the list box selection is not empty ...
            if (_listBox.SelectedIndex >= 0)
            {
                // Find the selected index
                int index = _listBox.SelectedIndex;
                // Get the item at that position from the list
                RentalCar car = _list[index];
                // Put the name of item properties in controls/textboxes
                _regoTextBox.Text = car.RegoPlateNumber;
                _vehicleTypeComboBox.SelectedItem = car.CarType;
                _navigationComboBox.SelectedItem = car.NavigationSystem;
                _fuelTypeComboBox.SelectedItem = car.FuelSource;
                _rentalRateTextBox.Text = car.RentalRate.ToString();
                _wofDueTextBox.Text = car.WofDue.ToString("d");
                _lentTypeComboBox.SelectedItem = car.LentOut;
                _dateDueBackTextBox.Text = car.DateDueBack.ToString("d");

               
                
            }
        }
        /// <summary>
        /// If replace button is clicked. Change listbox item to reflect controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _replaceButton_Click(object sender, EventArgs e)
        {
            // If the list box selection is not empty ...
            if (_listBox.SelectedIndex >= 0)
            {
                TryParsing();

                
                // Get the selected car item
                RentalCar car = _list[_listBox.SelectedIndex];
                //Hold selected index
                int i = _listBox.SelectedIndex;
                
                //This stops the program from throwing an error when the rego number is unchanged
                string regoPlate;
                if (!(_regoTextBox.Text == car.RegoPlateNumber))
                {
                    regoPlate = CheckRegoPlate();
                }
                else
                {
                    regoPlate = car.RegoPlateNumber;
                }


                //If there are no errors
                if (proceed == true)
                {
                    
                    // Change object properties to match controls/textboxes
                    car.RegoPlateNumber = regoPlate;
                    car.CarType = (VehicleType)_vehicleTypeComboBox.SelectedItem;
                    car.NavigationSystem = (NavigationType)_navigationComboBox.SelectedItem;
                    car.FuelSource = (FuelType)_fuelTypeComboBox.SelectedItem;
                    
                    car.WofDue = _wofDue;
                    car.LentOut = (LentType)_lentTypeComboBox.SelectedItem;
                    car.DateDueBack = _dateDue;
                }


                // Re-assign list position (avoid redraw problem)
                _list[_listBox.SelectedIndex] = car;
                //Needed to clear selection and reselect in order to allow the cars draw consitently.
                _listBox.ClearSelected();
                _listBox.SelectedIndex = i;
                
                
               
            }
            proceed = true;
        }

        private void _deleteButton_Click(object sender, EventArgs e)
        {
           //Create list
            List<int> selection = new List<int>();
            foreach (int index in _listBox.SelectedIndices)
            {
                //Add items to list
                selection.Add(index);
            }
            //Sort the selected indices with largest last
            selection.Sort();
            //Delete from back of list.
            for (int i = selection.Count - 1; i >= 0; i--)
            {
                //Remove item from object list _list
                int index = selection[i];
                _list.RemoveAt(index);
            }
            //Clear the list box selection.
            _listBox.ClearSelected();
        }


        /// <summary>
        /// Gets the enumerator type VehicleType. And draws a vehicle depending on what it recieves.
        /// Also draws all other items from _list into the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _listBox_DrawItem(object sender, DrawItemEventArgs e)
        {

            
            e.DrawBackground();
            e.DrawFocusRectangle();
            int index = e.Index;
            if (index >= 0)
            {
               //gets object of current index
                RentalCar car = _list[e.Index];
                //create brush
                Brush brush = new SolidBrush(e.ForeColor);
                //create graphics
                Graphics graphics = e.Graphics;
                
                //Create boundries
                Rectangle bounds = e.Bounds;
                
                //Placement of cars (needs fixing)
                bounds.X = (int)(_listBox.Width * 0.14);
                //Icon perametres
                int iconHeight = bounds.Height - 3;
                int iconWidth = 40;

                //If statements to draw car depending on what it recieves
                //Using iconHeight and Width as a box rather than listBox.width and height
                //Draw MiniBus
                if (car.CarType == VehicleType.MiniBus)
                {
                    //setting variables
                    int y0 = bounds.Top + Convert.ToInt32(0.01 * iconHeight);
                    int y1 = bounds.Top + Convert.ToInt32(0.13 * iconHeight);
                    int y2 = bounds.Top + Convert.ToInt32(0.25 * iconHeight);
                    int y3 = bounds.Top + Convert.ToInt32(0.37 * iconHeight);
                    int y4 = bounds.Top + Convert.ToInt32(0.49 * iconHeight);
                    int y5 = bounds.Top + Convert.ToInt32(0.90 * iconHeight);


                    int x0 = bounds.Left + Convert.ToInt32(0.16 * iconWidth);
                    int x1 = bounds.Left + Convert.ToInt32(0.24 * iconWidth);
                    int x2 = bounds.Left + Convert.ToInt32(0.28 * iconWidth);
                    int x3 = bounds.Left + Convert.ToInt32(0.32 * iconWidth);
                    int x4 = bounds.Left + Convert.ToInt32(0.36 * iconWidth);
                    int x5 = bounds.Left + Convert.ToInt32(0.80 * iconWidth);
                    int x6 = bounds.Left + Convert.ToInt32(0.84 * iconWidth);
                    int x7 = bounds.Left + Convert.ToInt32(0.88 * iconWidth);
                    int x8 = bounds.Left + Convert.ToInt32(0.92 * iconWidth);
                    int x9 = bounds.Left + Convert.ToInt32(0.98 * iconWidth);

                    //Plotting points
                    Point[] points = new Point[12];
                    points[0] = new Point(x0, y4);
                    points[1] = new Point(x1, y3);
                    points[2] = new Point(x2, y2);
                    points[3] = new Point(x3, y1);
                    points[4] = new Point(x4, y0);
                    points[5] = new Point(x5, y0);
                    points[6] = new Point(x6, y1);
                    points[7] = new Point(x7, y2);
                    points[8] = new Point(x8, y3);
                    points[9] = new Point(x9, y4);
                    points[10] = new Point(x9, y5);
                    points[11] = new Point(x0, y5);
                    //Filling
                    graphics.FillPolygon(brush, points);

                }
                if (car.CarType == VehicleType.Budget_Hatchback)
                {
                    //Setting variables
                    int y0 = bounds.Top + Convert.ToInt32(0.3 * iconHeight);
                    int y1 = bounds.Top + Convert.ToInt32(0.55 * iconHeight);
                    int y2 = bounds.Top + Convert.ToInt32(0.6 * iconHeight);
                    int y3 = bounds.Top + Convert.ToInt32(0.7 * iconHeight);
                    int y4 = bounds.Top + Convert.ToInt32(0.9 * iconHeight);
                    int y5 = bounds.Top + Convert.ToInt32(0.57 * iconHeight);


                    int x0 = bounds.Left + Convert.ToInt32(0.16 * iconWidth);
                    int x1 = bounds.Left + Convert.ToInt32(0.24 * iconWidth);
                    int x2 = bounds.Left + Convert.ToInt32(0.36 * iconWidth);
                    int x3 = bounds.Left + Convert.ToInt32(0.52 * iconWidth);
                    int x4 = bounds.Left + Convert.ToInt32(0.90 * iconWidth);
                    int x5 = bounds.Left + Convert.ToInt32(0.90 * iconWidth);
                    int x6 = bounds.Left + Convert.ToInt32(0.98 * iconWidth);

                    //Plotting Points
                    Point[] points = new Point[9];
                    //Top of front windshield
                    points[0] = new Point(x3, y0);
                    //Top of back windshield
                    points[1] = new Point(x4, y0);
                    //Bottom of back windshield
                    points[2] = new Point(x6, y1);
                    //Top of bumper
                    points[3] = new Point(x6, y3);
                    //Bottom of bumper
                    points[4] = new Point(x5, y4);
                    //Bottom of fender
                    points[5] = new Point(x0, y4);
                    //top of fender
                    points[6] = new Point(x0, y3);
                    //bottom of front bonnet
                    points[7] = new Point(x1, y2);
                    //top of bonnet bottom of windshield
                    points[8] = new Point(x2, y5);
                    //Filling
                    graphics.FillPolygon(brush, points);
                }
                if (car.CarType == VehicleType.Economy_Sedan)
                {
                    //Setting variables
                    int y0 = bounds.Top + Convert.ToInt32(0.01 * iconHeight);
                    int y1 = bounds.Top + Convert.ToInt32(0.45 * iconHeight);
                    int y2 = bounds.Top + Convert.ToInt32(0.50 * iconHeight);
                    int y3 = bounds.Top + Convert.ToInt32(0.75 * iconHeight);
                    int y4 = bounds.Top + Convert.ToInt32(0.80 * iconHeight);
                    
                    int x0 = bounds.Left + Convert.ToInt32(0.16 * iconWidth);
                    int x1 = bounds.Left + Convert.ToInt32(0.20 * iconWidth);
                    int x2 = bounds.Left + Convert.ToInt32(0.36 * iconWidth);
                    int x3 = bounds.Left + Convert.ToInt32(0.48 * iconWidth);
                    int x4 = bounds.Left + Convert.ToInt32(0.80 * iconWidth);
                    int x5 = bounds.Left + Convert.ToInt32(0.86 * iconWidth);
                    int x6 = bounds.Left + Convert.ToInt32(0.90 * iconWidth);
                    int x7 = bounds.Left + Convert.ToInt32(0.98 * iconWidth);
                    //Plotting points
                    Point[] points = new Point[12];
                    //Top of  front windshield
                    points[0] = new Point(x3, y0);
                    //Top of back windshield
                    points[1] = new Point(x4, y0);
                    //Bottom of back windshield curve to top of boot
                    points[2] = new Point(x5, y1);
                    points[3] = new Point(x6, y1);
                    points[4] = new Point(x7, y2);
                    //Curve from bottom of boot to bottom of car
                    points[5] = new Point(x7, y3);
                    points[6] = new Point(x6, y4);
                    //Curve from bottom front of car to bottom fender
                    points[7] = new Point(x1, y4);
                    points[8] = new Point(x0, y3);
                    //top of fender to top front of bonnet
                    points[9] = new Point(x0, y2);
                    points[10] = new Point(x1, y1);
                    //bottom of windshield
                    points[11] = new Point(x2, y1);
                    //Filling
                    graphics.FillPolygon(brush, points);


                }
                //Draw 4WD
                if (car.CarType == VehicleType.FourWheel_Drive)
                {
                    //Setting variables
                    int y0 = bounds.Top + Convert.ToInt32(0.01 * iconHeight);
                    int y1 = bounds.Top + Convert.ToInt32(0.50 * iconHeight);
                    int y2 = bounds.Top + Convert.ToInt32(0.92 * iconHeight);
                    int y3 = bounds.Top + Convert.ToInt32(iconHeight);

                    int x0 = bounds.Left + Convert.ToInt32(0.16 * iconWidth);
                    int x1 = bounds.Left + Convert.ToInt32(0.20 * iconWidth);
                    int x2 = bounds.Left + Convert.ToInt32(0.30 * iconWidth);
                    int x3 = bounds.Left + Convert.ToInt32(0.46 * iconWidth);
                    int x4 = bounds.Left + Convert.ToInt32(0.80 * iconWidth);
                    int x5 = bounds.Left + Convert.ToInt32(0.90 * iconWidth);
                    int x6 = bounds.Left + Convert.ToInt32(0.98 * iconWidth);
                    //Plotting points
                    Point[] points = new Point[16];
                    //front top of bonnet
                    points[0] = new Point(x0, y1);
                    //bottom of front windshield
                    points[1] = new Point(x2, y1);
                    //top of front windshield
                    points[2] = new Point(x3, y0);
                    //top of back windshield
                    points[3] = new Point(x4, y0);
                    //bottom back windshield
                    points[4] = new Point(x4, y1);
                    //top back boot
                    points[5] = new Point(x6, y1);
                    //bottom of fender
                    points[6] = new Point(x6, y3);
                    //back wheel well
                    points[7] = new Point(x5, y3);
                    points[8] = new Point(x5, y2);
                    points[9] = new Point(x4, y2);
                    points[10] = new Point(x4, y3);
                    //front wheel well
                    points[11] = new Point(x2, y3);
                    points[12] = new Point(x2, y2);
                    points[13] = new Point(x1, y2);
                    points[14] = new Point(x1, y3);
                    //bottom front bumper
                    points[15] = new Point(x0, y3);
                    //Filling
                    graphics.FillPolygon(brush, points);


                }
                
                //Draw Campervan
                if (car.CarType == VehicleType.Campervan)
                {
                    //Setting variables
                    int y0 = bounds.Top + Convert.ToInt32(0.01 * iconHeight);
                    int y1 = bounds.Top + Convert.ToInt32(0.35 * iconHeight);
                    int y2 = bounds.Top + Convert.ToInt32(0.70 * iconHeight);
                    int y3 = bounds.Top + Convert.ToInt32(0.95 * iconHeight);
                    int y4 = bounds.Top + Convert.ToInt32(iconHeight);

                    int x0 = bounds.Left + Convert.ToInt32(0.11 * iconWidth);
                    int x1 = bounds.Left + Convert.ToInt32(0.20 * iconWidth);
                    int x2 = bounds.Left + Convert.ToInt32(0.32 * iconWidth);
                    int x3 = bounds.Left + Convert.ToInt32(0.75 * iconWidth);
                    int x4 = bounds.Left + Convert.ToInt32(0.90 * iconWidth);
                    int x5 = bounds.Left + Convert.ToInt32(0.98 * iconWidth);
                    //Plotting points
                    Point[] points = new Point[14];
                    //Top of grill
                    points[0] = new Point(x0, y2);
                    //bottom of front windshield
                    points[1] = new Point(x2, y1);
                    //top of front windshield
                    points[2] = new Point(x2, y0);
                    //top of back windshield
                    points[3] = new Point(x5, y0);
                    //bottom of fender
                    points[4] = new Point(x5, y4);
                    //Back wheel well
                    points[5] = new Point(x4, y4);
                    points[6] = new Point(x4, y3);
                    points[7] = new Point(x3, y3);
                    points[8] = new Point(x3, y4);
                    //front wheel well
                    points[9] = new Point(x2, y4);
                    points[10] = new Point(x2, y3);
                    points[11] = new Point(x1, y3);
                    points[12] = new Point(x1, y4);
                    //bottom of bumper
                    points[13] = new Point(x0, y4);
                    //Drawing
                    graphics.FillPolygon(brush, points);
                }
                //Reset X boundary to 0 for text to be added
                bounds.X = 0;
                //Same as above
                bounds.Height = _listBox.Height;
                //Display text



                string cleanGps = MakeNavigationPretty(car);
                //Draws the properties with the ability to grow and shink with the form and listbox. At bit buggy on smaller window.
                //Needs more work
                if (_maintainanceView == false)
                {
                    
                    e.Graphics.DrawString(car.RegoPlateNumber, _listBox.Font, brush, bounds);
                    bounds.X = (int)(_listBox.Width * 0.31);
                    e.Graphics.DrawString(cleanGps, _listBox.Font, brush, bounds);
                    bounds.X = (int)(_listBox.Width * 0.49);
                    e.Graphics.DrawString(car.FuelSource.ToString(), _listBox.Font, brush, bounds);
                    bounds.X = (int)(_listBox.Width * 0.65);
                    e.Graphics.DrawString(car.RentalRate.ToString("C"), _listBox.Font, brush, bounds);
                    bounds.X = (int)(_listBox.Width * 0.79);
                    e.Graphics.DrawString(car.LentOut.ToString(), _listBox.Font, brush, bounds);
                    //Display lend date due back
                    if (car.LentOut == LentType.Out)
                    {
                        bounds.X = (int)(_listBox.Width - 80);
                        e.Graphics.DrawString(car.DateDueBack.ToString("d"), _listBox.Font, brush, bounds);

                    }
                    else
                    {
                        bounds.X = (int)(_listBox.Width - 50);
                        e.Graphics.DrawString("N/A", _listBox.Font, brush, bounds);
                    }



                }
                else
                {
                    e.Graphics.DrawString(car.RegoPlateNumber, _listBox.Font, brush, bounds);
                    bounds.X = (int)(_listBox.Width * 0.31);
                    e.Graphics.DrawString(cleanGps, _listBox.Font, brush, bounds);
                    bounds.X = (int)(_listBox.Width * 0.49);
                    e.Graphics.DrawString(car.FuelSource.ToString(), _listBox.Font, brush, bounds);
                    bounds.X = (int)(_listBox.Width * 0.63);
                    e.Graphics.DrawString(car.WofDue.ToString("d"), _listBox.Font, brush, bounds);
                    bounds.X = (int)(_listBox.Width * 0.79);                   
                    e.Graphics.DrawString(car.LentOut.ToString(), _listBox.Font, brush, bounds);
                    //Display lend date due back
                    if (car.LentOut == LentType.Out)
                    {
                        bounds.X = (int)(_listBox.Width - 80);
                        e.Graphics.DrawString(car.DateDueBack.ToString(), _listBox.Font, brush, bounds);
                    }
                    else
                    {
                        bounds.X = (int)(_listBox.Width - 50);
                        e.Graphics.DrawString("N/A", _listBox.Font, brush, bounds);
                    }



                }
                
                




            }
            }
        /// <summary>
        /// Allow only letters or numbers.
        /// Only allow input of certain characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _regoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only letters or numbers
            if ((e.KeyChar) < 32)

            {

                e.Handled = false;

            }
            else if (!char.IsLetterOrDigit(e.KeyChar))

            {
                
                 e.Handled = true;

            }
        }
        /// <summary>
        /// Asks the user for how many days they would like the car. If WOF will happen during that time, error.
        /// If car is already lent out, error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _lendButton_Click(object sender, EventArgs e)
        {
            if (_listBox.SelectedIndex >= 0)
            {
                // Get the selected car item
                RentalCar car = _list[_listBox.SelectedIndex];
                //If car is not lent out then proceed
                if (car.LentOut == LentType.In)
                {

                    string lendInput = Interaction.InputBox("How many days would you like to lend this vehicle?",
                                                   "Lending", "");
                    decimal daysLend;
                    //Input check
                    if (!decimal.TryParse(lendInput, out daysLend))
                    {
                        MessageBox.Show("Please enter a number.");
                    }
                    else
                    {
                        decimal lendPrice = daysLend * car.RentalRate;

                        DateTime today = DateTime.Now;
                        DateTime returnDate = today.AddDays((double)daysLend);
                        //If WOF is not due during lend period
                        if (!(returnDate >= car.WofDue))
                        {
                            car.DateDueBack = returnDate;
                            car.LentOut = LentType.Out;
                            _listBox.Refresh();
                            MessageBox.Show("The vehicle must be returned by the " + today + "." + "\n" + "Total amount due: " + lendPrice);
                        }
                        else
                        {
                            MessageBox.Show("The WOF is due during this period.");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("The car is not currently in the business.");
                }
            }
        }
        //Switch to maintainView
        private void _maintainanceButton_Click(object sender, EventArgs e)
        {
            _maintainanceView = true;
            _listBox.Refresh();
        }
        //Redraw listbox when for resizes
        private void RentalForm_SizeChanged(object sender, EventArgs e)
        {
            _listBox.Refresh();
        }
        //Switch to fleet view
        private void button1_Click(object sender, EventArgs e)
        {
            _maintainanceView = false;
            _listBox.Refresh();
            
        }
    }

}

