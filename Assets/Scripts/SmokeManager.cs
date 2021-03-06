﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class SmokeManager : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(RemoveSmoke());
        GetComponent<ParticleSystem>().Play();
    }

    IEnumerator RemoveSmoke()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }

}
