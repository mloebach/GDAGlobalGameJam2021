using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WikipageLogic : MonoBehaviour
{

    [SerializeField] TMP_Text articleTitle;
    [SerializeField] Button articleDesc;
    [SerializeField] Image articleImage;
    // Start is called before the first frame update
    [SerializeField] WikipageBase currentPage;

    public event Action OnWikiOver;
    public Wikipage loadPage {get; set;} 



    Wikipage _wikipage;
    void Start()
    {
        
    }

    private void Awake(){
        
    }

    public void SetData(Wikipage wikipage){
        _wikipage = wikipage;

        articleTitle.text = wikipage.Base.TitleString;
        articleDesc.GetComponentInChildren<TMP_Text>().text = wikipage.Base.DescString;
        //load naniscript
        articleImage.GetComponent<Image>().sprite = wikipage.Base.ArticleImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bootUpWiki(){
        StartCoroutine(LoadWikipage());
    }

    public IEnumerator LoadWikipage(){
        loadPage = new Wikipage(currentPage);
        SetData(loadPage);
        yield return new WaitForSeconds(0f);
    }
}
