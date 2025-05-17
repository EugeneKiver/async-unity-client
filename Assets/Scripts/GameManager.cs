using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class GameManager : MonoBehaviour
{
    public Material matRed;
    public Material matGreen;
    public GameObject cube;
    [Header("Network Settings")]
    public string ipAddress = "127.0.0.1";
    public int port = 11000;
    // Start is called before the first frame update
    void Start()
    {
        AsynchronousClient.IpAddress = ipAddress;
        AsynchronousClient.Port = port;
        AsynchronousClient.StartClient();
        cube.GetComponent<Renderer>().material = matGreen;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
