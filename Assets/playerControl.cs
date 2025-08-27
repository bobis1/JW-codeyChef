using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public Vector3 playerPosion;
    public float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            playerPosion = transform.position;
            playerPosion.x += playerSpeed;
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(playerPosion);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerPosion = transform.position;
            playerPosion.x -= playerSpeed;
            transform.position = playerPosion;
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerPosion = transform.position;
            playerPosion.z -= playerSpeed;
            //transform.position = playerPosion;
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(playerPosion);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerPosion = transform.position;
            playerPosion.z -= playerSpeed;
            transform.position = playerPosion;
        }
    }
}
