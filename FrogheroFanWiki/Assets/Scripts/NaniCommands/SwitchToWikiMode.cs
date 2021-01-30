using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using Naninovel.Commands;
using UniRx.Async;

[CommandAlias("wikiStart")]
public class SwitchToAdventureMode : Command
{
    public override async UniTask ExecuteAsync (CancellationToken cancellationToken = default)
    {
        /*Debug.Log(GameObject.Find("TransitionEffects").name);
        Debug.Log(GameObject.Find("TransitionEffects").transform.GetChild(0).name);
        var fadeOut= GameObject.Find("TransitionEffects").transform.GetChild(0).GetComponent<Canvas>().transform.Find("FadeToBlack");
        Debug.Log(fadeOut.name);
        var animator = fadeOut.GetComponent<Animator>();
        animator.SetTrigger("FadeToBlack");*/


        var deductionScene = GameObject.Find("DeductionSceneObject").transform.GetChild(0).gameObject;
        deductionScene.SetActive(false);
        // 1. Disable Naninovel input.
        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = false;

        // 2. Stop script player.
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.Stop();

        // 3. Reset state.
        var stateManager = Engine.GetService<IStateManager>();
        //await stateManager.SaveGameAsync("varStorage");
        await stateManager.ResetStateAsync();

        // 4. Switch cameras.
        var advCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        advCamera.enabled = true;
        var naniCamera = Engine.GetService<ICameraManager>().Camera;
        naniCamera.enabled = false;

        // 5. Enable character control.
        //var controller = Object.FindObjectOfType<CharacterController3D>();
        //controller.IsInputBlocked = false;
        //var detectiveScene =  GameObject.Find("DetectiveSceneObject");
        var wikiScene = GameObject.Find("WikiSceneObject").transform.GetChild(0).gameObject;
        wikiScene.SetActive(true);
        wikiScene.GetComponent<WikipageLogic>().bootUpWiki();
        //detectiveScene.enabled = true;

        //var gameManagerScene = GameObject.Find("GameStateSystem");
        //animator.SetTrigger("FadeToScene");


    }
}