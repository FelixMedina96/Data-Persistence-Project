using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Main Main;

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        Main.GameOver();
    }
}
