using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArticleButton
{
    public LinkButton linkButton {get;set;}

    public TMP_Text linkText;
    public WikipageBase buttonWikipageBase;

    //public int linkNumber = 0;

    public ArticleButton(LinkButton lBase){
        /*linkButton = lBase;

        //set text
        linkText.text = lBase.LinkTitle;
        //set link
        buttonWikipageBase = lBase.WikipageBase;*/
        
    }

    /*(public int getLinkNumber{
        get{return linkNumber;}
    }*/

}


public class LoadNewWikipage : MonoBehaviour
{
    // Start is called before the first frame update
    /*[SerializeField] WikipageLogic wikipageLogic;
    public void LoadNewWiki(){
        Debug.Log("click");
        //Get ScriptableWebpageObject from LinkButton
        Debug.Log(button);
        Debug.Log(button.buttonWikipageBase.name);
        Debug.Log(button.buttonWikipageBase.TitleString);
        WikipageBase newPage = button.buttonWikipageBase;
        //Load said object into scene
        wikipageLogic.SetData(new Wikipage(newPage));
    }*/

}
