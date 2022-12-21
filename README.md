# Using a custom `icudt.dat` file in a Blazor WASM project

If a language you want to support is not considered canonical, and hence does not include full localization data by default in Blazor, you can use the `_ReplaceICU` target defined in the `.csproj` to replace the built-in `icudt.dat` file with your own.

Refer to this comment to find out how to generate your own file: https://github.com/dotnet/runtime/issues/53239#issuecomment-1358010791

The `icudt.dat` file included in this project contains the `lb-LU` culture.
