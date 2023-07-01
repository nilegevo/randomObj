using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomCube : MonoBehaviour
{
    public GameObject PrefabCube;
    private int CurrentCubes = 0; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // 30 fps 
        if (Time.frameCount % 30 == 0)
        {
            // 
            float x = Random.Range(-5.0f, 5.0f);
            float z = Random.Range(-5.0f, 5.0f);
            Vector3 pos = new Vector3(x, 10.0f, z);

            var q = new Quaternion(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
            Instantiate(PrefabCube, pos, q);
            CurrentCubes++;
        }
    }



}
