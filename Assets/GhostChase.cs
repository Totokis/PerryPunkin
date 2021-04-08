using UnityEngine;

public class GhostChase : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;
    private Mover _player;

    private void OnEnable()
    {
        _player = FindObjectOfType<Mover>();
    }

    private void Update()
    {
        var directionToPlayer = _player.transform.position - transform.position;
        var direction = new Vector3(directionToPlayer.x,directionToPlayer.y,0);
        if (direction.x > 0)
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
        }
        else if(direction.x < 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
        }
        transform.position += (direction * (_moveSpeed * Time.deltaTime));
    }
}
