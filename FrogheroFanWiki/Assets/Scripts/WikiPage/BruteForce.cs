using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BruteForce : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_Text ArticleTitle;
    [SerializeField] TMP_Text DescText;
    [SerializeField] Image ArticleImage;

    [SerializeField] Sprite newSprite;

    public void LoadFontUpdate(){
        ArticleTitle.text = "Glitter Printing Error";
        DescText.text = "...Due to the rising cost of glitter in at the end of 1991, Launchpad had to change how holographic cards worked in 1992. This card, made before the change, is an example of a holographic with glitter.";
        ArticleImage.sprite = newSprite;
    }

    public void LoadDarkKingdom(){
        ArticleTitle.text = "Dark Kingdom (Set)";
        DescText.text = "...Dark Kingdom first appeared in 1991, but it was popular enough to get a revival in 1994. These two runs use the same cardback. The revival of Dark Kingdom was ushered in with the disappearence of Lady Seraphi in the lore.";
        //ArticleImage.sprite = 
    }

    public void LoadMeteorStrike(){
        ArticleTitle.text = "Meteor Strike (Set)";
        DescText.text = "...among other things, this expansion only occured once. A reprint was planned in 1995, but was cancellled.";
        ArticleImage.sprite = newSprite;
    }

    public void LoadRedIsland(){
        ArticleTitle.text = "Red Island (Set)";
        DescText.text = "...This set is themed around Lavadrop Tropics, and is where we first meet characters like Sir Padsquire.";
        ArticleImage.sprite = newSprite;
    }

    public void LoadDragonCrystal(){
        ArticleTitle.text = "Dragon Crystal (Set)";
        DescText.text = "...A new game mechanic is introduced in Dragon Crystal. Decks came with an Evolution Token. If you put them on a creature, they could transform into powerful beasts!";
        ArticleImage.sprite = newSprite;
    }

    public void LoadDec1994Tiers(){
        ArticleTitle.text = "EDITORIAL: December 1994 Tier List";
        DescText.text = "FAN COMMENT: 'Geez, power creep is out of control. Froggy Armor Dude is now better than every card in B-Tier and below. Cyberbot in S-Tier is already rough, did the balance team disappear with Seraphi, LOL'";
        ArticleImage.sprite = newSprite;
    }

    public void LoadWaterMaiden(){
        ArticleTitle.text = "Water Maiden (Card)";
        DescText.text = "...Water Maiden is based of off a character beloved by fans in the lore. She was created to buff cards in previous Expansions, such as World Ender K. To Use Water Maiden...";
        ArticleImage.sprite = newSprite;
    }

    public void LoadCyberbot(){
        ArticleTitle.text = "Cyberbot (Card)";
        DescText.text = "...Due to how oppresively powerful the card was in competitive play, Cyberbot has only appeared in the Dark Kingdom expansion.";
        ArticleImage.sprite = newSprite;
    }

    public void LoadDarkSamurai(){
        ArticleTitle.text = "Dark Samurai (Card)";
        DescText.text = "...Dark Samurai is used in a One Turn Kill Combo deck which aims to end the game in one turn. To implement it...";
        ArticleImage.sprite = newSprite;
    }

    public void LoadWorldEnderK(){
        ArticleTitle.text = "World Ender K (Card)";
        DescText.text = "...the World Ender K card was printed both in 1991 and 1994: Dark Kingdom and Meteor Strike.";
       ArticleImage.sprite = newSprite;
    }

    public void LoadSlimeClass(){
        ArticleTitle.text = "Slime (Class)";
        DescText.text = "...the main asset of the slime class is that most cards synergize with High HP monsters with low attack.";
        ArticleImage.sprite = newSprite;
    }

    public void LoadSpiritClass(){
        ArticleTitle.text = "Spirit (Class)";
        DescText.text = "...the Spirit Class first Appeared after the Dragon Crystal expansion, to counter the Evolution mechanic introduced.";
        ArticleImage.sprite = newSprite;
    }

    public void LoadWarlockClass(){
        ArticleTitle.text = "Warlock (Class)";
        DescText.text = "...the Warlock class is exclusive to the initial release of Dark Kingdom set as well as the revival in 1994.";
        ArticleImage.sprite = newSprite;
    }

    public void LoadKoboldClass(){
        ArticleTitle.text = "Kobold (Class)";
        DescText.text = "...Kobold cards have the major property that they grow in attack when more are on the field.";
        ArticleImage.sprite = newSprite;
    }

    public void LoadLadySeraphi(){
        ArticleTitle.text = "Lady Seraphi";
        DescText.text = "...In the lead up to the Dark Kingdom reboot, Launchpad launched an ad campaign where Lady Seraphi bravely sacrificed herself for the heroes and is sent to the Shadow Pond. Human Seraphi hasn't had a card in any new expansions, though Spectral Princess Seraphi has.";
        ArticleImage.sprite = newSprite;
    }
    public void LoadFrogHeroes(){
        ArticleTitle.text = "Frog Heroes - Controversies";
        DescText.text = "Pondian Voice Actor John Smith was arrested for being involved with Pondia's underground drug smuggling ring. Due to this, all appearances of CroakStriker in the Red Island card game expansion were scrapped. The character would return 5 years later with a new voice actor.";
        ArticleImage.sprite = newSprite;
    }

}
