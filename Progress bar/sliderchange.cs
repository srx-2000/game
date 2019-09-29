using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sliderchange : MonoBehaviour
{
    public Slider s;
    public int changed=100;
    public void change()
    {
            s.value++;
           s.value += 0f;
    }
}