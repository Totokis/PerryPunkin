using UnityEngine;

public class Ghost : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _alphaColor = Color.white;
    [SerializeField] private float _totalFadeTime = 0.5f;
    
    private KillPlayer _killPlayer;
    private float _fadeToOpaqueTimer;
    private Color _originalColor;

    private void Awake()
    {
        _killPlayer = GetComponent<KillPlayer>();
        _originalColor = _renderer.color;
    }

    private void Update()
    {
        if (_fadeToOpaqueTimer > 0)
        {
            _fadeToOpaqueTimer -= Time.deltaTime;
            if (_fadeToOpaqueTimer <= 0)
            {
                FinalizeUnlightning();
            }
            else
            {
                FadeAlpha();
            }
        }
    }

    private void FadeAlpha()
    {
        float percent = 1 - (_fadeToOpaqueTimer/ _totalFadeTime);
        _renderer.color = Color.Lerp(_alphaColor, _originalColor, percent);
    }

    private void FinalizeUnlightning()
    {
        _killPlayer.enabled = true;
        _renderer.color = _originalColor;
    }

    public void BecomeLit()
    {
        _fadeToOpaqueTimer = 0;
        _killPlayer.enabled = false;
        _renderer.color = _alphaColor;
    }
    
    public void BecomeUnlit()
    {
        _fadeToOpaqueTimer = _totalFadeTime;
    }
}