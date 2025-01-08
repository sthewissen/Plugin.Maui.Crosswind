# Plugin.Maui.Crosswind
 
 A utility-first design framework for .NET MAUI that brings the simplicity and flexibility of utility-based styling to XAML. Inspired by the efficiency of Tailwind CSS, Crosswind offers developers a streamlined way to create modern, consistent UIs. Perfect for rapid development and clean, maintainable design.

## Supported Classes and Control Compatibility
In a XAML-based framework like .NET MAUI, each control has a well-defined set of properties, which can limit the direct application of shared styles across multiple control types. Unlike HTML, where elements can often inherit styles flexibly, XAML requires a more structured approach due to its reliance on specific `TargetType` bindings. This section provides a comprehensive compatibility table that outlines which Crosswind `StyleClass` definitions are supported by different controls.

### Typography

|            | `Button` | `Label` | `InputView`* |
|-------------|--------|-------|-------|
| Text alignment (`text-center`) | ❌ | ✅ | ✅ |
| Text size (`text-sm`) | ✅ | ✅ | ✅ |
| Font type (`font-sans`) | ✅ | ✅ | ✅ |
| Text case (`uppercase`) | ✅ | ✅ | ✅ |
| Tracking (`tracking-wide`) | ✅ | ✅ | ✅ |
| Leading (`leading-snug`) | ❌ | ✅ | ❌ |
| Text decorations (`underline`) | ❌ | ✅ | ❌ |

*`InputView` covers the `Entry`, `Editor` and `SearchBar` controls.