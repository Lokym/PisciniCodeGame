using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Score : Singleton<Score> {

    public int value;
    public int value2;
    public Text Scoretxt;
    public Text Scoretxt2;

    public void ChangeVal(int val, int val2)
    {
        value += val;
        value2 += val2;
    }



    private void Update()
    {
        Scoretxt.text = value.ToString();
        Scoretxt2.text = value2.ToString();
    }

}
