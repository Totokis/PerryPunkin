using System;
using UnityEngine;

public class LightDetector : MonoBehaviour
{
    private Ghost _ghost;
    public Ghost Ghost => _ghost;

    private void Awake()
    {
        _ghost = GetComponentInParent<Ghost>();
    }
}