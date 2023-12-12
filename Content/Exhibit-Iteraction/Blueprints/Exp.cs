using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exp : MonoBehaviour
{
    public float ExpTime = 0.2f;
    public AudioClip ExpSFX;
    private void Start()
    {
        ExpSFX.Play();
        Invoke("DestroyDmg", ExpTime);
    }
    public void DestroyDmg()
    {
        Destroy(GetComponent<DMG>());
    }
}
