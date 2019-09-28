using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 关卡 : MonoBehaviour
{
    public 金币 jinbi;
    // Start is called before the first frame update
    private static int i = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int GetCheck()
    {
        return i;
    }
    public void addCheck(int x)
    {
        i = i + x;
        
    }
    public void Automatic()
    {
        i++;
    }
    public void Reduce()
    {
        i--;
    }
    public void Reduce(int x)
    {
        i = i - x;
    }
    public bool Judeg()
    {
        return jinbi.Judge();
    }

}
