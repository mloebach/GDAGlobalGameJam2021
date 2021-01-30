using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class SplashScreen : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Image logoImage;
    [SerializeField] TMP_Text textString;
    void Start()
    {
        logoImage.DOFade(0f, 0f);
        textString.DOFade(0f, 0f);
        StartCoroutine(ToMainMenu());
    }

    IEnumerator ToMainMenu(){
        
        StartCoroutine(FadeIn());
        yield return new WaitForSeconds(3);
        //StartCoroutine(FadeOut());
        SceneManager.LoadScene(1);
    }

    IEnumerator FadeIn(){
        var loadIn = DOTween.Sequence();
        loadIn.Append(logoImage.DOFade( 1f, 0.5f));
        loadIn.Join(textString.DOFade( 1f, 0.5f));
        yield return new WaitForSeconds(0.5f);
    }
    IEnumerator FadeOut(){
        var loadOut = DOTween.Sequence();
        loadOut.Append(logoImage.DOFade(0f, 0.5f));
        loadOut.Join(textString.DOFade(0f, 0.5f));
        yield return new WaitForSeconds(0.5f);
    }
}
