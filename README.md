# Plugin.Maui.Crosswind
 
 A utility-first design framework for .NET MAUI that brings the simplicity and flexibility of utility-based styling to XAML. Inspired by the efficiency of Tailwind CSS, Crosswind offers developers a streamlined way to create modern, consistent UIs. Perfect for rapid development and clean, maintainable design. By using the predefined style classes contained in this library, developers can:

- **Streamline styling:** Quickly apply consistent styles across your app without duplicating code.
- **Increase productivity:** Spend less time writing custom styles and more time building features.
- **Improve maintainability:** Centralized and reusable styles make it easy to update designs and ensure consistency. You aren’t wasting energy inventing in class names. No more adding silly class names like `list-inner-wrapper` just to be able to style something, and no more agonizing over the perfect abstract name for something that’s really just a container.

Crosswind supports the following broad categories when it comes to styling:

- [Alignment](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Alignment)
- [Borders](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Borders)
- [Colors](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Colors)
- [Shadows](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Shadows)
- [Spacing](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Spacing)
- [Transformations](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Transformations)
- [Typography](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Typography)
- [Visibility](https://github.com/sthewissen/Plugin.Maui.Crosswind/tree/main#Visibility)

## Crosswind in action
A picture is worth a thousand words, and seeing Crosswind in action can speak volumes about how it simplifies your UI styling. Below are examples of how you can create beautiful, consistent layouts in .NET MAUI using Crosswind classes. Each example includes a visual and the corresponding XAML code to show you just how easy it is to use.

`// TODO`

## Colors

Crosswind includes the default Tailwind color palette out-of-the-box that is a great starting point if you don't have your own specific branding in mind. These colors can be used in various locations throughout Crosswind, such as background colors, text colors and border colors. The following overview shows all of the out-of-the-box colors you have access to.

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

### Border color classes

### Text color classes
You can easily set text colors using utility classes that map to a predefined set of colors. Each text color class applies a specific color to the foreground of the text element. Please refer to the overview above for the supported colors. You can apply the text color classes in the `StyleClass` property of any element that supports the `TextColor` property (see the compatibilty matrix for typography-related classes below).

```xml
<Label StyleClass="text-fuchsia-800" Text="This is an element with nice text colors." />
```

----

## Spacing
The spacing utilities in Crosswind offer a consistent way to apply spacing in or around elements in your .NET MAUI application adhering to a 4 point grid system, ideal for your mobile apps.

### Margin classes
Margin classes provide spacing around an element on all sides (`Margin` property). The values are defined using a scale ranging from 0 to 8, with each step representing an increment of `4dp`. These classes all target `View`.

| Class | Margin Value |
|---|---|
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
Directional margin classes provide spacing around an element on specific sides (`Margin` property). The values are defined using a scale ranging from 0 to 8, with each step representing an increment of `4dp`. These classes all target `View`.

| Class | Margin Value |
|---|---|
|`mx-1`| A value of `4` on left and right |
|`mx-2`| A value of `8` on left and right |
|`mx-3`| A value of `12` on left and right |
|`mx-4`| A value of `16` on left and right |
|`mx-5`| A value of `20` on left and right |
|`mx-6`| A value of `24` on left and right |
|`mx-7`| A value of `28` on left and right |
|`mx-8`| A value of `32` on left and right |
|`my-1`| A value of `4` on top and bottom |
|`my-2`| A value of `8` on top and bottom |
|`my-3`| A value of `12` on top and bottom |
|`my-4`| A value of `16` on top and bottom |
|`my-5`| A value of `20` on top and bottom |
|`my-6`| A value of `24` on top and bottom |
|`my-7`| A value of `28` on top and bottom |
|`my-8`| A value of `32` on top and bottom |

*Example usage:*
```xml
<!-- Horizontal margin -->
<Label Text="Horizontal margin" StyleClass="mx-4" />

<!-- Vertical margin -->
<Button Text="Vertical margin" StyleClass="my-2" />
```

### Padding classes
Padding classes provide spacing around an element on all sides (`Padding` property). The values are defined using a scale ranging from 0 to 8, with each step representing an increment of `4dp`. These classes all target `VisualElement`.

| Class | Padding Value |
|---|---|
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
Directional padding classes provide spacing within an element on specific sides (`Padding` property). The values are defined using a scale ranging from 0 to 8, with each step representing an increment of `4dp`. These classes all target `VisualElement`.

| Class | Padding Value |
|---|---|
|`px-1`| A value of `4` on left and right |
|`px-2`| A value of `8` on left and right |
|`px-3`| A value of `12` on left and right |
|`px-4`| A value of `16` on left and right |
|`px-5`| A value of `20` on left and right |
|`px-6`| A value of `24` on left and right |
|`px-7`| A value of `28` on left and right |
|`px-8`| A value of `32` on left and right |
|`py-1`| A value of `4` on top and bottom |
|`py-2`| A value of `8` on top and bottom |
|`py-3`| A value of `12` on top and bottom |
|`py-4`| A value of `16` on top and bottom |
|`py-5`| A value of `20` on top and bottom |
|`py-6`| A value of `24` on top and bottom |
|`py-7`| A value of `28` on top and bottom |
|`py-8`| A value of `32` on top and bottom |

*Example usage:*
```xml
<!-- Horizontal padding -->
<Label Text="Horizontal padding" StyleClass="px-4" />

<!-- Vertical padding -->
<Button Text="Vertical padding" StyleClass="py-2" />
```

### Notes
Due to .NET MAUI's limitations with the `Margin` and `Padding` properties, which sets all four sides (top, bottom, left, and right) at once, individual margin and padding classes cannot be combined. For example, applying `mx-4` and `my-6` together is not supported, as one will override the other. Instead, use a single class to define the desired margin configuration.

---

## Typography

### Control Compatibility
In a XAML-based framework like .NET MAUI, each control has a well-defined set of properties, which can limit the direct application of shared styles across multiple control types. Unlike HTML, where elements can often inherit styles flexibly, XAML requires a more structured approach due to its reliance on specific `TargetType` bindings. Due to the usage of StyleClass, applying a class to a control will never lead to a runtime exception, but it will just fail silently. This section provides a comprehensive compatibility table that outlines which Crosswind `StyleClass` definitions are supported by the various different controls that exist in .NET MAUI.

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

*`InputView` covers the `Entry`, `Editor` and `SearchBar` controls.

---

## Visibility
The visibility utilities in Crosswind provide simple classes to control the visibility and transparency of elements in your .NET MAUI application. These classes all target `VisualElement`.

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
