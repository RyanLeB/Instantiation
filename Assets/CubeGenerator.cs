using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // INSTANCE
        //-----------------
        // gameObject.transform.Translate(Vector3.zero);

        // CLASS 
        //-----------------
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
