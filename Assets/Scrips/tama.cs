using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tama : MonoBehaviour
{
    [SerializeField] float move = 0.01f;

    [SerializeField] int _counter = 0;

    // Update is called once per frame
    void Update()
    {
        //ìGÇ™ç∂âEÇ…ìÆÇ≠
        Vector3 x = new Vector3(move,0,0);
        transform.Translate(x);
        _counter++;

        if (_counter == 300)
        {
            _counter = 0;
            move *= -1;
        }
    }
}
