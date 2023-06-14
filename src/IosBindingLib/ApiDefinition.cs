using System;
using Foundation;
using ObjCRuntime;

namespace IosBindingLib;

[BaseType(typeof(NSObject))]
interface MyWidget
{
    [Export("doSomething")]
    void DoSomething();
}
