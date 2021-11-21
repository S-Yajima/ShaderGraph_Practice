using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * シェーダーグラフのプロパティを
 */
public class Test_Use_ShaderGraph : MonoBehaviour
{
    [SerializeField] private Renderer target_render = null;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target_render.material.GetShaderPassEnabled("_TEST_NAME") == true)
        {
            float value = target_render.material.GetFloat("_TEST_NAME");

            value -= 0.1f * Time.deltaTime;

            target_render.material.SetFloat("_TEST_NAME", value);
        }
    }
}
