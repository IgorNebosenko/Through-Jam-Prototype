using DG.Tweening;
using UnityEngine;

namespace ElectrumGames.Core.Vehicle.Visual
{
    public class MotorWheelVisual : MonoBehaviour, IVehicleVisual
    {
        private const float DegreesInRound = 360f;
        protected const float DurationRotation = 0.1f;
        
        public virtual void Simulate(float deltaTime, VehicleVisualData data)
        {
            var rotationAngle = data.rpm * DegreesInRound * deltaTime * DurationRotation;
            transform.DORotate(transform.eulerAngles +  Vector3.back * rotationAngle, DurationRotation);
        }
    }
}