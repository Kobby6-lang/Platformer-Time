using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PortfolioMain : MonoBehaviour
{
    public Image displayImage;
    Sprite[] imagesToDisplay;
    int currentImageIndex;
    bool slideShow = false;
   public void LoadMainMenu(string MainMenu) 
   {
        SceneManager.LoadScene(MainMenu);
   }

    public void ShowImage(Sprite image)
    {
        displayImage.gameObject.SetActive (true);
        displayImage.overrideSprite = image;
    }

    public void SlideShow(ImageHolder imageHolder) 
    {
        imagesToDisplay = imageHolder.images;
        displayImage.gameObject.SetActive(true);
        currentImageIndex = 0;
        displayImage.overrideSprite = imagesToDisplay[currentImageIndex];
        slideShow = true;
    }
    public void NextPicture() 
    {
        if(slideShow) 
        {
            if (currentImageIndex + 1 < imagesToDisplay.Length) 
            {
                currentImageIndex++;
                displayImage.overrideSprite = imagesToDisplay[currentImageIndex];
            }
        }
    }
}
