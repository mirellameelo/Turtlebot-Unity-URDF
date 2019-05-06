using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard_control : MonoBehaviour
{
    public float Speed;
    // Use this for initialization
    void Start()
    {
        Speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Speed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}