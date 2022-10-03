using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearScript : MonoBehaviour
{
    
    [SerializeField ]GameObject cleartext = default;


      
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ƒNƒŠƒA”»’è  
        if(collision .gameObject .tag =="Finish")
        {
            
            cleartext.gameObject.SetActive(true);
        }
    }
}
