using UnityEngine;

namespace ElectrumGames.Core.Vehicle.Movement
{
    public class MotorWithGuideWheel : WheelBase, ICanRotate, IHaveMotor
    {
        [SerializeField] private float forceMove = 100;
        [SerializeField] private float maxRotationAngle = 15;
        
        public void Rotate(float direction)
        {
            wheel.steerAngle = maxRotationAngle * direction;
        }

        public void AddVelocity(float direction, float deltaTime)
        {
            wheel.motorTorque = forceMove * direction * deltaTime;
        }
    }
}