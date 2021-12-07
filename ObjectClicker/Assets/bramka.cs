using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bramka : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision colission){
        Renderer RendererObiektu = colission.collider.GetComponent<Renderer>();
        RendererObiektu.enabled = false;
        Collider ColliderObiektu = colission.collider.GetComponent<Collider>();
        ColliderObiektu.enabled = false;
    }
}
