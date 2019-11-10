using UnityEngine;
using System.Collections;
public class AnimationScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] left;
    public Sprite[] right;
    public Sprite[] down;
    void Start()
    {
        StartCoroutine(Left());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            StopAllCoroutines();
            StartCoroutine(Left());
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            StopAllCoroutines();
            StartCoroutine(Right());
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            StopAllCoroutines();
            StartCoroutine(Down());
        }
    }
    IEnumerator Left()
    {
        int i;
        i = 0;
        while (i < left.Length)
        {
            spriteRenderer.sprite = left[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        StartCoroutine(Left());
    }
    IEnumerator Right()
    {
        int i;
        i = 0;
        while (i < right.Length)
        {
            spriteRenderer.sprite = right[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;
        }
        StartCoroutine(Right());
    }

    IEnumerator Down()
    {
        int i;
        i = 0;
        while (i < down.Length)
        {
            spriteRenderer.sprite = down[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        StartCoroutine(Down());
    }
}