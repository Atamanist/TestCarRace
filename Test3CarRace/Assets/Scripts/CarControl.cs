using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I create to control car and car wheels. Car mass. Back wheels speeds and forward wheels angle
public class CarControl : MonoBehaviour
{
    [SerializeField] private List<ParticleSystem> _smoke;
    [SerializeField] private WheelCollider _wheelFR, _wheelFL;
    [SerializeField] private WheelCollider _wheelBR, _wheelBL;
    [SerializeField] private Rigidbody _car;
    [SerializeField] private float _speed,_carMass, _maxAngle;
    private float _angle;
    private float _inputHorizontal;

    private void Start()
    {
        _car.mass = _carMass;
    }
    private void FixedUpdate()
    {
        _wheelBL.motorTorque = -_speed;
        _wheelBR.motorTorque = -_speed;
        if(Mathf.Abs(_inputHorizontal) > 0.2f)
        {
            foreach (ParticleSystem i in _smoke)
            {
                i.Play();
            }
        }
        else
        {
            foreach (ParticleSystem i in _smoke)
            {
                i.Stop();
            }

        }

        SetAngle();
        
    }

    private void SetAngle()
    {
        _angle = _maxAngle * _inputHorizontal;
        _wheelFL.steerAngle = _angle;
        _wheelFR.steerAngle = _angle;

    }
    public void InputHorizontal(float angle)
    {
        _inputHorizontal = angle;
    }
}
