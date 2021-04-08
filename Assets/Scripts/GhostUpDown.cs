using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostUpDown : MonoBehaviour
{
    [SerializeField]private float _heightVariance = 2f;
    [SerializeField]private float _moveSpeed = 2f;
    
    private float _startPositionY;
    private float _direction = 1 ;

    private void OnEnable()
    {
        _startPositionY = transform.position.y;
    }

    private void Update()
    {
        if (transform.position.y > _startPositionY + _heightVariance ||
            transform.position.y < _startPositionY - _heightVariance)
        {
            _direction *= -1;
        }
        transform.Translate(Vector3.up * _direction * Time.deltaTime * _moveSpeed);
        
    }
}
