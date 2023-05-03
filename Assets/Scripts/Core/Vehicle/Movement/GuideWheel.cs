using ElectrumGames.Core.Vehicle.Visual;
using UnityEngine;

namespace ElectrumGames.Core.Vehicle.Movement
{
    public class GuideWheel : WheelBase, ICanRotate
    {
        [SerializeField] private float maxRotationAngle;
        [SerializeField] private RotateWheelVisual visual;
        
        public void Rotate(float deltaTime, float direction)
        {
            var angle = maxRotationAngle * direction;
            Debug.Log(angle);
            
            wheel.steerAngle = angle;
            visual.Simulate(new VehicleVisualData(wheel.rpm, angle), deltaTime);
        }
    }
}