using UnityEngine;

namespace ElectrumGames.Core.Vehicle.Movement
{
    public abstract class WheelBase : MonoBehaviour
    {
        [SerializeField] private float wheelMass;
        [SerializeField] protected Rigidbody physicModel;
    }
}