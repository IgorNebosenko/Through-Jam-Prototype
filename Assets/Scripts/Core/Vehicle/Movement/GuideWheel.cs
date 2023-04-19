﻿using UnityEngine;

namespace ElectrumGames.Core.Vehicle.Movement
{
    public class GuideWheel : WheelBase, ICanRotate
    {
        [SerializeField] private float maxRotationAngle = 15;
        public void Rotate(float direction)
        {
            wheel.steerAngle = maxRotationAngle * direction;
        }
    }
}