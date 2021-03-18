using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;


    public class ScaleClippingBox : MonoBehaviour
    {
        [SerializeField]
        private Transform ClippingBoxSize = null;
        
    public void OnSliderUpdated(SliderEventData eventData)
        {
            
            if (ClippingBoxSize != null)
            {
            // Rotate the target object using Slider's eventData.NewValue
            //Debug.Log(ClippingBoxSize.localPosition.x);
                ClippingBoxSize.transform.localScale = new Vector3(1.0f - eventData.NewValue, ClippingBoxSize.transform.localScale.y, ClippingBoxSize.transform.localScale.z);
            }
        }
    }

