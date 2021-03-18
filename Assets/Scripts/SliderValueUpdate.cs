using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class SliderValueUpdate : MonoBehaviour
{
    [SerializeField]
    private SliderEvent SliderR;
    [SerializeField]
    private SliderEvent SliderL;
    //private ScaleClippingBox scaleBoxScript;

    // Start is called before the first frame update
    void Start()
    {
        //oldData = SliderR.Slider;
    }
    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(SliderR);
        
    }
}
