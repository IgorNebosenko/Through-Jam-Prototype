using DG.Tweening;
using UnityEngine;

namespace ElectrumGames.Core.Vehicle.Visual
{
    public class MotorWheelVisual : MonoBehaviour, IVehicleVisual
    {
        private const float DegreesInRound = 360f;
        private const float DurationRotation = 0.1f;
        
        public virtual void Simulate(VehicleVisualData data, float deltaTime)
        {
            var rotationAngle = data.rpm * DegreesInRound * deltaTime * DurationRotation;
            var updatedEuler = transform.localEulerAngles + Vector3.back * rotationAngle;

            transform.DOLocalRotate(updatedEuler, DurationRotation);
        }
    }
}