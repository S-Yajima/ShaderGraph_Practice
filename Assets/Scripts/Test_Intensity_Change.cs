using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Intensity_Change : MonoBehaviour
{
    private Material material = null;

    private float intensity = 0;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
        material.SetColor("_Color_Light", new Color(0.0f * intensity, 0.0f * intensity, 0.0f * intensity));
    }

    // Update is called once per frame
    void Update()
    {
        material.EnableKeyword("_EMISSION");
        
        if(intensity < 2.0f)
        {
            intensity += 0.2f * Time.deltaTime;
            material.SetColor("_Color_Light", new Color(1.0f * intensity, 1.0f * intensity, 1.0f * intensity));
        }

        // mat.SetColor("_EmissionColor", new Color(0.0f * factor, 0.0f * factor, 1.0f * factor));
    }
}
