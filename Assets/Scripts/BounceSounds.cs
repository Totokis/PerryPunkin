using UnityEngine;

public class BounceSounds : MonoBehaviour
{
    [SerializeField] private AudioClip[] _bounceSounds;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        PlayBounceSound();
    }

    private void PlayBounceSound()
    {
        if (_bounceSounds.Length == 0)
        {
            Debug.LogError("No bounce sounds assigned!");
            return;
        }
        int index = Random.Range(0, _bounceSounds.Length);
        _audioSource.pitch = Random.Range(0.8f, 1.2f);
        _audioSource.PlayOneShot(_bounceSounds[index]);
    }
}