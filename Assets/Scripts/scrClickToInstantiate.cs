using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrClickToInstantiate : MonoBehaviour
{
    public GameObject box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 5);
            print(position);
            Instantiate(box, position, Quaternion.identity);
        }
    }
}
