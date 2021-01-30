using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using Naninovel.Commands;
using UniRx.Async;

public class NaniOverGameplay : Command
{
    public StringParameter ScriptName;
    public StringParameter Label;
    public override async UniTask ExecuteAsync (CancellationToken cancellationToken = default){

        /*var deductionScene = GameObject.Find("DeductionSceneObject").transform.GetChild(0).gameObject;
        deductionScene.SetActive(false);*/
        /*var wikiScene = GameObject.Find("WikiSceneObject").transform.GetChild(0).gameObject;
        wikiScene.SetActive(false);*/
        
        var advCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        advCamera.enabled = false;
        var naniCamera = Engine.GetService<ICameraManager>().Camera;
        naniCamera.enabled = true;

        if(Assigned(ScriptName)){
            Debug.Log($"NaniGameplay: {ScriptName}.{Label}");
            var scriptPlayer = Engine.GetService<IScriptPlayer>();
            await scriptPlayer.PreloadAndPlayAsync(ScriptName,
                                                   label: Label);
        }
        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = true;

        
    }
}
