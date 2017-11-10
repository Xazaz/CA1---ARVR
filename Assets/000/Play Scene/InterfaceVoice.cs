using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceVoice : MonoBehaviour, SpeechRecognitionInterface
{
    private bool playNow;

    public bool SpeechPhraseRecognized(string phraseTag, float condidence)
    {
        print(phraseTag);
        switch (phraseTag)
        {
            case "NOW":
                print("GGG");
                playNow = true;
                Application.LoadLevel(1);
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
        if (playNow == true)
        {
            Application.LoadLevel(1);
        }
    }
}

