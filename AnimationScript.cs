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

        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && (Input.GetMouseButton(0)))
        {
            //StopAllCoroutines();
            StartCoroutine(Left_drill());
        }
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))  && (Input.GetMouseButton(0)))
        {
            //StopAllCoroutines();
            StartCoroutine(Up_drill());
        }
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))  && (Input.GetMouseButton(0)))
        {
            //StopAllCoroutines();
            StartCoroutine(Right_drill());
        }
        if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))  && (Input.GetMouseButton(0)))
        {
            //t StopAllCoroutines();
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
        if (Input.GetMouseButton(0))
        {
          StartCoroutine(Left_drill())
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
        if (Input.GetMouseButton(0))
        {
          StartCoroutine(Right_drill())
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
        if (Input.GetMouseButton(0))
        {
          StartCoroutine(Down_drill())
        }
        else
        {
          StartCoroutine(Down());
        }
    }
    IEnumerator Up()
    {
        int i;
        i = 0;
        while (i < up.Length)
        {
            spriteRenderer.sprite = up[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        if (Input.GetMouseButton(0))
        {
          StartCoroutine(Up_drill())
        }
        StartCoroutine(Up());
    }

//Drilly_Bois
    IEnumerator Left_drill()
    {
        int i;
        i = 0;
        while (i < left_drill.Length)
        {
            spriteRenderer.sprite = left_drill[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        StartCoroutine(Left_drill());
    }
    IEnumerator Right_drill()
    {
        int i;
        i = 0;
        while (i < right_drill.Length)
        {
            spriteRenderer.sprite = right_drill[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;
        }
        StartCoroutine(Right_drill());
    }

    IEnumerator Down_drill()
    {
        int i;
        i = 0;
        while (i < down_drill.Length)
        {
            spriteRenderer.sprite = down_drill[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        StartCoroutine(Down_drill());
    }
    IEnumerator Up_drill()
    {
        int i;
        i = 0;
        while (i < up_drill.Length)
        {
            spriteRenderer.sprite = up_drill[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        StartCoroutine(Up_drill());
    }

}
