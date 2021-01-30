using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx.Async;
using Naninovel;

public class PlayArticleFromNani : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] WikipageLogic wikipage;

    public void ReadArticle(){
        /*Wikipage currentPage = wikipage.loadPage;
        string labelToLoad = currentPage.Base.NaniArticle;
        var switchCommand = new NaniOverGameplay {ScriptName = "Wiki", Label = labelToLoad};
	    switchCommand.ExecuteAsync().Forget();*/
        
    }
}
