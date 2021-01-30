using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx.Async;
using Naninovel;


public class CloseConfirmMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject confirmPanel;
    public void CloseMenu(){
        confirmPanel.SetActive(false);
    }

    public void OpenMenu(){
        confirmPanel.SetActive(true);
    }

    public void endScene(){
        //string scriptToSend = GetNaniScript(gameStateSystem.gameLevel);
        var switchCommand = new SwitchToVNMode {ScriptName = "EndScene"};
	    switchCommand.ExecuteAsync().Forget();
        
    }
}
