using UnityEngine;

namespace ElectrumGames.Core.Vehicle.Movement
{
    public abstract class WheelBase : MonoBehaviour
    {
        [SerializeField] protected WheelCollider wheel;
        [SerializeField] protected Transform visualTransform;
    }
}