using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_ : MonoBehaviour
{
    // Start is called before the first frame update
    public float skyRotSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Speed = Time.deltaTime*skyRotSpeed;
        RenderSettings.skybox.SetFloat("_Rotation", RenderSettings.skybox.GetFloat("_Rotation") + Speed);
    }
}
