using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        public float Accel;
        // public float Steer;
        public float Brake;
        public void AccelInput(float Input) { Accel = Input; }
        public void BrakeInput(float Input) { Brake = Input; }

        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = SimpleInput.GetAxis("Horizontal");
            float v = SimpleInput.GetAxis("Vertical");
            //#if !MOBILE_INPUT
            //float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, Accel, Accel, Brake);
            //#else
            //m_Car.Move(h, v, v, 0f);
            //#endif
        }
    }
}