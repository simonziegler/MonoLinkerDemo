# Mono Linker Error Demonstration

This is a standard Blazor app in .NET 5 Preview 7 that shows a mono linker error when using the `MTAutocomplete` component from [Blazor MDC](https://blazormdc.com). `MTAutocomplete` uses REGEX for pattern matching, and
the linker error occurs when using REGEX.