using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dossun : MonoBehaviour
{
    Rigidbody2D _rb2;

    [SerializeField] int _speed = 1;

    // Start is called before the first frame update
   private void Start()
    {
        _rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Vector2 y = new Vector2(0,1);
        _rb2.velocity = y * _speed;

        if (col.gameObject.tag == "hantei")
        {
            _rb2.velocity = y * -_speed;
        }
        else if(col.gameObject.tag == "hantei2")
        {
            _rb2.velocity = y * _speed;
        }
    }
}
