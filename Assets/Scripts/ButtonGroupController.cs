using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGroupController : MonoBehaviour
{
    public Button ButtonSpeed, ButtonGravity, ButtonTooths, ButtonToothSize, ButtonMarketing;
    GameInUpgrade1 GameInUpgrade1 = new GameInUpgrade1();
    void Start()
    {
        Controller(GameInUpgrade1.SpeedPrice,ButtonSpeed);
        Controller(GameInUpgrade1.GravityPrice, ButtonGravity);
        Controller(GameInUpgrade1.ToothsPrice, ButtonTooths);
        Controller(GameInUpgrade1.ToothSizePrice, ButtonToothSize);
        Controller(GameInUpgrade1.MarketingPrice, ButtonMarketing);
    }
  
    public void Controller(int ButtonValue,Button Button)
    {
      if (Money.money < ButtonValue)
      {
        Button.interactable = false;
      }
    } 
    private void OnCollisionEnter(Collision collision)
    {
        Controller(GameInUpgrade1.SpeedPrice, ButtonSpeed);
        Controller(GameInUpgrade1.GravityPrice, ButtonGravity);
        Controller(GameInUpgrade1.ToothsPrice, ButtonTooths);
        Controller(GameInUpgrade1.ToothSizePrice, ButtonToothSize);
        Controller(GameInUpgrade1.MarketingPrice, ButtonMarketing);
    }
   
}
