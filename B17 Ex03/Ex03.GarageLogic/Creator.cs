﻿
using System;

namespace Ex03.GarageLogic
{
    public class Creator
    {
        public Motorcycle CreateNewMotorcycle(string i_ModelName, string i_LicenceNumber,
                                                float i_CurrentEnergyLevel, string i_OwnerName,
                                                string i_OwnerPhoneNumber, string i_ManufacturerName,
                                                Motorcycle.e_LicenceType i_LicenceType, int i_EngineCapacity,
                                                bool i_IsElectric)
        {
            int numberOfWheels = 2;
            float maxWheelAirPressure = 33;
            Vehicle.e_EnergyType energyType = Vehicle.e_EnergyType.Electric;
            Nullable<Vehicle.e_FuelType> fuelType = null;
            if (!i_IsElectric)
            {
                energyType = Vehicle.e_EnergyType.Fuel;
                fuelType = Vehicle.e_FuelType.Octan95;
            }
            float tankSize = i_IsElectric ? 2.7F : 5.5F;
            return new Motorcycle(i_ModelName, i_LicenceNumber, energyType, fuelType,
                          i_CurrentEnergyLevel, tankSize, i_OwnerName, i_OwnerPhoneNumber,
                          i_ManufacturerName, maxWheelAirPressure, numberOfWheels, i_LicenceType,
                          i_EngineCapacity);
        }

        public Car CreateNewCar(string i_ModelName, string i_LicenceNumber,
                                        float i_CurrentEnergyLevel, string i_OwnerName,
                                        string i_OwnerPhoneNumber, string i_ManufacturerName,
                                        Car.e_Color i_CarColor, int i_NumOfDoors, bool i_IsElectric)
        {
            int numberOfWheels = 4;
            float maxWheelAirPressure = 30;
            Vehicle.e_EnergyType energyType = Vehicle.e_EnergyType.Electric;
            Nullable<Vehicle.e_FuelType> fuelType = null;
            if (!i_IsElectric)
            {
                fuelType = Vehicle.e_FuelType.Octan98;
                energyType = Vehicle.e_EnergyType.Fuel;
            }
            float maxEnergyLevel = i_IsElectric ? 2.5F : 42F;
            return new Car(i_ModelName, i_LicenceNumber, energyType, fuelType,
                    i_CurrentEnergyLevel, maxEnergyLevel, i_OwnerName, i_OwnerPhoneNumber,
                    i_ManufacturerName, maxWheelAirPressure, numberOfWheels, i_CarColor, i_NumOfDoors);
        }

        public Truck CreateNewTruck(string i_ModelName, string i_LicenceNumber,
                                    float i_CurrentEnergyLevel, string i_OwnerName,
                                    string i_OwnerPhoneNumber, string i_ManufacturerName,
                                    bool i_IsCarryingHazardousMaterials, float i_MaxCarryingWeight)
        {
            int numberOfWheels = 12;
            float maxWheelAirPressure = 32;
            Vehicle.e_EnergyType energyType = Vehicle.e_EnergyType.Fuel;
            Vehicle.e_FuelType fuelType = Vehicle.e_FuelType.Octan96;
            float tankSize = 135F;
            return new Truck(i_ModelName, i_LicenceNumber, energyType, fuelType,
                    i_CurrentEnergyLevel, tankSize, i_OwnerName, i_OwnerPhoneNumber,
                    i_ManufacturerName, maxWheelAirPressure, numberOfWheels, i_IsCarryingHazardousMaterials,
                    i_MaxCarryingWeight);
        }
    }
}