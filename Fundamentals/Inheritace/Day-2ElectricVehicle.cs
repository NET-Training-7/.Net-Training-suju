class ElectricVehicle:Vehicle
{
    float batteryCapacityInKw;
    float calculateEngineCapacityInCC()=>  batteryCapacityInKw*1.369f;

}