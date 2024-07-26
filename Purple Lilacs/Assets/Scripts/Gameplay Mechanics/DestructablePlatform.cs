using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestructablePlatform : MonoBehaviour
{
    int disappearTimer = 1;
    int reappearTimer = 4;

    BoxCollider2D boxCollider;
    Renderer r;
    Color newColor;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        r = GetComponent<Renderer>();
        newColor = r.material.color;
    }

    public void CoroutineCaller()
    {
        StartCoroutine(FadeOut(disappearTimer));
        StartCoroutine(FadeIn(reappearTimer));
    }

    public IEnumerator FadeOut(int delay)
    {
        yield return new WaitForSeconds(delay);
        newColor.a = 0.2f;
        r.material.color = newColor;
        gameObject.layer = 0;
        StartCoroutine(Disappear());
    }
    IEnumerator FadeIn(int delay)
    {
        yield return new WaitForSeconds(delay);
        newColor.a = 1.0f;
        r.material.color = newColor;
        gameObject.layer = 6;
        StartCoroutine(Reappear());
    }
    IEnumerator Disappear()
    {
        boxCollider.enabled = false;
        yield return null;
    }
    IEnumerator Reappear()
    {
        boxCollider.enabled = true;
        yield return null;
    }
}
