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
        [SerializeField] private MotorWithGuideWheel[] motorWithGuideWheelsGroup;
        [Space]
        [SerializeField] private RotateWheelVisual[] rotateWheelVisuals;
        [SerializeField] private MotorWheelVisual[] motorWheelVisuals;

        private List<ICanRotate> _rotateWheels;
        private List<IHaveMotor> _motorWheels;
        private List<IVehicleVisual> _vehicleVisuals;

        private VehicleMotor _motor;

        private IInput _input;

        private void Awake()
        {
            _rotateWheels = new List<ICanRotate>(guideWheelsGroup);
            _rotateWheels.AddRange(motorWithGuideWheelsGroup);

            _motorWheels = new List<IHaveMotor>(motorWheelsGroup);
            _motorWheels.AddRange(motorWithGuideWheelsGroup);

            _motor = new VehicleMotor(_rotateWheels, _motorWheels);

            _vehicleVisuals = new List<IVehicleVisual>(rotateWheelVisuals);
            _vehicleVisuals.AddRange(motorWheelVisuals);
        }

        [Inject]
        private void Construct(InputSchema inputSchema)
        {
            _input = new PlayerInput(inputSchema);
            _input.Init();
        }

        private void Update()
        {
            Debug.LogWarning("Wheels visual not simulated!");
            var deltaTime = Time.deltaTime;
            
            foreach (var vehicleVisual in _vehicleVisuals)
                vehicleVisual.Simulate(deltaTime, new VehicleVisualData(10f, 5f));
        }

        private void FixedUpdate()
        {
            var deltaTime = Time.fixedDeltaTime;
            
            _input.Update(deltaTime);
            _motor.Simulate(deltaTime, _input);
        }
    }
}