using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chainsaw : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D _rb;
   
    [SerializeField] int _speed = 1;
      

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    //Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        Vector2 y = new Vector2(0, 1);
        _rb.velocity = y * _speed;

        if (col.gameObject.tag == "hantei")
        {
            _rb.velocity = y * -_speed;
        }
        else if(col.gameObject.tag == "hantei2")
        {
            _rb.velocity = y * _speed;
        }
    }
}
