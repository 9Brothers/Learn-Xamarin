using System;
using System.Collections.Generic;
using System.Text;
using Learn.Chapters.C09_Platform_specific_API_calls;
using Xamarin.Forms;
using System.IO;
using Foundation;
using AVFoundation;

[assembly: Dependency(typeof(Learn.iOS.Chapters.C09.PlatformSoundPlayer))]

namespace Learn.iOS.Chapters.C09
{
  class PlatformSoundPlayer : IPlatformSoundPlayer
  {
    const Int32 numChannels = 1;
    const Int32 bitsPerSample = 16;

    public void PlaySound(int samplingRate, byte[] pcmData)
    {
      Int32 numSamples = pcmData.Length / (bitsPerSample / 8);

      var memoryStream = new MemoryStream();
      var writer = new BinaryWriter(memoryStream, Encoding.ASCII);

      writer.Write(new char[] { 'R', 'I', 'F', 'F' });
      writer.Write(32 + sizeof(short) * numSamples);
      writer.Write(new char[] { 'W', 'A', 'V', 'E' });
      writer.Write(new char[] { 'f', 'm', 't', ' ' });
      writer.Write(16); // PCM chunk size 
      writer.Write((short)1); // PCM format flag 
      writer.Write((short)numChannels);
      writer.Write(samplingRate);
      writer.Write(samplingRate * numChannels * bitsPerSample / 8); // byte rate 
      writer.Write((short)(numChannels * bitsPerSample / 8)); // block align 
      writer.Write((short)bitsPerSample);
      writer.Write(new char[] { 'd', 'a', 't', 'a' }); // data chunk
      writer.Write(numSamples * numChannels * bitsPerSample / 8);

      writer.Write(pcmData, 0, pcmData.Length);

      memoryStream.Seek(0, SeekOrigin.Begin);

      var data = NSData.FromStream(memoryStream);

      AVAudioPlayer audioPlayer = AVAudioPlayer.FromData(data);
      audioPlayer.Play();
    }
  }
}
