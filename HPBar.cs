using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{
    [SerializeField] GameObject health;

    public void start()
    {
        health.transform.localScale = new Vector3(0.25f,1f);
}
}
