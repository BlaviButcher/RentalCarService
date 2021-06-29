using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waikato_Driveways
{   
    public enum LentType
    {
        In,
        Out
    }
    public enum FuelType
    {
        Petrol,
        Electric
    }
    public enum NavigationType
    {
        No_GPS,
        Has_GPS,
        
    }
    public enum VehicleType
    {
        Budget_Hatchback,
        Economy_Sedan,
        MiniBus,
        FourWheel_Drive,
        Campervan
    }
    public class RentalCar
    {
        //###########################################
        //# Instance Variables
        /// <summary>
        /// The registration plate number of vehicle
        /// </summary>
        private string _regoPlateNumber;
        /// <summary>
        /// The type of vehicle
        /// </summary>
        private VehicleType _vehicleType;
        /// <summary>
        /// A flag to indicate whether the car has a GPS navigation system
        /// </summary>
        private NavigationType _navigationType;
        /// <summary>
        /// A flag whether the car uses electric or petrol
        /// </summary>
        private FuelType _fuelType;
        /// <summary>
        /// The rate to rent car in dollars 
        /// </summary>
        private decimal _rentalRate;
        /// <summary>
        /// The date the warrant of fitness is due for the vehicle
        /// </summary>
        private DateTime _wofDue;
        /// <summary>
        /// A flag to indicate whether the car is lent out
        /// </summary>
        private LentType _lentType;
        /// <summary>
        /// The date the lent out car is due back
        /// </summary>
        private DateTime _dateDueBack;


        //###########################################
        //#Constructor
        public RentalCar(string regoPlateNumber, VehicleType vehicleType, NavigationType navigationType, 
            FuelType fuelType, decimal rentalRate, DateTime wofDue, LentType lentType, DateTime dateDueBack) 

        {   

            RegoPlateNumber = regoPlateNumber;
            CarType = vehicleType;
            NavigationSystem = navigationType;
            FuelSource = fuelType;
            RentalRate = rentalRate;
            WofDue = wofDue;
            LentOut = lentType;
            DateDueBack = dateDueBack;
            

        }

        //###########################################
        //#Public Methods
        public override string ToString()
        {
            
            string convertedVehicleType = CheckVehicleType();
            string convertedNavigationType = CheckNavigationType();

            
            return String.Format("{0,-9} {1, -17} {2, -8} {3, -8:C} {4, -10:dd/MM/yyyy} {5, -4} {6, -10:dd/MM/yyyy}", 
                _regoPlateNumber, convertedNavigationType, _fuelType, _rentalRate, _wofDue, _lentType, _dateDueBack);

            
        }


        //###########################################
        //#Properties
        public string RegoPlateNumber
        {
            get { return _regoPlateNumber; }
            set { _regoPlateNumber = value; }
        }
        public VehicleType CarType
        {
            get { return _vehicleType; }
            set { _vehicleType = value; }
        }
        public NavigationType NavigationSystem
        {
            get { return _navigationType; }
            set { _navigationType = value; }
        }
        public FuelType FuelSource
        {
            get { return _fuelType; }
            set { _fuelType = value; } 
        }
        //Calculating rental rates
        public decimal RentalRate
        {
            get 
            {
                decimal rate = 0;

                if (_vehicleType == VehicleType.Budget_Hatchback)
                {
                   rate += 36;
                }
                else if (_vehicleType == VehicleType.Economy_Sedan)
                {
                    rate += 45;
                }
                else if (_vehicleType == VehicleType.MiniBus || _vehicleType == VehicleType.FourWheel_Drive)
                {
                    rate += 80;
                }
                else if (_vehicleType == VehicleType.Campervan)
                {
                    rate += 120;
                }
                if (_navigationType == NavigationType.Has_GPS)
                {
                    rate += (decimal)7.5;
                }
                if (_fuelType == FuelType.Electric)
                {
                    rate += (decimal)2.5;
                }

                return rate;

            }
            set { _rentalRate = RentalRate; }
        }
        public DateTime WofDue
        {
            get { return _wofDue; }
            set { _wofDue = value; }
        } 
        public LentType LentOut
        {
            get { return _lentType; }
            set { _lentType = value; }

        }
        public DateTime DateDueBack
        {
            get { return _dateDueBack; }
            set { _dateDueBack = value; }
        }
        //###########################################
        //#Private Methods
        // These methods were used along with the ToString() to make things look nice. I kept these aswell as ToString()
        //to show capability
        private string CheckVehicleType()
        {
            switch (_vehicleType) 
            {
                case VehicleType.Budget_Hatchback:
                    {
                        return "Budget Hatchback";
                    }
                case VehicleType.Economy_Sedan:
                    {
                        return "Economy Sedan";
                    }
                case VehicleType.MiniBus:
                    {
                        return "MiniBus";
                    }
                case VehicleType.FourWheel_Drive:
                    {
                        return "Four Wheel Drive";
                    }
                case VehicleType.Campervan:
                    {
                        return "Campervan";
                    }

                default:
                    {
                        return "";
                    }
            }

        }
        private string CheckNavigationType()
        {
            switch (_navigationType)
            {
                case NavigationType.Has_GPS:
                    {
                        return "Has GPS";
                    }
                case NavigationType.No_GPS:
                    {
                        return "No GPS";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
}
