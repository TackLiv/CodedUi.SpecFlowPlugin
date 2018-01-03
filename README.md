CodedUi.SpecFlowPlugin
===
A SpecFlow plugin enabling generation of CodedUI tests

Usage
---

It's avaiable as NuGet package: 

https://www.nuget.org/packages/TackLiv.CodedUi.SpecFlowPlugin

Simply add the package through NuGet, then the configuration would be merged like:

```
    <specFlow>
        <unitTestProvider name="MsTest" />
        <plugins>
            <add name="CodedUi" path="..\packages\CodedUi.SpecFlowPlugin.1.0.0-beta\lib\net45" type="Generator" />
        </plugins>
    </specFlow>
```

Correct the `path="..\packages\CodedUi.SpecFlowPlugin.1.0.0-beta\lib\net45"` to the real location of corresponding version, then it's ready to be used.

Reference
---
https://github.com/techtalk/SpecFlow/wiki/Using-SpecFlow-with-CodedUI-API
http://blog.majcica.com/2015/05/07/getting-started-with-specflow-and-codedui/
https://github.com/SpecFlow-Plugins/coded-ui