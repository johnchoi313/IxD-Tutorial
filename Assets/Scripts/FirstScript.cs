using UnityEngine;
using System.Collections.Generic;



public class FirstScript : MonoBehaviour
{
    public int myInt = 5;
    public float myFloat = 3.14f;
    public string myString = "Hello, World!";
    public bool myBool = true;
    public List<int> myList = new List<int>();
    public GameObject myGameObject;
    public Transform myTransform;
    public Rigidbody myRigidbody;
    public Camera myCamera;
    public Light myLight;

    public float spinSpeed = 200f;
    public float loopSpeed = 2f;
    public float loopRadius = 3f;
    public float erraticSpeed = 1f;
    public float erraticIntensity = 2f;

    private float timeOffset;
    private Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (myGameObject != null)
        {
            startPosition = myGameObject.transform.position;
        }
        timeOffset = Random.Range(0f, 100f);
    }

    // Update is called once per frame
    void Update()
    {
        if (myGameObject != null)
        {
            float time = Time.time;

            myGameObject.transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
            myGameObject.transform.Rotate(Vector3.up * spinSpeed * 0.5f * Time.deltaTime);

            float loopX = Mathf.Sin(time * loopSpeed) * loopRadius;
            float loopY = Mathf.Sin(time * loopSpeed * 2) * loopRadius;
            float loopZ = Mathf.Cos(time * loopSpeed) * loopRadius;

            float noiseX = (Mathf.PerlinNoise(time * erraticSpeed + timeOffset, 0) - 0.5f) * erraticIntensity;
            float noiseY = (Mathf.PerlinNoise(0, time * erraticSpeed + timeOffset) - 0.5f) * erraticIntensity;
            float noiseZ = (Mathf.PerlinNoise(time * erraticSpeed + timeOffset, time * erraticSpeed + timeOffset) - 0.5f) * erraticIntensity;

            Vector3 newPosition = startPosition + new Vector3(loopX + noiseX, loopY + noiseY, loopZ + noiseZ);
            myGameObject.transform.position = newPosition;
        }
    }
}
