namespace ElectrumGames.Core.Vehicle.Visual
{
    public readonly struct VehicleVisualData
    {
        public readonly float rpm;
        public readonly float rotationAngle;

        public VehicleVisualData(float rpm, float rotationAngle)
        {
            this.rpm = rpm;
            this.rotationAngle = rotationAngle; 
        }
    }
}