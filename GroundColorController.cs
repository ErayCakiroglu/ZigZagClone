using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] Material groundMaterial;
    [SerializeField] Color[] colors;
    int colorIndex;
    [SerializeField] float lerpValue, time;
    float currentTime;

    void Update()
    {
        SetColorChangeTime();
        SetGroundMaterialSmoothColorChange();
    }

    void SetColorChangeTime()
    {
        if(currentTime <= 0)
        {
            CheckColorIndexValue();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    void CheckColorIndexValue()
    {
        colorIndex++;

        if(colorIndex > colors.Length)
        {
            colorIndex = 0;
        }
    }

    void SetGroundMaterialSmoothColorChange()
    {
        groundMaterial.color = Color.Lerp(groundMaterial.color, colors[colorIndex], lerpValue * Time.deltaTime);
    }
}
