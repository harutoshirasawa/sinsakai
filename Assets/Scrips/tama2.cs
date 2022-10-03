using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tama2 : MonoBehaviour
{
    [SerializeField] float move = 0.01f;

    [SerializeField] int _counter = 0;

    // Update is called once per frame
    void Update()
    {Å@
        //ìGÇ™è„â∫Ç…ìÆÇ≠
        Vector3 y = new Vector3(0, move, 0);
        transform.Translate(y);
        _counter++;

        if (_counter == 300)
        {
            _counter = 0;
            move *= -1;
        }
    }
}


