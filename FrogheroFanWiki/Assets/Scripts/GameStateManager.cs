
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using UniRx.Async;

public enum GameState {VN, Wiki, Deduction}
public class GameStateManager : MonoBehaviour
{
    [SerializeField] WikipageLogic wikiScene;
    public Animator transition;
    // Start is called before the first frame update
    GameState state;
    private void Start()
    {
        //var switchCommand = new SwitchToVNMode {"LoadTitleUI"};
	    //switchCommand.ExecuteAsync().Forget();
        //var switchCommand = new SwitchToVNMode {ScriptName = "LoadTitleUI"};
	    //switchCommand.ExecuteAsync().Forget();
    }

    void StartWiki(){
        state = GameState.Wiki;
        wikiScene.bootUpWiki();
        //transition.SetTrigger("FadeToScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
