// IMvxSourcePropertyPathParser.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System.Collections.Generic;
using MvvmCross.Binding.Parse.PropertyPath.PropertyTokens;

namespace MvvmCross.Binding.Parse.PropertyPath
{
    public interface IMvxSourcePropertyPathParser
    {
        IList<MvxPropertyToken> Parse(string textToParse);
    }
}