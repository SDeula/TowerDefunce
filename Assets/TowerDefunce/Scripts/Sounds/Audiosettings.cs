using UnityEngine;
using UnityEngine.Audio;

public class Audiosettings : MonoBehaviour {

    public AudioMixer audioMixer;

    public	void SetMasterVolume (float volume) {

        audioMixer.SetFloat(name: "MasterVol",value: volume);
	}

    public void SetMusicVolume(float volume)
    {

        audioMixer.SetFloat(name: "MusicVol",value: volume);
    }

    public void SetSFXVolume(float volume)
    {

        audioMixer.SetFloat(name: "SFXVol", value: volume);
    }

}
