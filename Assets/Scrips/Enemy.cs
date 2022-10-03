using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 1f;

    [SerializeField] Vector2 _lineForGround = new Vector2(1f, -1f);

    [SerializeField] LayerMask _groundLayer = 0;

    Vector2 _moveDirection = Vector2.right;
    Rigidbody2D _rb = default;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveOnFloorWithTurn();
    }

    void MoveOnFloorWithTurn()
    {   //è∞Ç™Ç»Ç≠Ç»Ç¡ÇΩÇÁÅAï˚å¸ì]ä∑Ç∑ÇÈ 
       
        Vector2 start = this.transform.position;
        Debug.DrawLine(start, start + _lineForGround);
        RaycastHit2D hit = Physics2D.Linecast(start, start + _lineForGround, _groundLayer);

        Vector2 velo = Vector2.zero;

        if (!hit.collider)
        {
            var tlr = transform.localScale;
            tlr.x *= -1;
            transform.localScale = tlr;
            _moveSpeed *= -1;
            _lineForGround.x *= -1;

        }
        

        velo = _moveDirection.normalized * _moveSpeed;
        velo.y = _rb.velocity.y;
        _rb.velocity = velo;
        
    }

  
}
