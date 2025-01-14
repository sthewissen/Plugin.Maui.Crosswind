# Plugin.Maui.Crosswind
 
 A utility-first design framework for .NET MAUI that brings the simplicity and flexibility of utility-based styling to XAML. Inspired by the efficiency of Tailwind CSS, Crosswind offers developers a streamlined way to create modern, consistent UIs. Perfect for rapid development and clean, maintainable design.

## Supported Classes

### Visibility
The visibility utilities in Crosswind provide simple classes to control the visibility and transparency of elements in your .NET MAUI application. These classes mimic the utility-first styling of Tailwind CSS, offering both visibility toggles and opacity adjustments. These classes all target `VisualElement`.

#### Visibility classes
| Class | Effect |
|---|---|
|`hidden`| Hides the element (`IsVisible = False`). The element is not visible.|
|`block`| Shows the element (`IsVisible = True`). The element is visible and occupies layout space.|

*Example Usage:*
```xml
<!-- Hidden Label -->
<Label Text="This text is hidden" StyleClass="hidden" />

<!-- Visible Button -->
<Button Text="I am visible" StyleClass="block" />
```

## Control Compatibility
In a XAML-based framework like .NET MAUI, each control has a well-defined set of properties, which can limit the direct application of shared styles across multiple control types. Unlike HTML, where elements can often inherit styles flexibly, XAML requires a more structured approach due to its reliance on specific `TargetType` bindings. This section provides a comprehensive compatibility table that outlines which Crosswind `StyleClass` definitions are supported by different controls.

### Typography

|            | `Button` | `Label` | `InputView`* | `Picker`<br/>`DatePicker`<br/>`TimePicker` | `RadioButton` |
|-------------|--------|-------|-------|-------|-------|
| Text alignment<br/>(e.g. `text-center`) | ❌ | ✅ | ✅ | ❌ | ❌ |
| Text size<br/>(e.g.`text-sm`) | ✅ | ✅ | ✅ | ✅ | ✅ |
| Font type<br/>(e.g.`font-sans`) | ✅ | ✅ | ✅ | ✅ | ✅ |
| Text case<br/>(e.g.`uppercase`) | ✅ | ✅ | ✅ | ❌ | ✅ |
| Tracking<br/>(e.g.`tracking-wide`) | ✅ | ✅ | ✅ | ✅ | ✅ |
| Leading<br/>(e.g.`leading-snug`) | ❌ | ✅ | ❌ | ❌ | ❌ |
| Font attributes<br/>(e.g.`italic`) | ✅ | ✅ | ✅ | ✅ | ✅ |
| Text decorations<br/>(e.g.`underline`) | ❌ | ✅ | ❌ | ❌ | ❌ |

*`InputView` covers the `Entry`, `Editor` and `SearchBar` controls.