using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float upForse = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.AddForce(new Vector3(0, upForse, 0));
        }
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Floor")
        {
            transform.SetParent(gameObject.transform);
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if(col.gameObject.name == "Floor")
        {
            transform.SetParent(null);
        }
    }
}
