using System.Collections.Generic;
using ElectrumGames.Core.Input;

namespace ElectrumGames.Core.Vehicle.Movement
{
    public class VehicleMotor
    {
        private List<ICanRotate> _rotateWheels;
        private List<IHaveMotor> _motorWheels;

        public VehicleMotor(List<ICanRotate> rotateWheels, List<IHaveMotor> motorWheels)
        {
            _rotateWheels = rotateWheels;
            _motorWheels = motorWheels;
        }

        public void Simulate(float deltaTime, IInput input)
        {
            foreach (var wheel in _rotateWheels)
                wheel.Rotate(deltaTime, input.HorizontalDirection);

            foreach(var wheel in _motorWheels)
                wheel.AddVelocity(input.VerticalDirection, deltaTime);
        }
    }
}