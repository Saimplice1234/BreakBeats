using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{   
    public Animator Fader;
    public float TimeSwitchScene;
    public void Reload(){
        StartCoroutine(ReloadScene());
    }
    IEnumerator ReloadScene(){
        Fader.Play("FadeIn");
        yield return new WaitForSeconds(TimeSwitchScene);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
