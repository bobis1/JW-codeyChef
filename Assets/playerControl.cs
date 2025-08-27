using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public Vector3 playerPosion;
    public float playerSpeed;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();


        if (Input.GetKey(KeyCode.W)){
            playerPosion = transform.position;
            playerPosion.x += playerSpeed;
            //transform.position = playerPosion;
            //rb.AddForce(playerPosion);
            rb.MovePosition(playerPosion);

        }
        if (Input.GetKey(KeyCode.S))
        {
            playerPosion = transform.position;
            playerPosion.x -= playerSpeed;
            //transform.position = playerPosion;
            //rb.AddForce(playerPosion);
            rb.MovePosition(playerPosion);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerPosion = transform.position;
            playerPosion.z += playerSpeed;
            //transform.position = playerPosion;
            //rb.AddForce(playerPosion);
            rb.MovePosition(playerPosion);

        }
        if (Input.GetKey(KeyCode.D))
        {
            playerPosion = transform.position;
            playerPosion.z -= playerSpeed;
            //transform.position = playerPosion;
            //rb.AddForce(playerPosion);
            rb.MovePosition(playerPosion);

        }
    }
}
