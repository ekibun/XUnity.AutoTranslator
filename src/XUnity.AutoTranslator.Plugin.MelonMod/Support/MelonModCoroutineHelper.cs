﻿using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using XUnity.AutoTranslator.Plugin.Core.Support;

namespace XUnity.AutoTranslator.Plugin.MelonMod.Support
{
   internal class MelonModCoroutineHelper : ICoroutineHelper
   {
      public object CreateWaitForSeconds( float seconds )
      {
         return new WaitForSeconds( seconds );
      }

      public object CreateWaitForSecondsRealtime( float delay )
      {
         return new WaitForSecondsRealtime( delay );
      }

      public object Start( IEnumerator coroutine )
      {
         return MelonCoroutines.Start( coroutine );
      }

      public void Stop( object coroutine )
      {
         MelonCoroutines.Stop( coroutine );
      }

      public bool SupportsCustomYieldInstruction()
      {
         return true;
      }
   }
}