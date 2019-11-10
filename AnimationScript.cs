using UnityEngine;
using System.Collections;
public class AnimationScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] left;
    public Sprite[] right;
    public Sprite[] down;
    public Sprite[] up;

    public Sprite[] left_drill;
    public Sprite[] right_drill;
    public Sprite[] down_drill;
    public Sprite[] up_drill;
    void Start()
    {
        StartCoroutine(Left());
    }
    void Update() //
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            StopAllCoroutines();
            StartCoroutine(Left());
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            StopAllCoroutines();
            StartCoroutine(Up());
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
//Drilling Stuff

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Left_drill());
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))  && (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Up_drill());
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))  && (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Right_drill());
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))  && (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Down_drill());
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
