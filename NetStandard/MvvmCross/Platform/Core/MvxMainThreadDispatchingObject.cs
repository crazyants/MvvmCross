// MvxMainThreadDispatchingObject.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;

namespace MvvmCross.Platform.Core
{
    public abstract class MvxMainThreadDispatchingObject
    {
        protected IMvxMainThreadDispatcher Dispatcher => MvxMainThreadDispatcher.Instance;

        protected void InvokeOnMainThread(Action action)
        {
            Dispatcher?.RequestMainThreadAction(action);
        }
    }
}