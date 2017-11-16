using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Score : Singleton<Score> {

    public int value = 10;
    public Text Scoretxt;

    public void ChangeVal(int val)
    {
        value = val;
    }

    private void Update()
    {
        Scoretxt.text = value.ToString();
    }

}
