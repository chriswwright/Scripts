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

    public Sprite[] left_drill_rocket;
    public Sprite[] right_drill_rocket;
    public Sprite[] down_drill_rocket;
    public Sprite[] up_drill_rocket;

    public Sprite[] left_rocket;
    public Sprite[] right_rocket;
    public Sprite[] down_rocket;
    public Sprite[] up_rocket;

    void Start()
    {
        StartCoroutine(Left());
    }
    void Update() //
    {
        movementNoDrill();
        movementDrill();
        movementRocket();
        movementDrillRocket();
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
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(LeftDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Left_drill());
        }
        else if (Input.GetMouseButton(1))
        {
            StopAllCoroutines();
            StartCoroutine(LeftRocket());
        }
        else
        {
            StartCoroutine(Left());
        }
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
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(RightDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Right_drill());
        }
        else if (Input.GetMouseButton(1))
        {
            StopAllCoroutines();
            StartCoroutine(RightRocket());
        }
        else
        {
            StartCoroutine(Right());
        }
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
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(DownDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Down_drill());
        }
        else if (Input.GetMouseButton(1))
        {
            StopAllCoroutines();
            StartCoroutine(DownRocket());
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
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(UpDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Up_drill());
        }
        else if (Input.GetMouseButton(1))
        {
            StopAllCoroutines();
            StartCoroutine(UpRocket());
        }
        else
        {
            StartCoroutine(Up());
        }
    }

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
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(LeftDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StartCoroutine(Left_drill());
        }
        else if (Input.GetMouseButton(1))
        {
            StopAllCoroutines();
            StartCoroutine(LeftRocket());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(Left());
        }
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
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(RightDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StartCoroutine(Right_drill());
        }
        else if (Input.GetMouseButton(1))
        {
            StopAllCoroutines();
            StartCoroutine(RightRocket());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(Right());
        }
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
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(DownDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StartCoroutine(Down_drill());
        }
        else if (Input.GetMouseButton(1))
        {
            StopAllCoroutines();
            StartCoroutine(DownRocket());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(Down());
        }
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
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(UpDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StartCoroutine(Up_drill());
        }
        else if (Input.GetMouseButton(1))
        {
            StopAllCoroutines();
            StartCoroutine(UpRocket());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(Up());
        }
    }

    IEnumerator LeftDrillRocket()
    {
        int i;
        i = 0;
        while (i < left_drill_rocket.Length)
        {
            spriteRenderer.sprite = left_drill_rocket[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {

            StartCoroutine(LeftDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Left_drill());
        }
        else if (Input.GetMouseButton(1))
        {
            StopAllCoroutines();
            StartCoroutine(LeftRocket());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(Left());
        }
    }
    IEnumerator RightDrillRocket()
    {
        int i;
        i = 0;
        while (i < right_drill_rocket.Length)
        {
            spriteRenderer.sprite = right_drill_rocket[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {

            StartCoroutine(RightDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Right_drill());
        }
        else if (Input.GetMouseButton(1))
        {
            StopAllCoroutines();
            StartCoroutine(RightRocket());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(Right());
        }
    }

    IEnumerator UpDrillRocket()
    {
        int i;
        i = 0;
        while (i < up_drill_rocket.Length)
        {
            spriteRenderer.sprite = up_drill_rocket[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {

            StartCoroutine(UpDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Up_drill());
        }
        else if (Input.GetMouseButton(1))
        {
            StopAllCoroutines();
            StartCoroutine(UpRocket());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(Up());
        }
    }
    IEnumerator DownDrillRocket()
    {
        int i;
        i = 0;
        while (i < down_drill_rocket.Length)
        {
            spriteRenderer.sprite = down_drill_rocket[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {

            StartCoroutine(DownDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Down_drill());
        }
        else if (Input.GetMouseButton(1))
        {
            StopAllCoroutines();
            StartCoroutine(DownRocket());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(Down());
        }
    }
    IEnumerator LeftRocket()
    {
        int i;
        i = 0;
        while (i < left_rocket.Length)
        {
            spriteRenderer.sprite = left_rocket[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(LeftDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Left_drill());
        }
        else if (Input.GetMouseButton(1))
        {
           
            StartCoroutine(LeftRocket());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(Left());
        }
    }
    IEnumerator RightRocket()
    {
        int i;
        i = 0;
        while (i < right_rocket.Length)
        {
            spriteRenderer.sprite = right_rocket[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(RightDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Right_drill());
        }
        else if (Input.GetMouseButton(1))
        {

            StartCoroutine(RightRocket());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(Right());
        }
    }
    IEnumerator UpRocket()
    {
        int i;
        i = 0;
        while (i < up_rocket.Length)
        {
            spriteRenderer.sprite = up_rocket[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(UpDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Up_drill());
        }
        else if (Input.GetMouseButton(1))
        {

            StartCoroutine(UpRocket());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(Up());
        }
    }
    IEnumerator DownRocket()
    {
        int i;
        i = 0;
        while (i < down_rocket.Length)
        {
            spriteRenderer.sprite = down_rocket[i];
            i++;
            yield return new WaitForSeconds(0.07f);
            yield return 0;

        }
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(DownDrillRocket());
        }
        else if (Input.GetMouseButton(0))
        {
            StopAllCoroutines();
            StartCoroutine(Down_drill());
        }
        else if (Input.GetMouseButton(1))
        {

            StartCoroutine(DownRocket());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(Down());
        }
    }
    void movementNoDrill()
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
    }
    void movementDrill()
    {
      if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && (Input.GetMouseButton(0)))
      {
          StopAllCoroutines();
          StartCoroutine(Left_drill());
      }
      if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))  && (Input.GetMouseButton(0)))
      {
          StopAllCoroutines();
          StartCoroutine(Up_drill());
      }
      if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))  && (Input.GetMouseButton(0)))
      {
          StopAllCoroutines();
          StartCoroutine(Right_drill());
      }
      if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))  && (Input.GetMouseButton(0)))
      {
          StopAllCoroutines();
          StartCoroutine(Down_drill());
      }
    }


    void movementRocket()
    {
        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(LeftRocket());
        }
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(UpRocket());
        }
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(RightRocket());
        }
        if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && (Input.GetMouseButton(1)))
        {
            StopAllCoroutines();
            StartCoroutine(DownRocket());
        }
    }

    void movementDrillRocket()
    {
        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && (Input.GetMouseButton(1)) && (Input.GetMouseButton(0)))
        {
            StopAllCoroutines();
            StartCoroutine(LeftDrillRocket());
        }
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && (Input.GetMouseButton(1)) && (Input.GetMouseButton(0)))
        {
            StopAllCoroutines();
            StartCoroutine(UpDrillRocket());
        }
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && (Input.GetMouseButton(1)) && (Input.GetMouseButton(0)))
        {
            StopAllCoroutines();
            StartCoroutine(RightDrillRocket());
        }
        if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && (Input.GetMouseButton(1)) && (Input.GetMouseButton(0)))
        {
            StopAllCoroutines();
            StartCoroutine(DownDrillRocket());
        }
    }
}
