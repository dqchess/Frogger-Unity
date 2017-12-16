using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {

    public AudioMixer audiomixer;

    Resolution[] resolutions;

    public Dropdown resolutiondropdown;

    private void Start()
    {
        resolutions = Screen.resolutions;
        resolutiondropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentresolutionindex = 0;
        for(int i=0;i<resolutions.Length;i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentresolutionindex = i;
            }
        }
        resolutiondropdown.AddOptions(options);
        resolutiondropdown.value = currentresolutionindex;
        resolutiondropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionindex)
    {
        Resolution resolution = resolutions[resolutionindex];
        Screen.SetResolution(resolution.width,resolution.height,Screen.fullScreen);
    }

    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("Volume",volume-80);
    }

    public void SetQuality(int qualityindex)
    {
        QualitySettings.SetQualityLevel(qualityindex);
    }

    public void SetFullscreen(bool isfullscreen)
    {
        Screen.fullScreen = isfullscreen;
    }
}
