using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOnlock : MonoBehaviour
{

    public GameObject door = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    { 
        if(other.gameObject.CompareTag("Key"))
        {
            //unlock
            if (door.activeInHierarchy)
                door.SetActive(false);
        }
    }
}
