using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleAnimationSound : MonoBehaviour
{
    public AudioSource SoundNormal;
    public AudioSource SoundRapid;
    public AudioSource SoundLaboured;
    public AudioSource SoundRhonchi;
    public AudioSource SoundPain;
    public AudioSource SoundAwake;
    public AudioSource SoundChinLift;
    public AudioSource SoundChoking;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlaySoundMaleBreathing_Normal()
    {
        SoundNormal.Play();
    }

    private void PlaySoundMaleBreathing_Rapid()
    {
        SoundRapid.Play();
    }

    private void PlaySoundMaleBreathing_Laboured()
    {
        SoundLaboured.Play();
    }

    private void PlaySoundMaleBreathing_Rhonchi()
    {
        SoundRhonchi.Play();
    }

    private void PlaySoundMalePain()
    {
        SoundPain.Play();
    }

    private void PlaySoundMaleAwake()
    {
        SoundAwake.Play();
    }

    private void PlaySoundMaleChinLift()
    {
        SoundChinLift.Play();
    }
    
    private void PlaySoundMaleChoking()
    {
        SoundChoking.Play();
    }
}
