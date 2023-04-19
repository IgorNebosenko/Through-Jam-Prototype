using System.Collections.Generic;
using ElectrumGames.Core.Configs;
using ElectrumGames.Core.Input;
using ElectrumGames.Core.Vehicle.Movement;
using UnityEngine;
using Zenject;

namespace ElectrumGames.Core.Vehicle
{
    public class VehicleController : MonoBehaviour
    {
        [SerializeField] private GuideWheel[] guideWheelsGroup;
        [SerializeField] private MotorWheel[] motorWheelsGroup;
        [SerializeField] private MotorWithGuideWheel[] motorWithGuideWheelsGroup;

        private List<ICanRotate> _rotateWheels;
        private List<IHaveMotor> _motorWheels;

        private IInput _input;

        private void Awake()
        {
            _rotateWheels = new List<ICanRotate>(guideWheelsGroup);
            _rotateWheels.AddRange(motorWithGuideWheelsGroup);

            _motorWheels = new List<IHaveMotor>(motorWheelsGroup);
            _motorWheels.AddRange(motorWithGuideWheelsGroup);
        }

        [Inject]
        private void Construct(InputSchema inputSchema)
        {
            _input = new PlayerInput(inputSchema);
        }
    }
}