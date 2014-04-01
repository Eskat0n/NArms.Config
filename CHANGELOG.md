### Version 1.1.0

*  Added parsing support for Guid and Guid? configuration properties. Any .NET built-in Guid format is supported 
(Issue [#3](https://github.com/Eskat0n/NArms.Config/issues/3)).
*  Added parsing support for TimeSpan and TimeSpan? configuration properties. Any .NET built-in TimeSpan format is supported as well as custom shorthand units
such as seconds, minutes, hours and days (Issue [#4](https://github.com/Eskat0n/NArms.Config/issues/4)).

### Version 1.0.0

*  First version :)
*  Works with string and integer configuration properties
*  Supported attributes: ConfigKeyName, ConfigIgnore, ConfigOptional, ConfigDefault
*  Changeable configuration file readers
*  Only instantiated config objects are supported