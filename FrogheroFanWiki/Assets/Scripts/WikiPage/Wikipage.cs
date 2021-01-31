using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wikipage
{
    public WikipageBase Base {get;set;}

    public List<ArticleButton> PageLinks{get; set;}

    public Wikipage(WikipageBase wBase){
        Base = wBase;

        PageLinks = new List<ArticleButton>();
        foreach(var clickButton in Base.ArticleLinks){
            PageLinks.Add(new ArticleButton(clickButton));
        }
    }
}
