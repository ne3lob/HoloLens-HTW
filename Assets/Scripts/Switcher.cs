using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    // Start is called before the first frame update

    public void Switching( Animator animator, string name)
    {
        animator.SetTrigger(name);
    }


    public IEnumerator LabelCall(GameObject label, float seconds)
    {
        label.SetActive(true);

        yield return new WaitForSeconds(seconds);

        label.SetActive(false);
    }
}