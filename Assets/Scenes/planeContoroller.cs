using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class planeContoroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //hello
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
        Destroy(collision.gameObject, 0.5f);
    }
    
}
