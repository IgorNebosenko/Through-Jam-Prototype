using System.Collections.Generic;
using ElectrumGames.Core.Vehicle.Movement;
using UnityEngine;

namespace ElectrumGames.Core.Vehicle
{
    public class VehicleController : MonoBehaviour
    {
        [SerializeField] private GuideWheel[] guideWheelsGroup;
        [SerializeField] private MotorWheel[] motorWheelsGroup;
        [SerializeField] private MotorWithGuideWheel[] motorWithGuideWheelsGroup;

        private List<ICanRotate> _rotateWheels;
        private List<IHaveMotor> _motorWheels;

        private void Awake()
        {
            _rotateWheels = new List<ICanRotate>(guideWheelsGroup);
            _rotateWheels.AddRange(motorWithGuideWheelsGroup);

            _motorWheels = new List<IHaveMotor>(motorWheelsGroup);
            _motorWheels.AddRange(motorWithGuideWheelsGroup);
        }
    }
}