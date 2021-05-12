using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    private int animationNumber = 1;


    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) { animationNumber = 1; AnimationSwitcher(); }      
        if (Input.GetKeyDown(KeyCode.Alpha2)) { animationNumber = 2; AnimationSwitcher(); }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { animationNumber = 3; AnimationSwitcher(); }
        if (Input.GetKeyDown(KeyCode.Alpha4)) { animationNumber = 4; AnimationSwitcher(); }
        if (Input.GetKeyDown(KeyCode.Alpha5)) { animationNumber = 5; AnimationSwitcher(); }
        if (Input.GetKeyDown(KeyCode.Alpha6)) { animationNumber = 6; AnimationSwitcher(); }
        if (Input.GetKeyDown(KeyCode.Alpha7)) { animationNumber = 7; AnimationSwitcher(); }
        if (Input.GetKeyDown(KeyCode.Alpha8)) { animationNumber = 8; AnimationSwitcher(); }        
    }

    private void AnimationSwitcher()
    {
        SoundsStop();
        switch (animationNumber)
        {
            case 1:
                animator.SetInteger("Selector", 1);
                StartCoroutine(SoundRepeatDelay(1, 10f));
                break;
            case 2:
                animator.SetInteger("Selector", 2);
                StartCoroutine(SoundRepeatDelay(2, 2.800f));
                break;
            case 3:
                animator.SetInteger("Selector", 3);
                StartCoroutine(SoundRepeatDelay(3, 2.133f));
                break;
            case 4:
                animator.SetInteger("Selector", 4);
                SoundsContainer.sounds[3].Play();
                break;
            case 5:
                animator.SetInteger("Selector", 5);
                SoundsContainer.sounds[4].Play();
                break;
            case 6:
                animator.SetInteger("Selector", 6);
                StartCoroutine(SoundRepeatDelay(6, 2.167f));
                break;
            case 7:
                animator.SetInteger("Selector", 7);
                StartCoroutine(SoundRepeatDelay(7, 14.400f));
                break;
            case 8:
                animator.SetInteger("Selector", 8);
                StartCoroutine(SoundRepeatDelay(8, 1.167f));
                break;
        }
    }

    public void OnClickNextAnimation()
    {
        if (animationNumber == 8) animationNumber = 1;
        else animationNumber++;
        AnimationSwitcher();
    }

    public void OnClickPreviousAnimation()
    {
        if (animationNumber == 1) animationNumber = 8;
        else animationNumber--;
        AnimationSwitcher();
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    private void SoundsStop()
    {
        StopAllCoroutines();
        for (int i = 0; i < SoundsContainer.sounds.Length; i++)
        {
            SoundsContainer.sounds[i].Stop();
        }
    }
    IEnumerator SoundRepeatDelay(int SoundNumber, float Delay)
    {
        while (true)
        {
            SoundsContainer.sounds[SoundNumber - 1].Play();
            yield return new WaitForSeconds(Delay);
        }        
    }
}
