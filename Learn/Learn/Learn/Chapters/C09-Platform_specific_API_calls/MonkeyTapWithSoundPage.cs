using Learn.Chapters.C08_Code_and_XAML_in_Harmony;
using System;

namespace Learn.Chapters.C09_Platform_specific_API_calls
{
  class MonkeyTapWithSoundPage : MonkeyTapPage
  {
    const Int32 errorDuration = 500;

    double[] frequencies = { 523.25, 622.25, 739.99, 880 };

    protected override void FlashBoxView(int index)
    {
      SoundPlayer.PlaySound(frequencies[index], flashDuration);
      base.FlashBoxView(index);
    }
    
    protected override void EndGame()
    {
      SoundPlayer.PlaySound(65.4, errorDuration);
      base.EndGame();
    }
  }
}
