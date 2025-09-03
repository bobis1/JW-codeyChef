using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public string trigger;
    public GameObject Bread;
    public GameObject heldItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if(trigger == "bread")
            {
                print("Codey wants bread");
                heldItem = Instantiate(Bread, transform, false);
                heldItem.transform.localPosition = new Vector3(0,0, 2);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        trigger = other.name;
    }
    private void OnTriggerExit(Collider other)
    {
        trigger = "";
    }
}
