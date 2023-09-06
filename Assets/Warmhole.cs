using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warmhole : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject pTunnel;
    private GameObject cTunnel;
    [SerializeField] private float pSpeed;
    [SerializeField] private float cSpeed;
    void Start()
    {
        pTunnel = this.gameObject;
        cTunnel = this.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        pTunnel.transform.Rotate(Vector3.up* pSpeed * Time.deltaTime);
        cTunnel.transform.Rotate(Vector3.forward * cSpeed * Time.deltaTime);
    }
}
