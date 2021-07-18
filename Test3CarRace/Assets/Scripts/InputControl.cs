using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputControl : MonoBehaviour
{
    [SerializeField] private CarControl _car;
    [SerializeField] private Image _steerWheel;
    [SerializeField] private float _rotateAngle;
    private float _rot;


    private void Update()
    {
        if(Input.touchCount>0)
        {
            _rot = (Input.GetTouch(0).position.x - (Screen.width / 2)) / (Screen.width / 2);
        }
        else
        {
            _rot = 0;
        }
        RectTransform angle = _steerWheel.GetComponent<RectTransform>();
        angle.eulerAngles=new Vector3(0,0,-_rotateAngle*_rot);
        _car.InputHorizontal(_rot);

    }

}
