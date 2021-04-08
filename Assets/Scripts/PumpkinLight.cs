using UnityEngine;

public class PumpkinLight : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var lightDetector = other.GetComponent<LightDetector>();
        if (lightDetector != null) 
            lightDetector.Ghost.BecomeLit();
    }

    private void OnTriggerExit(Collider other)
    {
        var lightDetector = other.GetComponent<LightDetector>();
        
        if (lightDetector != null)
            lightDetector.Ghost.BecomeUnlit();
    }
}