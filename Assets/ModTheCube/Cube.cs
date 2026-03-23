using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float r;
    public float g;
    public float b;
    public float a;
    public float scale;
    public float rotateX;
    public float rotateY;
    public float rotateZ;
    
    void Start()
    {
        InvokeRepeating("GenerateColor", 0.0f, 2.0f);
        InvokeRepeating("GenerateScale", 0.0f, 2.0f);
        InvokeRepeating("GenerateRotation", 0.0f, 2.0f);
    }
    
    void Update()
    {
        Material material = Renderer.material;
        material.color = new Color(r, g, b, a);
        transform.localScale = Vector3.one * scale;
        transform.Rotate(rotateX * Time.deltaTime, rotateY * Time.deltaTime, rotateZ * Time.deltaTime);   
    }

    void GenerateColor()
    {
        r = Random.Range(0.0f, 1.0f);
        g = Random.Range(0.0f, 1.0f);
        b = Random.Range(0.0f, 1.0f);
        a = Random.Range(0.0f, 1.0f);
    }

    void GenerateScale()
    {
        scale = Random.Range(1.0f, 3.0f);
    }

    void GenerateRotation()
    {
        rotateX = Random.Range(-15.0f, 15.0f);
        rotateY = Random.Range(-15.0f, 15.0f);
        rotateZ = Random.Range(-15.0f, 15.0f);
    }
}
