using ElectrumGames.Core.Vehicle.Visual;
using UnityEngine;

namespace ElectrumGames.Core.Vehicle.Movement
{
    public class MotorWheel : WheelBase, IHaveMotor
    {
        [SerializeField] private float forceMove;
        [SerializeField] private MotorWheelVisual visual;

        public void AddVelocity(float direction, float deltaTime)
        {
            wheel.motorTorque = forceMove * direction * deltaTime;
            visual.Simulate(new VehicleVisualData(wheel.rpm, 0f), deltaTime);
        }
    }
}