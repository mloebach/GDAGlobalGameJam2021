using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "FrogWiki", menuName = "Wikipage/New Wikipage")]
public class WikipageBase : ScriptableObject
{
    // Start is called before the first frame update
    [BoxGroup("Main Info")]
    [LabelWidth(100)]
    [SerializeField] string titleString;

    [HorizontalGroup("Image Info")]
    [PreviewField(125)]
    [HideLabel]
    [SerializeField] Sprite articleImage;

    [BoxGroup("Basic Info")]
    [LabelWidth(100)]
    [TextArea]
    [SerializeField] string descString;
    [BoxGroup("Basic Info")]
    [SerializeField] string naniArticle;
    
    

    [SerializeField] List<LinkButton> articleLinks;

    public Sprite ArticleImage{
        get{return articleImage;}
    }
    public string DescString{
        get{return descString;}
    }
    public string NaniArticle{
        get{return naniArticle;}
    }
    public string TitleString{
        get{return titleString;}
    }
   
   public List<LinkButton> ArticleLinks{
       get{ return articleLinks;}
   }
}

[System.Serializable]
public class LinkButton{
    [SerializeField] string linkTitle;
    [SerializeField] WikipageBase wikipageBase;

    public string LinkTitle{
        get {return linkTitle;}
    }     
    public WikipageBase WikipageBase{
        get {return wikipageBase;}
    } 

}