class IGEngineVehicle : Vehicle
{
    public 
    float engineCapacityInCC;
    float CalculateEnginePowerHP() => engineCapacityInCC /32.2f;
    
}