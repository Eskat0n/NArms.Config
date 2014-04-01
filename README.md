# NArms.Config

[![Build status](https://ci.appveyor.com/api/projects/status/s7me5u8cfiw2mrrk)](https://ci.appveyor.com/project/Eskat0n/narms-config)

## What is this?

Tiny configuration object binder. NArms.Config allows to read appSettings section values from .config files as regular object properties. 
Various validations and parsing rules can be applied on them. This library is not intended to replace Custom Sections, its only purpose is 
to boost development of applications with many configuration parameters and to preserve .config file consistensy when editing it 
manually at runtime.

## Usage

Let's assume you have App.config file with following content:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="StringProperty" value="StringProperty test value" />
    <add key="IntegerProperty" value="4321" />
    <add key="GuidProperty" value="89e4745c-11f1-47fd-b7e0-efe3dac5a8d6" />
    <add key="TimeSpanProperty" value="10:20:30" />
  </appSettings>
</configuration>
```

Now you can access this settings by reading properties values of following class (all you need is just to instantiate it):

```c#
using System;
using NArms.Config;

public class Config : ConfigBase
{
    public string StringProperty { get; set; }
    public int IntegerProperty { get; set; }
    public Guid GuidProperty { get; set; }   
    public TimeSpan TimeSpanProperty { get; set; } 
}
```

For the complete reference please look at following documentation (TODO: add link to documentation).

## Installation

NArms.Config is available through [NuGet](http://www.nuget.org/packages/NArms.Config), to install it simply type following line in your Package Manager Console and hit Enter:

`Install-Package NArms.Config`

Alternatively you can download both archived version and symbols for this project (TODO: add links to archives).

## Author

Timur Rakhmatillaev, muyou.prj@gmail.com

## License

NArms.Config is available under the MIT license. See the LICENSE file for more info.