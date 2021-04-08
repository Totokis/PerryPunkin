using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class KillPlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (this.enabled == false)
            return;
        Mover mover = other.GetComponent<Mover>();
        if (mover != null)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnValidate()
    {
        GetComponent<Collider>().isTrigger = true;
    }
}
 