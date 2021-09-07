using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton
{
    private static Singleton singleton;
    private int N = 0;
    public int Count { get { return N; } }

    public Singleton()
    {
        singleton = this;
    }

}
