using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]int counter = 0;

    [SerializeField] float move = 0.01f;
    
     
        
    

    // Update is called once per frame
    void Update()
    {
        Vector3 p = new Vector3(move, 0, 0);
        transform.Translate(p);
        counter++;

        if(counter == 300)
        {
            counter = 0;
            move *= -1;
        }

        
    }
}
