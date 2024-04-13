using System;
using _Scripts.ScriptableObjects;
using UnityEngine;

namespace _Scripts
{
    public class BeybladeSpin : MonoBehaviour
    {
        public FloatVar SpinForce;
        public FloatVar RotationSpeed;
        private Rigidbody _rigidBody;

        private void Awake()
        {
            this._rigidBody = GetComponent<Rigidbody>();
        }

        void Start()
        {
            this._rigidBody.maxAngularVelocity = Mathf.Infinity;
            this._rigidBody.AddTorque(transform.up * SpinForce.Value, ForceMode.Impulse);
        }

        private void Update()
        {
            transform.RotateAround(Vector3.zero, Vector3.up, RotationSpeed.Value * Time.deltaTime);
        }
    }
}
