﻿using JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2;
using JetBrains.ReSharper.Psi.Impl.Caches2.WordIndex;

namespace JetBrains.ReSharper.Psi.FSharp.Impl
{
  internal class FSharpWordIndexLanguageProvider : IWordIndexLanguageProvider
  {
    public bool CaseSensitiveIdentifiers
    {
      get
      {
        return true;
      }
    }

    public bool IsIdentifierFirstLetter(char ch)
    {
      return ch.IsLetterFast() || ch == '_';
    }

    public bool IsIdentifierSecondLetter(char ch)
    {
      return ch.IsLetterOrDigitFast() || ch == '_';
    }
  }
}
