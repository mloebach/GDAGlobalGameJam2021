using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToDeductionMode : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator transition;
    public void FromWikiToDeduction(){
        //StartCoroutine(DeductionSceneTransition());
        var wikiScene = GameObject.Find("WikiSceneObject").transform.GetChild(0).gameObject;
        wikiScene.SetActive(false);
        var deductionScene = GameObject.Find("DeductionSceneObject").transform.GetChild(0).gameObject;
        deductionScene.SetActive(true);
    }

    IEnumerator DeductionSceneTransition(){
        transition.SetTrigger("FadeToBlack");
        yield return new WaitForSeconds(1.5f);
        transition.SetTrigger("FadeToScene");
    }

}