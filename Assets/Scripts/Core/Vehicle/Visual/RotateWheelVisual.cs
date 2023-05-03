using DG.Tweening;

namespace ElectrumGames.Core.Vehicle.Visual
{
    public class RotateWheelVisual : MotorWheelVisual
    {
        private const float DurationChangeAngle = 0.3f;
        
        public override void Simulate(VehicleVisualData data, float deltaTime)
        {
            base.Simulate(data, deltaTime);
            var updatedEuler = transform.localEulerAngles;
            updatedEuler.y = data.rotationAngle;
            
            transform.DOLocalRotate(updatedEuler, DurationChangeAngle);
        }
    }
}