using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestMath : MonoBehaviour
{
    public float hp;
    // Start is called before the first frame update

    public Slider lerpSlider;
    public Slider moveTowards;
    public Slider pingPong;
    public float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lerpSlider.value = Mathf.Lerp(lerpSlider.value, lerpSlider.maxValue, speed * Time.deltaTime);
        moveTowards.value = Mathf.MoveTowards(moveTowards.value, moveTowards.maxValue, speed * Time.deltaTime);
        pingPong.value = Mathf.PingPong(speed * Time.deltaTime, pingPong.maxValue);
    }

    private void OnValidate()
    {
        float absolute = Mathf.Abs(-8.5f);
        Debug.Log(absolute);

        float roundToInt = Mathf.RoundToInt(8.5f);
        Debug.Log(roundToInt);

        float ceilToInt = Mathf.CeilToInt(8.5f);
        Debug.Log(ceilToInt);

        float floorToInt = Mathf.FloorToInt(8.5f);
        Debug.Log(floorToInt);

        float pow = Mathf.Pow(8, 2);
        Debug.Log(pow);

        float sqrt = Mathf.Sqrt(16);
        Debug.Log(sqrt);

        float clamp = Mathf.Clamp(hp, 0, 100);
        Debug.Log(clamp);


    }
}
