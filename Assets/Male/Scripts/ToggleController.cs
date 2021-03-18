using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleController : MonoBehaviour
{
    public void ToggleStatus()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}
