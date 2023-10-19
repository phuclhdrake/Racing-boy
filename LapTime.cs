using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTime : MonoBehaviour
{
    public static int minCount;
    public static int secCount;
    public static float miliCount;
    public static string miliDisplay;
    public GameObject min;
    public GameObject sec;
    public GameObject mili;

    void Start()
    {

    }

    void Update()
    {
        miliCount += Time.deltaTime * 10;
        miliDisplay = miliCount.ToString("F0");
        mili.GetComponent<Text>().text = "" + miliDisplay;

        if (miliCount >= 10)
        {
            miliCount = 0;
            secCount += 1;
        }
        if (secCount <= 9)
        {
            sec.GetComponent<Text>().text = "0" + secCount;
        }
        else
        {
            sec.GetComponent<Text>().text = "" + secCount;
        }
        //
        if (secCount >= 60)
        {
            secCount = 0;
            minCount += 1;
        }
        if (minCount <= 9)
        {
            min.GetComponent<Text>().text = "0" + minCount;
        }
        else
        {
            min.GetComponent<Text>().text = "" + minCount;
        }
    }
}
