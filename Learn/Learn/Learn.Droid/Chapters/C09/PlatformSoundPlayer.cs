using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Learn.Chapters.C09_Platform_specific_API_calls;
using Android.Media;

[assembly: Dependency(typeof(Learn.Droid.Chapters.C09.PlatformSoundPlayer))]

namespace Learn.Droid.Chapters.C09
{
  class PlatformSoundPlayer : IPlatformSoundPlayer
  {
    AudioTrack previousAudioTrack;
    public void PlaySound(int samplingRate, byte[] pcmData)
    {
      if (previousAudioTrack != null)
      {
        previousAudioTrack.Stop();
        previousAudioTrack.Release();
      }

      var audioTrack = new AudioTrack(
        Stream.Music,
        samplingRate,
        ChannelOut.Mono,
        Android.Media.Encoding.Pcm16bit,
        pcmData.Length * sizeof(short),
        AudioTrackMode.Static);

      audioTrack.Write(pcmData, 0, pcmData.Length);
      audioTrack.Play();

      previousAudioTrack = audioTrack;
    }
  }
}