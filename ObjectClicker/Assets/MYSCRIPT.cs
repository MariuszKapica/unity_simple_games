using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MYSCRIPT : MonoBehaviour
{
    
    public Color NaszColor;
    public Renderer NaszRenderer;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        NaszRenderer.material.color = NaszColor;
    }
}
