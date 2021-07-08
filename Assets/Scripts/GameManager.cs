using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class GameManager : MonoBehaviour
{
    public Material matRed;
    public Material matGreen;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        AsynchronousClient.StartClient();
        cube.GetComponent<Renderer>().material = matGreen;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
