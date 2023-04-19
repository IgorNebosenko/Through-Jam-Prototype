using UnityEngine;

namespace ElectrumGames.Core.Vehicle.Movement
{
    public class MotorWheel : WheelBase, IHaveMotor
    {
        [SerializeField] private float forceMove = 100;

        public void AddVelocity(float force, float deltaTime)
        {
            wheel.motorTorque = force * deltaTime;
            //wheel.steerAngle = 10;
            //transform.DORotate(transform.eulerAngles + Vector3.forward * force * deltaTime, deltaTime);
        }
    }
}