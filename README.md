# Plugin.Maui.Crosswind
 
 A utility-first design framework for .NET MAUI that brings the simplicity and flexibility of utility-based styling to XAML. Inspired by the efficiency of Tailwind CSS, Crosswind offers developers a streamlined way to create modern, consistent UIs. Perfect for rapid development and clean, maintainable design.

## Supported Classes and Control Compatibility
In a XAML-based framework like .NET MAUI, each control has a well-defined set of properties, which can limit the direct application of shared styles across multiple control types. Unlike HTML, where elements can often inherit styles flexibly, XAML requires a more structured approach due to its reliance on specific `TargetType` bindings. This section provides a comprehensive compatibility table that outlines which Crosswind `StyleClass` definitions are supported by different controls.

### Typography

|            | `Button` | `Label` | `InputView`* | `Picker` | `DatePicker` | `TimePicker` |
|-------------|--------|-------|-------|-------|-------|-------|
| Text alignment<br/><small>(e.g. `text-center`)</small> | ❌ | ✅ | ✅ | ❌ | ❌ | ❌ |
| Text size<br/><small>(e.g.`text-sm`)</small> | ✅ | ✅ | ✅ | ✅ |  ✅ |  ✅ |
| Font type<br/><small>(e.g.`font-sans`)</small> | ✅ | ✅ | ✅ | ✅ |  ✅ |  ✅ |
| Text case<br/><small>(e.g.`uppercase`)</small> | ✅ | ✅ | ✅ | ❌ | ❌ | ❌ |
| Tracking<br/><small>(e.g.`tracking-wide`)</small> | ✅ | ✅ | ✅ | ✅ |  ✅ |  ✅ |
| Leading<br/><small>(e.g.`leading-snug`)</small> | ❌ | ✅ | ❌ | ❌ | ❌ | ❌ |
| Text decorations<br/><small>(e.g.`underline`)</small> | ❌ | ✅ | ❌ | ❌ | ❌ | ❌ |

*`InputView` covers the `Entry`, `Editor` and `SearchBar` controls.