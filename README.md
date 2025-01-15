![Crosswind Logo](https://raw.githubusercontent.com/sthewissen/Plugin.Maui.Crosswind/refs/heads/main/nuget.png)

# Plugin.Maui.Crosswind
 
 A utility-first design framework for .NET MAUI that brings the simplicity and flexibility of utility-based styling to XAML. Inspired by the likes of Tailwind CSS, Crosswind offers developers a streamlined way to create modern, consistent UIs. Perfect for rapid development and clean, maintainable design. By using the predefined style classes contained in this library, developers can:

- **Streamline styling:** Quickly apply consistent styles across your app without duplicating code.
- **Increase productivity:** Spend less time writing custom styles and more time building features.
- **Improve maintainability:** Centralized and reusable styles to easily update designs and ensure consistency. 

No more adding silly class names like `list-inner-wrapper` just to be able to style something, and no more agonizing over the perfect abstract name for something that’s really just a container.

Crosswind supports the following broad categories when it comes to styling:

- [Colors](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Colors)
- [Flexbox](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Flexbox)
- [Sizing](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Sizing)
- [Spacing](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Spacing)
- [Transforms](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Transforms)
- [Typography](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Typography)
- [Visibility](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Visibility)

## Crosswind in action
A picture is worth a thousand words, and seeing Crosswind in action can speak volumes about how it simplifies your UI styling. Below are examples of how you can create beautiful, consistent layouts in .NET MAUI using Crosswind classes. Each example includes a visual and the corresponding XAML code to show you just how easy it is to use.

`// TODO`

## Is it perfect?

No, it is not perfect due to the fundamental differences between how XAML styling functions in .NET MAUI and how CSS operates. XAML styles in .NET MAUI are deeply tied to the framework's property system, which supports direct property binding and default value inheritance, while CSS is primarily designed for styling web elements and lacks the same level of integration with a declarative UI framework like .NET MAUI. Additionally, not all properties available in XAML have direct CSS equivalents, which means that some styling capabilities, such as animation properties, shadows, or borders, may not map cleanly or be supported at all when using CSS.

## Colors

Crosswind includes the default Tailwind CSS color palette out-of-the-box which is a great starting point if you don't have your own specific branding in mind. These colors can be used in various locations throughout Crosswind, such as background colors, text colors, and border colors. The following overview shows all of the out-of-the-box colors you have access to.

|Color|50|100|200|300|400|500|600|700|800|900|950|
|---|---|---|---|---|---|---|---|---|---|---|---|
|Slate|![#f8fafc](https://placehold.co/40x40/f8fafc/FFF?text=\n+)|![#f1f5f9](https://placehold.co/40x40/f1f5f9/FFF?text=\n+)|![#e2e8f0](https://placehold.co/40x40/e2e8f0/FFF?text=\n+)|![#cbd5e1](https://placehold.co/40x40/cbd5e1/FFF?text=\n+)|![#94a3b8](https://placehold.co/40x40/94a3b8/FFF?text=\n+)|![#64748b](https://placehold.co/40x40/64748b/FFF?text=\n+)|![#475569](https://placehold.co/40x40/475569/FFF?text=\n+)|![#334155](https://placehold.co/40x40/334155/FFF?text=\n+)|![#1e293b](https://placehold.co/40x40/1e293b/FFF?text=\n+)|![#0f172a](https://placehold.co/40x40/0f172a/FFF?text=\n+)|![#020617](https://placehold.co/40x40/020617/FFF?text=\n+)|
|Gray|![#f9fafb](https://placehold.co/40x40/f9fafb/FFF?text=\n+)|![#f3f4f6](https://placehold.co/40x40/f3f4f6/FFF?text=\n+)|![#e5e7eb](https://placehold.co/40x40/e5e7eb/FFF?text=\n+)|![#d1d5db](https://placehold.co/40x40/d1d5db/FFF?text=\n+)|![#9ca3af](https://placehold.co/40x40/9ca3af/FFF?text=\n+)|![#6b7280](https://placehold.co/40x40/6b7280/FFF?text=\n+)|![#4b5563](https://placehold.co/40x40/4b5563/FFF?text=\n+)|![#374151](https://placehold.co/40x40/374151/FFF?text=\n+)|![#1f2937](https://placehold.co/40x40/1f2937/FFF?text=\n+)|![#111827](https://placehold.co/40x40/111827/FFF?text=\n+)|![#030712](https://placehold.co/40x40/030712/FFF?text=\n+)|
|Zinc|![#fafafa](https://placehold.co/40x40/fafafa/FFF?text=\n+)|![#f4f4f5](https://placehold.co/40x40/f4f4f5/FFF?text=\n+)|![#e4e4e7](https://placehold.co/40x40/e4e4e7/FFF?text=\n+)|![#d4d4d8](https://placehold.co/40x40/d4d4d8/FFF?text=\n+)|![#a1a1aa](https://placehold.co/40x40/a1a1aa/FFF?text=\n+)|![#71717a](https://placehold.co/40x40/71717a/FFF?text=\n+)|![#52525b](https://placehold.co/40x40/52525b/FFF?text=\n+)|![#3f3f46](https://placehold.co/40x40/3f3f46/FFF?text=\n+)|![#27272a](https://placehold.co/40x40/27272a/FFF?text=\n+)|![#18181b](https://placehold.co/40x40/18181b/FFF?text=\n+)|![#09090b](https://placehold.co/40x40/09090b/FFF?text=\n+)|
|Neutral|![#fafafa](https://placehold.co/40x40/fafafa/FFF?text=\n+)|![#f5f5f5](https://placehold.co/40x40/f5f5f5/FFF?text=\n+)|![#e5e5e5](https://placehold.co/40x40/e5e5e5/FFF?text=\n+)|![#d4d4d4](https://placehold.co/40x40/d4d4d4/FFF?text=\n+)|![#a3a3a3](https://placehold.co/40x40/a3a3a3/FFF?text=\n+)|![#737373](https://placehold.co/40x40/737373/FFF?text=\n+)|![#525252](https://placehold.co/40x40/525252/FFF?text=\n+)|![#404040](https://placehold.co/40x40/404040/FFF?text=\n+)|![#262626](https://placehold.co/40x40/262626/FFF?text=\n+)|![#171717](https://placehold.co/40x40/171717/FFF?text=\n+)|![#0a0a0a](https://placehold.co/40x40/0a0a0a/FFF?text=\n+)|
|Stone|![#fafaf9](https://placehold.co/40x40/fafaf9/FFF?text=\n+)|![#f5f5f4](https://placehold.co/40x40/f5f5f4/FFF?text=\n+)|![#e7e5e4](https://placehold.co/40x40/e7e5e4/FFF?text=\n+)|![#d6d3d1](https://placehold.co/40x40/d6d3d1/FFF?text=\n+)|![#a8a29e](https://placehold.co/40x40/a8a29e/FFF?text=\n+)|![#78716c](https://placehold.co/40x40/78716c/FFF?text=\n+)|![#57534e](https://placehold.co/40x40/57534e/FFF?text=\n+)|![#44403c](https://placehold.co/40x40/44403c/FFF?text=\n+)|![#292524](https://placehold.co/40x40/292524/FFF?text=\n+)|![#1c1917](https://placehold.co/40x40/1c1917/FFF?text=\n+)|![#0c0a09](https://placehold.co/40x40/0c0a09/FFF?text=\n+)|
|Red|![#fef2f2](https://placehold.co/40x40/fef2f2/FFF?text=\n+)|![#fee2e2](https://placehold.co/40x40/fee2e2/FFF?text=\n+)|![#fecaca](https://placehold.co/40x40/fecaca/FFF?text=\n+)|![#fca5a5](https://placehold.co/40x40/fca5a5/FFF?text=\n+)|![#f87171](https://placehold.co/40x40/f87171/FFF?text=\n+)|![#ef4444](https://placehold.co/40x40/ef4444/FFF?text=\n+)|![#dc2626](https://placehold.co/40x40/dc2626/FFF?text=\n+)|![#b91c1c](https://placehold.co/40x40/b91c1c/FFF?text=\n+)|![#991b1b](https://placehold.co/40x40/991b1b/FFF?text=\n+)|![#7f1d1d](https://placehold.co/40x40/7f1d1d/FFF?text=\n+)|![#450a0a](https://placehold.co/40x40/450a0a/FFF?text=\n+)|
|Orange|![#fff7ed](https://placehold.co/40x40/fff7ed/FFF?text=\n+)|![#ffedd5](https://placehold.co/40x40/ffedd5/FFF?text=\n+)|![#fed7aa](https://placehold.co/40x40/fed7aa/FFF?text=\n+)|![#fdba74](https://placehold.co/40x40/fdba74/FFF?text=\n+)|![#fb923c](https://placehold.co/40x40/fb923c/FFF?text=\n+)|![#f97316](https://placehold.co/40x40/f97316/FFF?text=\n+)|![#ea580c](https://placehold.co/40x40/ea580c/FFF?text=\n+)|![#c2410c](https://placehold.co/40x40/c2410c/FFF?text=\n+)|![#9a3412](https://placehold.co/40x40/9a3412/FFF?text=\n+)|![#7c2d12](https://placehold.co/40x40/7c2d12/FFF?text=\n+)|![#431407](https://placehold.co/40x40/431407/FFF?text=\n+)|
|Amber|![#fffbeb](https://placehold.co/40x40/fffbeb/FFF?text=\n+)|![#fef3c7](https://placehold.co/40x40/fef3c7/FFF?text=\n+)|![#fde68a](https://placehold.co/40x40/fde68a/FFF?text=\n+)|![#fcd34d](https://placehold.co/40x40/fcd34d/FFF?text=\n+)|![#fbbf24](https://placehold.co/40x40/fbbf24/FFF?text=\n+)|![#f59e0b](https://placehold.co/40x40/f59e0b/FFF?text=\n+)|![#d97706](https://placehold.co/40x40/d97706/FFF?text=\n+)|![#b45309](https://placehold.co/40x40/b45309/FFF?text=\n+)|![#92400e](https://placehold.co/40x40/92400e/FFF?text=\n+)|![#78350f](https://placehold.co/40x40/78350f/FFF?text=\n+)|![#451a03](https://placehold.co/40x40/451a03/FFF?text=\n+)|
|Yellow|![#fefce8](https://placehold.co/40x40/fefce8/FFF?text=\n+)|![#fef9c3](https://placehold.co/40x40/fef9c3/FFF?text=\n+)|![#fef08a](https://placehold.co/40x40/fef08a/FFF?text=\n+)|![#fde047](https://placehold.co/40x40/fde047/FFF?text=\n+)|![#facc15](https://placehold.co/40x40/facc15/FFF?text=\n+)|![#eab308](https://placehold.co/40x40/eab308/FFF?text=\n+)|![#ca8a04](https://placehold.co/40x40/ca8a04/FFF?text=\n+)|![#a16207](https://placehold.co/40x40/a16207/FFF?text=\n+)|![#854d0e](https://placehold.co/40x40/854d0e/FFF?text=\n+)|![#713f12](https://placehold.co/40x40/713f12/FFF?text=\n+)|![#422006](https://placehold.co/40x40/422006/FFF?text=\n+)|
|Lime|![#f7fee7](https://placehold.co/40x40/f7fee7/FFF?text=\n+)|![#ecfccb](https://placehold.co/40x40/ecfccb/FFF?text=\n+)|![#d9f99d](https://placehold.co/40x40/d9f99d/FFF?text=\n+)|![#bef264](https://placehold.co/40x40/bef264/FFF?text=\n+)|![#a3e635](https://placehold.co/40x40/a3e635/FFF?text=\n+)|![#84cc16](https://placehold.co/40x40/84cc16/FFF?text=\n+)|![#65a30d](https://placehold.co/40x40/65a30d/FFF?text=\n+)|![#4d7c0f](https://placehold.co/40x40/4d7c0f/FFF?text=\n+)|![#3f6212](https://placehold.co/40x40/3f6212/FFF?text=\n+)|![#365314](https://placehold.co/40x40/365314/FFF?text=\n+)|![#1a2e05](https://placehold.co/40x40/1a2e05/FFF?text=\n+)|
|Green|![#f0fdf4](https://placehold.co/40x40/f0fdf4/FFF?text=\n+)|![#dcfce7](https://placehold.co/40x40/dcfce7/FFF?text=\n+)|![#bbf7d0](https://placehold.co/40x40/bbf7d0/FFF?text=\n+)|![#86efac](https://placehold.co/40x40/86efac/FFF?text=\n+)|![#4ade80](https://placehold.co/40x40/4ade80/FFF?text=\n+)|![#22c55e](https://placehold.co/40x40/22c55e/FFF?text=\n+)|![#16a34a](https://placehold.co/40x40/16a34a/FFF?text=\n+)|![#15803d](https://placehold.co/40x40/15803d/FFF?text=\n+)|![#166534](https://placehold.co/40x40/166534/FFF?text=\n+)|![#14532d](https://placehold.co/40x40/14532d/FFF?text=\n+)|![#052e16](https://placehold.co/40x40/052e16/FFF?text=\n+)|
|Emerald|![#ecfdf5](https://placehold.co/40x40/ecfdf5/FFF?text=\n+)|![#d1fae5](https://placehold.co/40x40/d1fae5/FFF?text=\n+)|![#a7f3d0](https://placehold.co/40x40/a7f3d0/FFF?text=\n+)|![#6ee7b7](https://placehold.co/40x40/6ee7b7/FFF?text=\n+)|![#34d399](https://placehold.co/40x40/34d399/FFF?text=\n+)|![#10b981](https://placehold.co/40x40/10b981/FFF?text=\n+)|![#059669](https://placehold.co/40x40/059669/FFF?text=\n+)|![#047857](https://placehold.co/40x40/047857/FFF?text=\n+)|![#065f46](https://placehold.co/40x40/065f46/FFF?text=\n+)|![#064e3b](https://placehold.co/40x40/064e3b/FFF?text=\n+)|![#022c22](https://placehold.co/40x40/022c22/FFF?text=\n+)|
|Teal|![#f0fdfa](https://placehold.co/40x40/f0fdfa/FFF?text=\n+)|![#ccfbf1](https://placehold.co/40x40/ccfbf1/FFF?text=\n+)|![#99f6e4](https://placehold.co/40x40/99f6e4/FFF?text=\n+)|![#5eead4](https://placehold.co/40x40/5eead4/FFF?text=\n+)|![#2dd4bf](https://placehold.co/40x40/2dd4bf/FFF?text=\n+)|![#14b8a6](https://placehold.co/40x40/14b8a6/FFF?text=\n+)|![#0d9488](https://placehold.co/40x40/0d9488/FFF?text=\n+)|![#0f766e](https://placehold.co/40x40/0f766e/FFF?text=\n+)|![#115e59](https://placehold.co/40x40/115e59/FFF?text=\n+)|![#134e4a](https://placehold.co/40x40/134e4a/FFF?text=\n+)|![#042f2e](https://placehold.co/40x40/042f2e/FFF?text=\n+)|
|Cyan|![#ecfeff](https://placehold.co/40x40/ecfeff/FFF?text=\n+)|![#cffafe](https://placehold.co/40x40/cffafe/FFF?text=\n+)|![#a5f3fc](https://placehold.co/40x40/a5f3fc/FFF?text=\n+)|![#67e8f9](https://placehold.co/40x40/67e8f9/FFF?text=\n+)|![#22d3ee](https://placehold.co/40x40/22d3ee/FFF?text=\n+)|![#06b6d4](https://placehold.co/40x40/06b6d4/FFF?text=\n+)|![#0891b2](https://placehold.co/40x40/0891b2/FFF?text=\n+)|![#0e7490](https://placehold.co/40x40/0e7490/FFF?text=\n+)|![#155e75](https://placehold.co/40x40/155e75/FFF?text=\n+)|![#164e63](https://placehold.co/40x40/164e63/FFF?text=\n+)|![#083344](https://placehold.co/40x40/083344/FFF?text=\n+)|
|Sky|![#f0f9ff](https://placehold.co/40x40/f0f9ff/FFF?text=\n+)|![#e0f2fe](https://placehold.co/40x40/e0f2fe/FFF?text=\n+)|![#bae6fd](https://placehold.co/40x40/bae6fd/FFF?text=\n+)|![#7dd3fc](https://placehold.co/40x40/7dd3fc/FFF?text=\n+)|![#38bdf8](https://placehold.co/40x40/38bdf8/FFF?text=\n+)|![#0ea5e9](https://placehold.co/40x40/0ea5e9/FFF?text=\n+)|![#0284c7](https://placehold.co/40x40/0284c7/FFF?text=\n+)|![#0369a1](https://placehold.co/40x40/0369a1/FFF?text=\n+)|![#075985](https://placehold.co/40x40/075985/FFF?text=\n+)|![#0c4a6e](https://placehold.co/40x40/0c4a6e/FFF?text=\n+)|![#082f49](https://placehold.co/40x40/082f49/FFF?text=\n+)|
|Blue|![#eff6ff](https://placehold.co/40x40/eff6ff/FFF?text=\n+)|![#dbeafe](https://placehold.co/40x40/dbeafe/FFF?text=\n+)|![#bfdbfe](https://placehold.co/40x40/bfdbfe/FFF?text=\n+)|![#93c5fd](https://placehold.co/40x40/93c5fd/FFF?text=\n+)|![#60a5fa](https://placehold.co/40x40/60a5fa/FFF?text=\n+)|![#3b82f6](https://placehold.co/40x40/3b82f6/FFF?text=\n+)|![#2563eb](https://placehold.co/40x40/2563eb/FFF?text=\n+)|![#1d4ed8](https://placehold.co/40x40/1d4ed8/FFF?text=\n+)|![#1e40af](https://placehold.co/40x40/1e40af/FFF?text=\n+)|![#1e3a8a](https://placehold.co/40x40/1e3a8a/FFF?text=\n+)|![#172554](https://placehold.co/40x40/172554/FFF?text=\n+)|
|Indigo|![#eef2ff](https://placehold.co/40x40/eef2ff/FFF?text=\n+)|![#e0e7ff](https://placehold.co/40x40/e0e7ff/FFF?text=\n+)|![#c7d2fe](https://placehold.co/40x40/c7d2fe/FFF?text=\n+)|![#a5b4fc](https://placehold.co/40x40/a5b4fc/FFF?text=\n+)|![#818cf8](https://placehold.co/40x40/818cf8/FFF?text=\n+)|![#6366f1](https://placehold.co/40x40/6366f1/FFF?text=\n+)|![#4f46e5](https://placehold.co/40x40/4f46e5/FFF?text=\n+)|![#4338ca](https://placehold.co/40x40/4338ca/FFF?text=\n+)|![#3730a3](https://placehold.co/40x40/3730a3/FFF?text=\n+)|![#312e81](https://placehold.co/40x40/312e81/FFF?text=\n+)|![#1e1b4b](https://placehold.co/40x40/1e1b4b/FFF?text=\n+)|
|Violet|![#f5f3ff](https://placehold.co/40x40/f5f3ff/FFF?text=\n+)|![#ede9fe](https://placehold.co/40x40/ede9fe/FFF?text=\n+)|![#ddd6fe](https://placehold.co/40x40/ddd6fe/FFF?text=\n+)|![#c4b5fd](https://placehold.co/40x40/c4b5fd/FFF?text=\n+)|![#a78bfa](https://placehold.co/40x40/a78bfa/FFF?text=\n+)|![#8b5cf6](https://placehold.co/40x40/8b5cf6/FFF?text=\n+)|![#7c3aed](https://placehold.co/40x40/7c3aed/FFF?text=\n+)|![#6d28d9](https://placehold.co/40x40/6d28d9/FFF?text=\n+)|![#5b21b6](https://placehold.co/40x40/5b21b6/FFF?text=\n+)|![#4c1d95](https://placehold.co/40x40/4c1d95/FFF?text=\n+)|![#2e1065](https://placehold.co/40x40/2e1065/FFF?text=\n+)|
|Purple|![#faf5ff](https://placehold.co/40x40/faf5ff/FFF?text=\n+)|![#f3e8ff](https://placehold.co/40x40/f3e8ff/FFF?text=\n+)|![#e9d5ff](https://placehold.co/40x40/e9d5ff/FFF?text=\n+)|![#d8b4fe](https://placehold.co/40x40/d8b4fe/FFF?text=\n+)|![#c084fc](https://placehold.co/40x40/c084fc/FFF?text=\n+)|![#a855f7](https://placehold.co/40x40/a855f7/FFF?text=\n+)|![#9333ea](https://placehold.co/40x40/9333ea/FFF?text=\n+)|![#7e22ce](https://placehold.co/40x40/7e22ce/FFF?text=\n+)|![#6b21a8](https://placehold.co/40x40/6b21a8/FFF?text=\n+)|![#581c87](https://placehold.co/40x40/581c87/FFF?text=\n+)|![#3b0764](https://placehold.co/40x40/3b0764/FFF?text=\n+)|
|Fuchsia|![#fdf4ff](https://placehold.co/40x40/fdf4ff/FFF?text=\n+)|![#fae8ff](https://placehold.co/40x40/fae8ff/FFF?text=\n+)|![#f5d0fe](https://placehold.co/40x40/f5d0fe/FFF?text=\n+)|![#f0abfc](https://placehold.co/40x40/f0abfc/FFF?text=\n+)|![#e879f9](https://placehold.co/40x40/e879f9/FFF?text=\n+)|![#d946ef](https://placehold.co/40x40/d946ef/FFF?text=\n+)|![#c026d3](https://placehold.co/40x40/c026d3/FFF?text=\n+)|![#a21caf](https://placehold.co/40x40/a21caf/FFF?text=\n+)|![#86198f](https://placehold.co/40x40/86198f/FFF?text=\n+)|![#701a75](https://placehold.co/40x40/701a75/FFF?text=\n+)|![#4a044e](https://placehold.co/40x40/4a044e/FFF?text=\n+)|
|Pink|![#fdf2f8](https://placehold.co/40x40/fdf2f8/FFF?text=\n+)|![#fce7f3](https://placehold.co/40x40/fce7f3/FFF?text=\n+)|![#fbcfe8](https://placehold.co/40x40/fbcfe8/FFF?text=\n+)|![#f9a8d4](https://placehold.co/40x40/f9a8d4/FFF?text=\n+)|![#f472b6](https://placehold.co/40x40/f472b6/FFF?text=\n+)|![#ec4899](https://placehold.co/40x40/ec4899/FFF?text=\n+)|![#db2777](https://placehold.co/40x40/db2777/FFF?text=\n+)|![#be185d](https://placehold.co/40x40/be185d/FFF?text=\n+)|![#9d174d](https://placehold.co/40x40/9d174d/FFF?text=\n+)|![#831843](https://placehold.co/40x40/831843/FFF?text=\n+)|![#500724](https://placehold.co/40x40/500724/FFF?text=\n+)|
|Rose|![#fff1f2](https://placehold.co/40x40/fff1f2/FFF?text=\n+)|![#ffe4e6](https://placehold.co/40x40/ffe4e6/FFF?text=\n+)|![#fecdd3](https://placehold.co/40x40/fecdd3/FFF?text=\n+)|![#fda4af](https://placehold.co/40x40/fda4af/FFF?text=\n+)|![#fb7185](https://placehold.co/40x40/fb7185/FFF?text=\n+)|![#f43f5e](https://placehold.co/40x40/f43f5e/FFF?text=\n+)|![#e11d48](https://placehold.co/40x40/e11d48/FFF?text=\n+)|![#be123c](https://placehold.co/40x40/be123c/FFF?text=\n+)|![#9f1239](https://placehold.co/40x40/9f1239/FFF?text=\n+)|![#881337](https://placehold.co/40x40/881337/FFF?text=\n+)|![#4c0519](https://placehold.co/40x40/4c0519/FFF?text=\n+)|

### Background color classes
In Crosswind, you can easily set background colors using utility classes that map to a predefined set of colors. Each background color class applies a specific color to the background of the element. Please refer to the overview above for the supported colors. You can apply the background color classes in the `StyleClass` property of any `VisualElement`:

```xml
<VerticalStackLayout StyleClass="bg-slate-500">
    <Label StyleClass="bg-rose-300" Text="This is a background colored element" />
</VerticalStackLayout>
```

### Text color classes
You can easily set text colors using utility classes that map to a predefined set of colors. Each text color class applies a specific color to the foreground of the text element. Please refer to the overview above for the supported colors. You can apply the text color classes in the `StyleClass` property of any element that supports the `TextColor` property (see the compatibility matrix for typography-related classes below).

```xml
<Label StyleClass="text-fuchsia-800" Text="This is an element with nice text colors." />
```

----

## Flexbox
Flexbox utilities in .NET MAUI provide a powerful way to create flexible and responsive layouts. These utilities map closely to the behavior of CSS Flexbox, allowing developers to align, justify, and distribute elements within a container. With support for properties like flex-direction, justify-content, align-items, and more, you can achieve complex layout designs with minimal effort.

### Flex basis classes

These classes control the initial size of flex items along the flex direction. The `flex-basis` property sets the size of an item before it is adjusted by `flex-grow` or `flex-shrink`.

| Class       | Effect                                                      |
|-------------|-------------------------------------------------------------|
| basis-auto  | Sets the flex-basis to `auto`, letting the content size the item. |
| basis-1    | Sets the flex-basis to `4`.                                  |
| basis-2    | Sets the flex-basis to `8`.                                  |
| basis-3    | Sets the flex-basis to `12`.                                 |
| basis-4    | Sets the flex-basis to `16`.                                 |
| basis-5    | Sets the flex-basis to `20`.                                 |
| basis-6    | Sets the flex-basis to `24`.                                 |
| basis-7    | Sets the flex-basis to `28`.                                 |
| basis-8    | Sets the flex-basis to `32`.                                 |
| basis-0    | Sets the flex-basis to `0%`.                                 |
| basis-1-4  | Sets the flex-basis to `25%`.                                |
| basis-2-4  | Sets the flex-basis to `50%`.                                |
| basis-3-4  | Sets the flex-basis to `75%`.                                |
| basis-full | Sets the flex-basis to `100%`.                               |

### Flex direction classes

These classes control the direction in which flex items are laid out within a flex container. The `flex-direction` property allows for both horizontal and vertical orientations.

| Class              | Effect                                                   |
|--------------------|----------------------------------------------------------|
| flex-row          | Sets the flex direction to `row` (default horizontal).    |
| flex-row-reverse  | Sets the flex direction to `row-reverse` (reverse horizontal). |
| flex-col          | Sets the flex direction to `column` (vertical).          |
| flex-col-reverse  | Sets the flex direction to `column-reverse` (reverse vertical). |

### Flex wrap classes

These classes determine whether flex items are forced into a single line or allowed to wrap onto multiple lines.

| Class              | Effect                                                   |
|--------------------|----------------------------------------------------------|
| flex-wrap         | Sets `flex-wrap` to `wrap`, allowing items to wrap onto new lines. |
| flex-wrap-reverse | Sets `flex-wrap` to `wrap-reverse`, wrapping items in reverse order. |
| flex-nowrap       | Sets `flex-wrap` to `nowrap`, forcing all items onto a single line. |

### Flex grow classes

These classes control how much a flex item should grow relative to the rest of the items in the container. The `flex-grow` property determines the proportion of available space an item should take up.

| Class              | Effect                                                   |
|--------------------|----------------------------------------------------------|
| grow              | Sets `flex-grow` to `1`, allowing the item to grow and fill space. |
| grow-0            | Sets `flex-grow` to `0`, preventing the item from growing. |

### Flex shrink classes

These classes control how much a flex item should shrink relative to the rest of the items in the container. The `flex-shrink` property determines how items shrink when there is not enough space.

| Class              | Effect                                                   |
|--------------------|----------------------------------------------------------|
| shrink            | Sets `flex-shrink` to `1`, allowing the item to shrink if necessary. |
| shrink-0          | Sets `flex-shrink` to `0`, preventing the item from shrinking. |

### Justify content classes

These classes align flex items along the main axis of the flex container, controlling how items are spaced out or aligned.

| Class              | Effect                                                   |
|--------------------|----------------------------------------------------------|
| justify-start     | Sets `justify-content` to `flex-start`, aligning items at the start of the container. |
| justify-end       | Sets `justify-content` to `flex-end`, aligning items at the end of the container. |
| justify-center    | Sets `justify-content` to `center`, centering items in the container. |
| justify-between   | Sets `justify-content` to `space-between`, distributing items with equal space between them. |
| justify-around    | Sets `justify-content` to `space-around`, distributing items with equal space around them. |
| justify-evenly    | Sets `justify-content` to `space-evenly`, distributing items with equal space around and between them. |

### Align content classes

These classes align flex lines along the cross axis when there is extra space in the container.

| Class              | Effect                                                   |
|--------------------|----------------------------------------------------------|
| content-start     | Sets `align-content` to `flex-start`, aligning lines at the start of the container. |
| content-end       | Sets `align-content` to `flex-end`, aligning lines at the end of the container. |
| content-center    | Sets `align-content` to `center`, centering lines in the container. |
| content-between   | Sets `align-content` to `space-between`, distributing lines with equal space between them. |
| content-around    | Sets `align-content` to `space-around`, distributing lines with equal space around them. |
| content-evenly    | Sets `align-content` to `space-evenly`, distributing lines with equal space around and between them. |

### Align items classes

These classes align flex items along the cross axis within the container.

| Class              | Effect                                                   |
|--------------------|----------------------------------------------------------|
| items-stretch     | Sets `align-items` to `stretch`, making items stretch to fill the container. |
| items-start       | Sets `align-items` to `flex-start`, aligning items at the start of the cross axis. |
| items-center      | Sets `align-items` to `center`, centering items along the cross axis. |
| items-end         | Sets `align-items` to `flex-end`, aligning items at the end of the cross axis. |

### Align self classes

These classes control how an individual flex item aligns along the cross axis, overriding the `align-items` property for that specific item.

| Class              | Effect                                                   |
|--------------------|----------------------------------------------------------|
| self-auto         | Sets `align-self` to `auto`, using the item's default alignment. |
| self-start        | Sets `align-self` to `flex-start`, aligning the item at the start of the cross axis. |
| self-end          | Sets `align-self` to `flex-end`, aligning the item at the end of the cross axis. |
| self-center       | Sets `align-self` to `center`, centering the item along the cross axis. |
| self-stretch      | Sets `align-self` to `stretch`, making the item stretch to fill the cross axis. |

----

## Sizing  
Use these classes to control the height and width of elements in .NET MAUI.

### Size classes
Define both height and width with the same value for consistent sizing.  
| **Class**   | **Effect**                              |
|-------------|-----------------------------------------|
| `size-0`    | Sets the height and width to `0`.       |
| `size-1`    | Sets the height and width to `4`.       |
| `size-2`    | Sets the height and width to `8`.       |
| `size-3`    | Sets the height and width to `12`.      |
| `size-4`    | Sets the height and width to `16`.      |
| `size-5`    | Sets the height and width to `20`.      |
| `size-6`    | Sets the height and width to `24`.      |
| `size-7`    | Sets the height and width to `28`.      |
| `size-8`    | Sets the height and width to `32`.      |

### Width classes
Adjust the width of an element.  
| **Class**   | **Effect**                     |
|-------------|--------------------------------|
| `w-0`       | Sets the width to `0`.         |
| `w-1`       | Sets the width to `4`.         |
| `w-2`       | Sets the width to `8`.         |
| `w-3`       | Sets the width to `12`.        |
| `w-4`       | Sets the width to `16`.        |
| `w-5`       | Sets the width to `20`.        |
| `w-6`       | Sets the width to `24`.        |
| `w-7`       | Sets the width to `28`.        |
| `w-8`       | Sets the width to `32`.        |

### Max Width classes
Set the maximum width of an element.  
| **Class**     | **Effect**                            |
|---------------|---------------------------------------|
| `max-w-0`     | Sets the maximum width to `0`.        |
| `max-w-1`     | Sets the maximum width to `4`.        |
| `max-w-2`     | Sets the maximum width to `8`.        |
| `max-w-3`     | Sets the maximum width to `12`.       |
| `max-w-4`     | Sets the maximum width to `16`.       |
| `max-w-5`     | Sets the maximum width to `20`.       |
| `max-w-6`     | Sets the maximum width to `24`.       |
| `max-w-7`     | Sets the maximum width to `28`.       |
| `max-w-8`     | Sets the maximum width to `32`.       |

### Min Width classes
Set the minimum width of an element.  
| **Class**     | **Effect**                            |
|---------------|---------------------------------------|
| `min-w-0`     | Sets the minimum width to `0`.        |
| `min-w-1`     | Sets the minimum width to `4`.        |
| `min-w-2`     | Sets the minimum width to `8`.        |
| `min-w-3`     | Sets the minimum width to `12`.       |
| `min-w-4`     | Sets the minimum width to `16`.       |
| `min-w-5`     | Sets the minimum width to `20`.       |
| `min-w-6`     | Sets the minimum width to `24`.       |
| `min-w-7`     | Sets the minimum width to `28`.       |
| `min-w-8`     | Sets the minimum width to `32`.       |

### Height classes
Adjust the height of an element.  
| **Class**   | **Effect**                     |
|-------------|--------------------------------|
| `h-0`       | Sets the height to `0`.        |
| `h-1`       | Sets the height to `4`.        |
| `h-2`       | Sets the height to `8`.        |
| `h-3`       | Sets the height to `12`.       |
| `h-4`       | Sets the height to `16`.       |
| `h-5`       | Sets the height to `20`.       |
| `h-6`       | Sets the height to `24`.       |
| `h-7`       | Sets the height to `28`.       |
| `h-8`       | Sets the height to `32`.       |

### Max Height classes
Set the maximum height of an element.  
| **Class**     | **Effect**                            |
|---------------|---------------------------------------|
| `max-h-0`     | Sets the maximum height to `0`.       |
| `max-h-1`     | Sets the maximum height to `4`.       |
| `max-h-2`     | Sets the maximum height to `8`.       |
| `max-h-3`     | Sets the maximum height to `12`.      |
| `max-h-4`     | Sets the maximum height to `16`.      |
| `max-h-5`     | Sets the maximum height to `20`.      |
| `max-h-6`     | Sets the maximum height to `24`.      |
| `max-h-7`     | Sets the maximum height to `28`.      |
| `max-h-8`     | Sets the maximum height to `32`.      |

### Min Height classes
Set the minimum height of an element.  
| **Class**     | **Effect**                            |
|---------------|---------------------------------------|
| `min-h-0`     | Sets the minimum height to `0`.       |
| `min-h-1`     | Sets the minimum height to `4`.       |
| `min-h-2`     | Sets the minimum height to `8`.       |
| `min-h-3`     | Sets the minimum height to `12`.      |
| `min-h-4`     | Sets the minimum height to `16`.      |
| `min-h-5`     | Sets the minimum height to `20`.      |
| `min-h-6`     | Sets the minimum height to `24`.      |
| `min-h-7`     | Sets the minimum height to `28`.      |
| `min-h-8`     | Sets the minimum height to `32`.      |`

----

## Spacing
The spacing utilities in Crosswind offer a consistent way to apply spacing in or around elements in your .NET MAUI application adhering to a 4-point grid system, ideal for your mobile apps.

### Margin classes
Margin classes provide spacing around an element on all sides. The values are defined using a scale ranging from 0 to 8, with each step representing an increment of `4dp`.

| Class | Effect |
|---|---|
|`m-0`| A value of `0` on all sides |
|`m-1`| A value of `4` on all sides |
|`m-2`| A value of `8` on all sides |
|`m-3`| A value of `12` on all sides |
|`m-4`| A value of `16` on all sides |
|`m-5`| A value of `20` on all sides |
|`m-6`| A value of `24` on all sides |
|`m-7`| A value of `28` on all sides |
|`m-8`| A value of `32` on all sides |

*Example usage:*
```xml
<!-- No margin -->
<Label Text="No margin" StyleClass="m-0" />

<!-- Small margin -->
<Button Text="Small margin" StyleClass="m-2" />

<!-- Large margin -->
<Entry Placeholder="Large margin" StyleClass="m-8" />
```

### Directional margin classes
Directional margin classes provide spacing around an element on specific sides. The values are defined using a scale ranging from 0 to 8, with each step representing an increment of `4dp`. You can combine these with one another.

| Class | Effect |
|---|---|
|`mx-0`| A value of `0` on the left and right |
|`mx-1`| A value of `4` on the left and right |
|`mx-2`| A value of `8` on the left and right |
|`mx-3`| A value of `12` on the left and right |
|`mx-4`| A value of `16` on the left and right |
|`mx-5`| A value of `20` on the left and right |
|`mx-6`| A value of `24` on the left and right |
|`mx-7`| A value of `28` on the left and right |
|`mx-8`| A value of `32` on the left and right |
|`my-0`| A value of `0` on the top and bottom |
|`my-1`| A value of `4` on the top and bottom |
|`my-2`| A value of `8` on the top and bottom |
|`my-3`| A value of `12` on the top and bottom |
|`my-4`| A value of `16` on the top and bottom |
|`my-5`| A value of `20` on the top and bottom |
|`my-6`| A value of `24` on the top and bottom |
|`my-7`| A value of `28` on the top and bottom |
|`my-8`| A value of `32` on the top and bottom |
|`ml-0`| A value of `0` on the left side |
|`ml-1`| A value of `4` on the left side |
|`ml-2`| A value of `8` on the left side |
|`ml-3`| A value of `12` on the left side |
|`ml-4`| A value of `16` on the left side |
|`ml-5`| A value of `20` on the left side |
|`ml-6`| A value of `24` on the left side |
|`ml-7`| A value of `28` on the left side |
|`ml-8`| A value of `32` on the left side |
|`mr-0`| A value of `0` on the right side |
|`mr-1`| A value of `4` on the right side |
|`mr-2`| A value of `8` on the right side |
|`mr-3`| A value of `12` on the right side |
|`mr-4`| A value of `16` on the right side |
|`mr-5`| A value of `20` on the right side |
|`mr-6`| A value of `24` on the right side |
|`mr-7`| A value of `28` on the right side |
|`mr-8`| A value of `32` on the right side |
|`mt-0`| A value of `0` on the top side |
|`mt-1`| A value of `4` on the top side |
|`mt-2`| A value of `8` on the top side |
|`mt-3`| A value of `12` on the top side |
|`mt-4`| A value of `16` on the top side |
|`mt-5`| A value of `20` on the top side |
|`mt-6`| A value of `24` on the top side |
|`mt-7`| A value of `28` on the top side |
|`mt-8`| A value of `32` on the top side |
|`mb-0`| A value of `0` on the bottom side |
|`mb-1`| A value of `4` on the bottom side |
|`mb-2`| A value of `8` on the bottom side |
|`mb-3`| A value of `12` on the bottom side |
|`mb-4`| A value of `16` on the bottom side |
|`mb-5`| A value of `20` on the bottom side |
|`mb-6`| A value of `24` on the bottom side |
|`mb-7`| A value of `28` on the bottom side |
|`mb-8`| A value of `32` on the bottom side |

*Example usage:*
```xml
<!-- Horizontal margin -->
<Label Text="Horizontal margin" StyleClass="mx-4" />

<!-- Vertical margin -->
<Button Text="Top margin" StyleClass="mt-2" />
```

### Padding classes
Padding classes provide spacing around an element on all sides. The values are defined using a scale ranging from 0 to 8, with each step representing an increment of `4dp`.

| Class | Effect |
|---|---|
|`p-0`| A value of `0` on all sides |
|`p-1`| A value of `4` on all sides |
|`p-2`| A value of `8` on all sides |
|`p-3`| A value of `12` on all sides |
|`p-4`| A value of `16` on all sides |
|`p-5`| A value of `20` on all sides |
|`p-6`| A value of `24` on all sides |
|`p-7`| A value of `28` on all sides |
|`p-8`| A value of `32` on all sides |

*Example usage:*
```xml
<!-- No padding -->
<Label Text="No padding" StyleClass="p-0" />

<!-- Small padding -->
<Button Text="Small padding" StyleClass="p-2" />

<!-- Large padding -->
<Entry Placeholder="Large padding" StyleClass="p-8" />
```

### Directional padding classes
Directional padding classes provide spacing within an element on specific sides. The values are defined using a scale ranging from 0 to 8, with each step representing an increment of `4dp`. You can combine these with one another.

| Class | Effect |
|---|---|
|`px-0`| A value of `0` on the left and right |
|`px-1`| A value of `4` on the left and right |
|`px-2`| A value of `8` on the left and right |
|`px-3`| A value of `12` on the left and right |
|`px-4`| A value of `16` on the left and right |
|`px-5`| A value of `20` on the left and right |
|`px-6`| A value of `24` on the left and right |
|`px-7`| A value of `28` on the left and right |
|`px-8`| A value of `32` on the left and right |
|`py-0`| A value of `0` on the top and bottom |
|`py-1`| A value of `4` on the top and bottom |
|`py-2`| A value of `8` on the top and bottom |
|`py-3`| A value of `12` on the top and bottom |
|`py-4`| A value of `16` on the top and bottom |
|`py-5`| A value of `20` on the top and bottom |
|`py-6`| A value of `24` on the top and bottom |
|`py-7`| A value of `28` on the top and bottom |
|`py-8`| A value of `32` on the top and bottom |
|`pl-0`| A value of `0` on the left side |
|`pl-1`| A value of `4` on the left side |
|`pl-2`| A value of `8` on the left side |
|`pl-3`| A value of `12` on the left side |
|`pl-4`| A value of `16` on the left side |
|`pl-5`| A value of `20` on the left side |
|`pl-6`| A value of `24` on the left side |
|`pl-7`| A value of `28` on the left side |
|`pl-8`| A value of `32` on the left side |
|`pr-0`| A value of `0` on the right side |
|`pr-1`| A value of `4` on the right side |
|`pr-2`| A value of `8` on the right side |
|`pr-3`| A value of `12` on the right side |
|`pr-4`| A value of `16` on the right side |
|`pr-5`| A value of `20` on the right side |
|`pr-6`| A value of `24` on the right side |
|`pr-7`| A value of `28` on the right side |
|`pr-8`| A value of `32` on the right side |
|`pt-0`| A value of `0` on the top side |
|`pt-1`| A value of `4` on the top side |
|`pt-2`| A value of `8` on the top side |
|`pt-3`| A value of `12` on the top side |
|`pt-4`| A value of `16` on the top side |
|`pt-5`| A value of `20` on the top side |
|`pt-6`| A value of `24` on the top side |
|`pt-7`| A value of `28` on the top side |
|`pt-8`| A value of `32` on the top side |
|`pb-0`| A value of `0` on the bottom side |
|`pb-1`| A value of `4` on the bottom side |
|`pb-2`| A value of `8` on the bottom side |
|`pb-3`| A value of `12` on the bottom side |
|`pb-4`| A value of `16` on the bottom side |
|`pb-5`| A value of `20` on the bottom side |
|`pb-6`| A value of `24` on the bottom side |
|`pb-7`| A value of `28` on the bottom side |
|`pb-8`| A value of `32` on the bottom side |

*Example usage:*
```xml
<!-- Horizontal padding -->
<Label Text="Horizontal padding" StyleClass="px-4" />

<!-- Vertical padding -->
<Button Text="Horizontal and vertical padding" StyleClass="py-2 px-4" />
```

### Gap classes
Gap classes provide spacing between the parts of an element on specific sides. The values are defined using a scale ranging from 0 to 8, with each step representing an increment of `4dp`. 
You can combine these with one another. These can be used to set `ColumnSpacing` and `RowSpacing` on a `Grid` or to set `Spacing` on the `HorizontalStackLayout` and `VerticalStackLayout`.

| Class | Effect                                   |
|---|------------------------------------------|
|`gap-0`| A value of `0` horizontally and vertically |
|`gap-1`| A value of `4` horizontally and vertically |
|`gap-2`| A value of `8` horizontally and vertically |
|`gap-3`| A value of `12` horizontally and vertically |
|`gap-4`| A value of `16` horizontally and vertically |
|`gap-5`| A value of `20` horizontally and vertically |
|`gap-6`| A value of `24` horizontally and vertically            |
|`gap-7`| A value of `28` horizontally and vertically            |
|`gap-8`| A value of `32` horizontally and vertically            |
|`gap-x-0`| A value of `0` horizontally              |
|`gap-x-1`| A value of `4` horizontally              |
|`gap-x-2`| A value of `8` horizontally              |
|`gap-x-3`| A value of `12` horizontally             |
|`gap-x-4`| A value of `16` horizontally             |
|`gap-x-5`| A value of `20` horizontally             |
|`gap-x-6`| A value of `24` horizontally             |
|`gap-x-7`| A value of `28` horizontally             |
|`gap-x-8`| A value of `32` horizontally             |
|`gap-y-0`| A value of `0` vertically                |
|`gap-y-1`| A value of `4` vertically                |
|`gap-y-2`| A value of `8` vertically                |
|`gap-y-3`| A value of `12` vertically               |
|`gap-y-4`| A value of `16` vertically               |
|`gap-y-5`| A value of `20` vertically               |
|`gap-y-6`| A value of `24` vertically               |
|`gap-y-7`| A value of `28` vertically               |
|`gap-y-8`| A value of `32` vertically               |

*Example usage:*
```xml
<VerticalStackLayout StyleClass="gap-1">
   <Label StyleClass="text-red-500" Text="You have a new message!" />
</VerticalStackLayout>
```

---

## Transforms
The transform classes provide several useful transformation styles for scaling, rotating, and translating objects in a .NET MAUI application. These transformations can be applied to UI elements to modify their appearance and positioning.

### Rotation classes
Rotation transformations allow you to rotate an element by a specified angle. These styles apply rotational transformations to your objects.

| Class | Effect |
|---|---|
|`rotate-0`| Rotate the element `0` degrees |
|`rotate-45`| Rotate the element `45` degrees |
|`rotate-90`| Rotate the element `90` degrees |
|`rotate-135`| Rotate the element `135` degrees |
|`rotate-180`| Rotate the element `180` degrees |
|`rotate-225`| Rotate the element `225` degrees |
|`rotate-270`| Rotate the element `270` degrees |
|`rotate-315`| Rotate the element `315` degrees |
|`rotate-360`| Rotate the element `360` degrees |

### Scale classes
Scale transformations change the size of an element along one or more axes. The following styles allow you to apply different scaling factors to your objects.

| Class | Effect |
|---|---|
|`scale-0`| Scale the element on both axes `0%` (make it invisible) |
|`scale-50`| Scale the element on both axes `50%` |
|`scale-75`| Scale the element on both axes `75%` |
|`scale-90`| Scale the element on both axes `90%` |
|`scale-95`| Scale the element on both axes `95%` |
|`scale-100`| Scale the element on both axes `100%` |
|`scale-105`| Scale the element on both axes `105%` |
|`scale-110`| Scale the element on both axes `110%` |
|`scale-125`| Scale the element on both axes `125%` |
|`scale-150`| Scale the element on both axes `150%` |
|`scale-175`| Scale the element on both axes `175%` |
|`scale-200`| Scale the element on both axes `200%` |
|`scale-x-0`| Scale the element on the X-axis `0%` (make it invisible) |
|`scale-x-50`| Scale the element on the X-axis `50%` |
|`scale-x-75`| Scale the element on the X-axis `75%` |
|`scale-x-90`| Scale the element on the X-axis `90%` |
|`scale-x-95`| Scale the element on the X-axis `95%` |
|`scale-x-100`| Scale the element on the X-axis `100%` |
|`scale-x-105`| Scale the element on the X-axis `105%` |
|`scale-x-110`| Scale the element on the X-axis `110%` |
|`scale-x-125`| Scale the element on the X-axis `125%` |
|`scale-x-150`| Scale the element on the X-axis `150%` |
|`scale-x-175`| Scale the element on the X-axis `175%` |
|`scale-x-200`| Scale the element on the X-axis `200%` |
|`scale-y-0`| Scale the element on the Y-axis `0%` (make it invisible) |
|`scale-y-50`| Scale the element on the Y-axis `50%` |
|`scale-y-75`| Scale the element on the Y-axis `75%` |
|`scale-y-90`| Scale the element on the Y-axis `90%` |
|`scale-y-95`| Scale the element on the Y-axis `95%` |
|`scale-y-100`| Scale the element on the Y-axis `100%` |
|`scale-y-105`| Scale the element on the Y-axis `105%` |
|`scale-y-110`| Scale the element on the Y-axis `110%` |
|`scale-y-125`| Scale the element on the Y-axis `125%` |
|`scale-y-150`| Scale the element on the Y-axis `150%` |
|`scale-y-175`| Scale the element on the Y-axis `175%` |
|`scale-y-200`| Scale the element on the Y-axis `200%` |

### Translate classes
Translation transformations move an element along the X and Y axes, shifting its position by a specified number of dp units. The following styles define translations in both directions for your objects.

| Class | Effect |
|---|---|
|`translate-x-0`| Translate the element on the X-axis `0` dp |
|`translate-x-1`| Translate the element on the X-axis `4` dp |
|`translate-x-2`| Translate the element on the X-axis `8` dp |
|`translate-x-3`| Translate the element on the X-axis `12` dp |
|`translate-x-4`| Translate the element on the X-axis `16` dp |
|`translate-x-5`| Translate the element on the X-axis `20` dp |
|`translate-x-6`| Translate the element on the X-axis `24` dp |
|`translate-x-7`| Translate the element on the X-axis `28` dp |
|`translate-x-8`| Translate the element on the X-axis `32` dp |
|`translate-y-0`| Translate the element on the Y-axis `0` dp |
|`translate-y-1`| Translate the element on the Y-axis `4` dp |
|`translate-y-2`| Translate the element on the Y-axis `8` dp |
|`translate-y-3`| Translate the element on the Y-axis `12` dp |
|`translate-y-4`| Translate the element on the Y-axis `16` dp |
|`translate-y-5`| Translate the element on the Y-axis `20` dp |
|`translate-y-6`| Translate the element on the Y-axis `24` dp |
|`translate-y-7`| Translate the element on the Y-axis `28` dp |
|`translate-y-8`| Translate the element on the Y-axis `32` dp |

*Example usage:*
```xml
<Button Class="scale-150" Text="Enlarged Button"/>
<Button Class="rotate-45" Text="Rotated Button"/>
<Button Class="translate-x-4 translate-y-4" Text="Translated Button"/>
```
---

## Typography

### Font attribute classe
Add styles like italics to text.

| Class           | Effect                          |
|-----------------|---------------------------------|
| `italic`        | Applies italic font style.      |

### Font type classes
Selects from standard font styles to define the look of your text.

| Class       | Effect                     |
|-------------|----------------------------|
| `font-sans` | Uses a sans-serif font.    |
| `font-serif`| Uses a serif font.         |
| `font-mono` | Uses a monospace font.     |

### Leading classes
Defines the vertical spacing between lines of text.

| Class             | Effect                        |
|-------------------|-------------------------------|
| `leading-none`   | Sets line height to `1.0`.      |
| `leading-tight`  | Sets line height to `1.25`.     |
| `leading-snug`   | Sets line height to `1.375`.    |
| `leading-normal` | Sets line height to `1.5`.      |
| `leading-relaxed`| Sets line height to `1.625`.    |
| `leading-loose`  | Sets line height to `2.0`.      |

### Text alignment classes
Controls the horizontal alignment of text within its container.

| Class          | Effect                               |
|----------------|--------------------------------------|
| `text-left`    | Aligns text to the left.             |
| `text-center`  | Centers text horizontally.           |
| `text-right`   | Aligns text to the right.            |
| `text-justify` | Justifies text, aligning both edges. |

### Text case classes
Changes the case of text to uppercase or lowercase.

| Class        | Effect                      |
|--------------|-----------------------------|
| `uppercase`  | Transforms text to uppercase. |
| `lowercase`  | Transforms text to lowercase. |

### Text decoration classes
Add styles like underlines or strikethroughs to text.

| Class            | Effect                          |
|------------------|---------------------------------|
| `underline`     | Adds an underline decoration.   |
| `line-through`  | Adds a line-through decoration. |

### Text size classes
Adjusts the size of the text to suit your design needs.

| Class       | Effect                   |
|-------------|--------------------------|
| `text-xs`  | Sets font size to `12`.  |
| `text-sm`  | Sets font size to `14`.  |
| `text-md`  | Sets font size to `16`.  |
| `text-lg`  | Sets font size to `18`.  |
| `text-xl`  | Sets font size to `20`.  |
| `text-2xl` | Sets font size to `24`.  |
| `text-3xl` | Sets font size to `30`.  |
| `text-4xl` | Sets font size to `36`.  |
| `text-5xl` | Sets font size to `48`.  |
| `text-6xl` | Sets font size to `64`.  |

### Tracking classes
Fine-tunes the spacing between characters in your text.

| Class               | Effect                         |
|---------------------|--------------------------------|
| `tracking-tighter` | Sets letter spacing to `-0.5`.   |
| `tracking-tight`   | Sets letter spacing to `-0.25`.  |
| `tracking-normal`  | Sets letter spacing to `0`.      |
| `tracking-wide`    | Sets letter spacing to `0.25`.   |
| `tracking-wider`   | Sets letter spacing to `0.5`.    |
| `tracking-widest`  | Sets letter spacing to `1.0`.    |

### Control Compatibility
In a XAML-based framework like .NET MAUI, each control has a well-defined set of properties, which can limit the direct application of shared styles across multiple control types. Unlike HTML, where elements can often inherit styles flexibly, XAML requires a more structured approach due to its reliance on specific `TargetType` bindings. Due to the usage of StyleClass, applying a class to a control will never lead to a runtime exception, but it will just fail silently. This section provides a comprehensive compatibility table outlining which typography classes used in Crosswind are supported by the various controls that exist in .NET MAUI.

|            | `Button` | `Label` | `InputView`* | `Picker`<br/>`DatePicker`<br/>`TimePicker` | `RadioButton` |
|-------------|--------|-------|-------|-------|-------|
| Font attributes | ✅ | ✅ | ✅ | ✅ | ✅ |
| Font type | ✅ | ✅ | ✅ | ✅ | ✅ |
| Leading | ❌ | ✅ | ❌ | ❌ | ❌ |
| Text alignment | ❌ | ✅ | ✅ | ❌ | ❌ |
| Text case | ✅ | ✅ | ✅ | ❌ | ✅ |
| Text decorations | ❌ | ✅ | ❌ | ❌ | ❌ |
| Text size | ✅ | ✅ | ✅ | ✅ | ✅ |
| Tracking | ✅ | ✅ | ✅ | ✅ | ✅ |

*`InputView` covers the `Entry`, `Editor`, and `SearchBar` controls.

---

## Visibility
The visibility utilities in Crosswind provide simple classes to control the visibility and transparency of elements in your .NET MAUI application.

### Opacity classes
| Class | Effect |
|---|---|
|`opacity-0`| An opacity value of `0`. |
|`opacity-5`| An opacity value of `0.05`. |
|`opacity-10`| An opacity value of `0.1`. |
|`opacity-20`| An opacity value of `0.2`. |
|`opacity-25`| An opacity value of `0.25`. |
|`opacity-30`| An opacity value of `0.3`. |
|`opacity-40`| An opacity value of `0.4`. |
|`opacity-50`| An opacity value of `0.5`. |
|`opacity-60`| An opacity value of `0.6`. |
|`opacity-70`| An opacity value of `0.7`. |
|`opacity-75`| An opacity value of `0.75`. |
|`opacity-80`| An opacity value of `0.8`. |
|`opacity-90`| An opacity value of `0.9`. |
|`opacity-95`| An opacity value of `0.95`. |
|`opacity-100`| An opacity value of `1`. |

*Example Usage:*
```xml
<!-- Almost Hidden Label -->
<Label Text="This text is almost hidden" StyleClass="opacity-5" />

<!-- Almost Entirely Visible Button -->
<Button Text="I am almost visible" StyleClass="opacity-90" />
```

### Visibility classes
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
