using System;
using System.Collections.Generic;
using System.Text;

namespace LearnSharedApp.C09_Platform_specific_API_calls
{
    public interface IPlatformInfo
    {
      String Model { get; }
      String Version { get; }
    }
}
