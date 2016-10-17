using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Chapters.C09_Platform_specific_API_calls
{
  public interface IPlatformSoundPlayer
  {
    void PlaySound(Int32 samplingRate, byte[] pcmData);
  }
}
