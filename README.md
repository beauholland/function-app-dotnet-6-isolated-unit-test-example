Want to create a simple Azure Function .Net 6 Isolated with Unit Test using XUnit.

Following this Microsoft Learn docs link: https://learn.microsoft.com/en-us/azure/azure-functions/functions-develop-vs?tabs=isolated-process#create-test-classes

I've been tracking this: https://stackoverflow.com/questions/75662400/azure-function-v4-unit-tests

Which links to this https://github.com/Azure/azure-functions-dotnet-worker/issues/281

Also looked at the following:
- https://stackoverflow.com/questions/71254035/see-multiple-ways-to-obtain-ilogger-in-azure-functions-6-from-docs-and-templates
- https://devpress.csdn.net/cloudnative/62f50c02c6770329307fb224.html (doesn't include Logging)
- https://techcommunity.microsoft.com/t5/fasttrack-for-azure/azure-functions-part-2-unit-and-integration-testing/ba-p/3769764
  - https://github.com/Azure-Samples/azure-functions-code-testing-sample

Visual Studio 2022 > File New > Azure Functions > .Net 6 Isolated

Create a new XUnit Unit Test project

What do I do with ILogger

This solution is an attempt to play around with different approaches