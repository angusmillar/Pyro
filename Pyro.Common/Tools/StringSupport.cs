﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyro.Common.Tools
{
  public class StringSupport
  {
    public static string RemoveDiacritics(string text)
    {
      return string.Concat(
          text.Normalize(NormalizationForm.FormD)
          .Where(ch => System.Globalization.CharUnicodeInfo.GetUnicodeCategory(ch) !=
                       System.Globalization.UnicodeCategory.NonSpacingMark)
        ).Normalize(NormalizationForm.FormC);
    }

    public static string ToLowerFast(string text)
    {
      return text.ToLower(System.Globalization.CultureInfo.CurrentCulture);
    }

    public static string ToLowerAndRemoveDiacritics(string text)
    {
      return ToLowerFast(RemoveDiacritics(text));
    }

    public static int GetScaleFromDecimal(string value)
    {
      const string DecimalPoint = ".";
      if (value.Contains(DecimalPoint))
      {
        return value.Length - (value.IndexOf(DecimalPoint) + 1);
      }
      else
      {
        return 0;
      }
    }

    public static int GetPrecisionFromDecimal(string value)
    {
      const string DecimalPoint = ".";
      if (value.Contains(DecimalPoint))
      {
        return value.Length - 1;
      }
      else
      {
        return value.Length;
      }
    }


  }
}
