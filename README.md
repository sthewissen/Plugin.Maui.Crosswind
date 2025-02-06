> :warning: **This package is still in preview**: Its functionality relies heavily on pending pull requests in the .NET MAUI repository, specifically [#27180 Shadow support](https://github.com/dotnet/maui/pull/27180) and [#27529 Border support](https://github.com/dotnet/maui/pull/27529). As a result, some features may not work as expected until these changes are merged. However, all other functionalities in the package are fully operational.

![Crosswind Logo](https://raw.githubusercontent.com/sthewissen/Plugin.Maui.Crosswind/refs/heads/main/nuget.png)

# Plugin.Maui.Crosswind

 [![Build](https://github.com/sthewissen/Plugin.Maui.Crosswind/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/sthewissen/Plugin.Maui.Crosswind/actions/workflows/ci.yml)
 
 A utility-first design framework for .NET MAUI that brings the simplicity and flexibility of utility-based styling to XAML. Inspired by the likes of Tailwind CSS, Crosswind offers developers a streamlined way to create modern, consistent UIs. Perfect for rapid development and clean, maintainable design. By using the predefined style classes contained in this library, developers can:

- **Streamline styling:** Quickly apply consistent styles across your app without duplicating code.
- **Increase productivity:** Spend less time writing custom styles and more time building features.
- **Improve maintainability:** Centralized and reusable styles to easily update designs and ensure consistency. 

No more adding silly class names like `list-inner-wrapper` just to be able to style something, and no more agonizing over the perfect abstract name for something that’s really just a container.

Crosswind supports the following broad categories when it comes to styling:

- [Borders](https://github.com/sthewissen/Plugin.Maui.Crosswind/wiki/Borders) ⚠️
- [Colors](https://github.com/sthewissen/Plugin.Maui.Crosswind/wiki/Colors)
- [Flexbox](https://github.com/sthewissen/Plugin.Maui.Crosswind/wiki/Flexbox)
- [Sizing](https://github.com/sthewissen/Plugin.Maui.Crosswind/wiki/Sizing)
- [Spacing](https://github.com/sthewissen/Plugin.Maui.Crosswind/wiki/Spacing)
- [Transforms](https://github.com/sthewissen/Plugin.Maui.Crosswind/wiki/Transforms)
- [Typography](https://github.com/sthewissen/Plugin.Maui.Crosswind/wiki/Typography)
- [Visibility](https://github.com/sthewissen/Plugin.Maui.Crosswind/wiki/Visibility)

## Getting started
Using Crosswind isn't very complicated. It only requires that you call the initializer, e.g. from the constructor of your `App`. After that, all of the classes become available to you for use through the `StyleClass` property.

```csharp
public App()
{
   InitializeComponent();

   CrosswindInitializer.Init();
   // Alternatively, also provide a CrosswindOptions object through CrosswindOptionsBuilder.
}
```

## Custom configuration
Crosswind allows you to customize every aspect of its configuration through the `CrosswindOptions`, from spacing and sizing to colors and fonts. With its fluent API, you can override defaults, add new values, or define entirely custom palettes. Learn more about custom configuration in the [extended documentation](https://github.com/sthewissen/Plugin.Maui.Crosswind/wiki/Configuration).

## Crosswind in action
A picture is worth a thousand words, and seeing Crosswind in action can speak volumes about how it simplifies your UI styling. Below are examples of how you can create beautiful, consistent layouts in .NET MAUI using Crosswind classes. Each example includes a visual and the corresponding XAML code to show you just how easy it is to use.

`// TODO`

## Is it perfect?

No, it is not perfect due to the fundamental differences between how XAML styling functions in .NET MAUI and how CSS operates. XAML styles in .NET MAUI are deeply tied to the framework's property system, which supports direct property binding and default value inheritance, while CSS is primarily designed for styling web elements and lacks the same level of integration with a declarative UI framework like .NET MAUI. Additionally, not all properties available in XAML have direct CSS equivalents, which means that some styling capabilities, such as animation properties, shadows, or borders, may not map cleanly or be supported at all when using CSS.

## Learn more

[Check out the wiki](https://github.com/sthewissen/Plugin.Maui.Crosswind/wiki/) for a full reference of all supported classes.
