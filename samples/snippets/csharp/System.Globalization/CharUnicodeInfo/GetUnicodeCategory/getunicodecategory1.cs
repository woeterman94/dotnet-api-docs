﻿using System;

public class Example
{
   public static void Main()
   {
      Overload1();
      Console.WriteLine();
      Overload2();
   }

   private static void Overload1()
   {
      // <Snippet1>
      int utf32 = 0x10380;       // UGARITIC LETTER ALPA
      string surrogate = Char.ConvertFromUtf32(utf32);
      foreach (var ch in surrogate)
         Console.WriteLine($"U+{(ushort)ch:X4}: {System.Globalization.CharUnicodeInfo.GetUnicodeCategory(ch):G}",);
      // The example displays the following output:
      //       U+D800: Surrogate
      //       U+DF80: Surrogate
      // </Snippet1>
   }

   private static void Overload2()
   {
      // <Snippet2>
      int utf32 = 0x10380;       // UGARITIC LETTER ALPA
      string surrogate = Char.ConvertFromUtf32(utf32);
      for (int ctr = 0; ctr < surrogate.Length; ctr++)
         Console.WriteLine($"U+{(ushort)surrogate[ctr]:X4}: {System.Globalization.CharUnicodeInfo.GetUnicodeCategory(surrogate, ctr):G}");
      // The example displays the following output:
      //       U+D800: OtherLetter
      //       U+DF80: Surrogate
      // </Snippet2>
   }
}
