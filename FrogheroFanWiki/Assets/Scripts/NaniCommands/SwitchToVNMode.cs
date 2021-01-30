using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using Naninovel.Commands;
using UniRx.Async;
public class SwitchToVNMode : Command
{
    // Start is called before the first frame update
    public StringParameter ScriptName;
    public StringParameter Label;
    public override async UniTask ExecuteAsync (CancellationToken cancellationToken = default){
        Debug.Log($"Loading: {ScriptName}");

        var deductionScene = GameObject.Find("DeductionSceneObject").transform.GetChild(0).gameObject;
        deductionScene.SetActive(false);
        var wikiScene = GameObject.Find("WikiSceneObject").transform.GetChild(0).gameObject;
        wikiScene.SetActive(false);
        
        if(Assigned(ScriptName)){
            Debug.Log($"Entering: {ScriptName}");
            var scriptPlayer = Engine.GetService<IScriptPlayer>();
            await scriptPlayer.PreloadAndPlayAsync(ScriptName,
                                                   label: Label);
        }
        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = true;

        
    }

}
