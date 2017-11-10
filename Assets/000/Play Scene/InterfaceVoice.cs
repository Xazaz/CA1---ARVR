using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceVoice : MonoBehaviour, SpeechRecognitionInterface
{
    private bool playNow;
    private bool joinNow;
    private bool createNow;
    private bool aiNow;
    private bool quitNow;

    public bool SpeechPhraseRecognized(string phraseTag, float condidence)
    {
        print(phraseTag);
        switch (phraseTag)
        {
            case "NOW":
                print("GGG");
                playNow = true;
                break;
            case "JOINN":
                print("JJJ");
                joinNow = true;
                break;
            case "CREATEE":
                print("CCC");
                createNow = true;
                break;
            case "AII":
                print("AAA");
                aiNow = true;
                break;
            case "QUITT":
                print("QQQ");
                quitNow = true;
                break;

        }

        return true;
    }

    // invoked when a speech phrase gets recognized
    //public bool SpeechPhraseRecognized(string phraseTag, float condidence)
    //{
    ////    print(phraseTag);
    ////    switch (phraseTag)
    ////    {
    ////        case "PLAY":
    ////            print("GGG");
    ////            playNow = true;
    ////            Application.LoadLevel(1);
    ////            break;
    ////    }

    ////    return true;
    //}

    void FixedUpdate()
    {
      
    }
}

