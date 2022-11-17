using System.Collections;
using JetBrains.Annotations;
using UnityEngine;

public class MoveArm : MonoBehaviour
{
    [CanBeNull] private Animator anim;
    [CanBeNull] public GameObject armSprite, tapTxt1, tapTxt2 ;
    private bool firstTap;
    public AudioSource effect;

    private void Start()
    {
        anim = armSprite.GetComponent<Animator>();
        firstTap = true;
    }
    
    public void Update()
    {
        if (Game.Score >= 15)
            anim.speed = 1.25f;

        // счетчик касаний
        int i = 0;
        // в цикле обрабатываем все нажатия на экран
        if(!Game.pause)
            while (i < Input.touchCount)
            {
                // обрабатываем касание под номером i
                // если палец на месте, или двигается,
                // или палец только коснулся экрана
                if (Input.GetTouch(i).phase == TouchPhase.Stationary || Input.GetTouch(i).phase == TouchPhase.Moved ||
                    Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    // от точки касания выпускаем "луч" и проверяем коснулся ли он нашей кнопки
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                    {
                        if (hit.transform.name == transform.name && hit.collider.name == GetComponent<Collider>().name)
                        {
                            if (firstTap)
                            {
                                tapTxt1.SetActive(false);
                                tapTxt2.SetActive(false);
                                firstTap = false;
                            }
                        
                            effect.Play();
                            anim.SetBool("Up",true);
                            StartCoroutine(Back());
                        }
                    }
                }
                ++i;
            }
    }

    IEnumerator Back()
    {
        yield return new WaitForSeconds(0.00001f);
        anim.SetBool("Up", false);
    }
}