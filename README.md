# Generic Pop-Up Creator for Unity

![genericpopup](https://github.com/dogugzm/GenericPopUp/assets/30691424/2dc1c1fc-2365-4a8b-aa04-438164a1d9be)


## Overview

The Generic Pop-Up Creator is a tool designed for Unity developers to easily create customizable pop-up windows within their projects. This tool streamlines the process of creating pop-ups by providing a user-friendly interface and a set of flexible customization options.

With the Generic Pop-Up Creator, developers can quickly add pop-up functionality to their Unity projects without having to write extensive code or design each pop-up from scratch. This tool is ideal for game developers, UI designers, and anyone looking to enhance user interaction within their Unity applications.

## Features

- **Easy Integration**: Simply import the package into your Unity project and start creating pop-ups right away.
- **Customizable Templates**: Choose from a variety of pre-designed templates or create your own custom pop-up designs.
- **Dynamic Content**: Easily populate pop-ups with dynamic content such as text, images, buttons, and more.
- **Responsive Design**: Ensure your pop-ups look great on any screen size or resolution.
- **Event Handling**: Seamlessly handle user interactions with customizable event handlers for buttons and other UI elements.
- **Scripting Support**: Access and control pop-up functionality through C# scripts for advanced customization.
- **Easily Configurable**: All components have their own data class that means they are easily configurable through json, message packs, scriptable objects or txt files.


## Getting Started

1. **Import into Unity**: Open your Unity project and import the Generic Pop-Up Creator package.
2. **Usage**: Refer to the example scene to see easily create your first Pop-Up or follow along.

## Usage

### Creating a Title Component:
```csharp
// Creating a Title Component
CreateComponent(popUpScheme.ComponentTitle)
    .WriteCustomData(new DataComponentText(text: "HEADER", color: "#000000", fontSize: 100));
```
![Image Sequence_005_0000](https://github.com/dogugzm/GenericPopUp/assets/30691424/03c68c6a-47c1-44c0-9b59-6f18fe1edca0)

### Adding an Image Component
```csharp
// Adding an Image Component
CreateComponent(popUpScheme.ComponentImage)
    .WriteCustomData(new DataComponentImage(path: "dotRed"));
```
![Image Sequence_006_0000](https://github.com/dogugzm/GenericPopUp/assets/30691424/7d771022-76c5-4c88-9de0-519f289cabf4)

### Combining Components in a Horizontal Layout
```csharp
// Combining Components in a Horizontal Layout
PopUpBaseComponent firstHorizontalComponent = CreateComponent(popUpScheme.HorizontalComponentParent);
firstHorizontalComponent.RunChildComponent(() =>
{
    // Add two images and a text component horizontally
    CreateComponent(popUpScheme.ComponentImage, firstHorizontalComponent.transform)
        .WriteCustomData(new DataComponentImage(path: "dotRed"));
        
    CreateComponent(popUpScheme.ComponentImage, firstHorizontalComponent.transform)
        .WriteCustomData(new DataComponentImage(useUrl: false, path: "dotRed"));
        
    CreateComponent(popUpScheme.ComponentTitle, firstHorizontalComponent.transform)
        .WriteCustomData(new DataComponentText(text: "HEADER TEXT", color: "#000000", fontSize: 80));
});
```
![Image Sequence_008_0000](https://github.com/dogugzm/GenericPopUp/assets/30691424/d722412d-6637-4267-849e-9b79b5c1c08c)

### Creating Complex Layouts with Multiple Vertical Components
```csharp
// Creating Complex Layouts with Multiple Vertical Components
PopUpBaseComponent firstHorizontalComponent1 = CreateComponent(popUpScheme.HorizontalComponentParent);
firstHorizontalComponent.RunChildComponent(() =>
{
    // Create multiple vertical components with titles and descriptions
    for (int i = 0; i < 3; i++)
    {
        PopUpBaseComponent verticalComponent = CreateComponent(popUpScheme.VerticalComponentParent, firstHorizontalComponent1.transform);
        verticalComponent.RunChildComponent(() =>
        {
            CreateComponent(popUpScheme.ComponentTitle, verticalComponent.transform)
                .WriteCustomData(new DataComponentText(text: "TITLE", color: "#ff1100"));
                
            CreateComponent(popUpScheme.ComponentDescription, verticalComponent.transform)
                .WriteCustomData(new DataComponentText(text: DescriptionText, fontSize: 35));
        });
    }
});
```
![Image Sequence_009_0000](https://github.com/dogugzm/GenericPopUp/assets/30691424/682f7bd2-33ae-46e0-822e-fa53bd5e92c1)

### Adding Button Components
```csharp
// Activate button parent object and set alignment to horizontal
popUpScheme.ActivateButtonParentObject(ButtonAlignment.Horizontal);

// Create a button component with custom text and method
PopUpBaseComponent buttonComp = CreateComponent(popUpScheme.ComponentButton, popUpScheme.HorizontalButtonParent.transform);
buttonComp.WriteCustomData(new DataComponentButton(text: "Custom"));
buttonComp.SetCustomMethod(() => OnButtonClicked());

// Create another button component (customize as needed)
CreateComponent(popUpScheme.ComponentButton, popUpScheme.HorizontalButtonParent.transform); 
```
![Image Sequence_011_0000](https://github.com/dogugzm/GenericPopUp/assets/30691424/bcb46436-7084-4ac5-860a-53abf0a6282d)
### Adding Input Components
```csharp
// Adding Input Components
CreateComponent(popUpScheme.ComponentInput)
    .WriteCustomData(new DataComponentInput(
        new DataComponentText(alignmentOption: (int?)TextAlignmentOptions.Left, text: "PLACEHOLDER"),
        new DataComponentText(text: "", alignmentOption: (int?)TextAlignmentOptions.Left),
        inputType: (int)InputFieldType.SMALL));
```
![Image Sequence_012_0000](https://github.com/dogugzm/GenericPopUp/assets/30691424/f788c6ab-969a-45d2-bcc8-95e9fa4c52c5)



   




