using System.Collections.Generic;
using ElectrumGames.Core.Configs;
using ElectrumGames.Core.Input;
using ElectrumGames.Core.Vehicle.Movement;
using ElectrumGames.Core.Vehicle.Visual;
using UnityEngine;
using Zenject;

namespace ElectrumGames.Core.Vehicle
{
    public class VehicleController : MonoBehaviour
    {
        [SerializeField] private GuideWheel[] guideWheelsGroup;
        [SerializeField] private MotorWheel[] motorWheelsGroup;

        private List<ICanRotate> _rotateWheels;
        private List<IHaveMotor> _motorWheels;

        private VehicleMotor _motor;

        private IInput _input;

        private void Awake()
        {
            _rotateWheels = new List<ICanRotate>(guideWheelsGroup);
            _motorWheels = new List<IHaveMotor>(motorWheelsGroup);

            _motor = new VehicleMotor(_rotateWheels, _motorWheels);
        }

        [Inject]
        private void Construct(InputSchema inputSchema)
        {
            _input = new PlayerInput(inputSchema);
            _input.Init();
        }

        private void FixedUpdate()
        {
            var deltaTime = Time.fixedDeltaTime;
            
            _input.Update(deltaTime);
            _motor.Simulate(deltaTime, _input);
        }
    }
}