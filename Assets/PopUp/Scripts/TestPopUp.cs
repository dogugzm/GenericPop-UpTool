using System;
using TMPro;
using UnityEngine;

    public class TestPopUp : BasePopup
    {
        private readonly string TitleText = "Header";
        private readonly string DescriptionText = "Descrip fescrip aescription dbescription dabdscription";

        PopUpBaseComponent componentInput;

        protected override void OnEnable()
        {
            base.OnEnable();

            PopUpBaseComponent buttonComp1 = CreateComponent(popUpScheme.ComponentButton);
            buttonComp1.WriteCustomData(new DataComponentButton(buttonImage: new DataComponentImage(path:"close"),text: "", isIgnored: true));
            buttonComp1.SetCustomMethod(() => OnExitButtonClicked());

            CreateComponent(popUpScheme.ComponentImage).
                WriteCustomData(new DataComponentImage(useUrl: false, path: "logo"));
            PopUpBaseComponent firstHorizontalComponent = CreateComponent(popUpScheme.HorizontalComponentParent);
            firstHorizontalComponent.RunChildComponent(() =>
            {
                CreateComponent(popUpScheme.ComponentImage, firstHorizontalComponent.transform).
                    WriteCustomData(new DataComponentImage( useUrl: false, path: "logo"));
                CreateComponent(popUpScheme.ComponentImage, firstHorizontalComponent.transform).
                   WriteCustomData(new DataComponentImage(useUrl: false, path: "logo"));
                CreateComponent(popUpScheme.ComponentTitle, firstHorizontalComponent.transform).
                        WriteCustomData(new DataComponentText(text: TitleText, color: "#9c813a"));

            });

            PopUpBaseComponent firstHorizontalComponent1 = CreateComponent(popUpScheme.HorizontalComponentParent);
            firstHorizontalComponent.RunChildComponent(() =>
            {

                PopUpBaseComponent verticalComponent = CreateComponent(popUpScheme.VerticalComponentParent, firstHorizontalComponent1.transform);
                verticalComponent.RunChildComponent(() =>
                {
                    CreateComponent(popUpScheme.ComponentTitle, verticalComponent.transform).
                        WriteCustomData(new DataComponentText(text: TitleText, color: "#9c813a"));
                    CreateComponent(popUpScheme.ComponentDescription, verticalComponent.transform).
                        WriteCustomData(new DataComponentText(text: DescriptionText));
                });

                PopUpBaseComponent verticalComponent1 = CreateComponent(popUpScheme.VerticalComponentParent, firstHorizontalComponent1.transform);
                verticalComponent.RunChildComponent(() =>
                {
                    CreateComponent(popUpScheme.ComponentTitle, verticalComponent1.transform).
                        WriteCustomData(new DataComponentText(text: TitleText, color: "#9c813a"));
                    CreateComponent(popUpScheme.ComponentDescription, verticalComponent1.transform).
                        WriteCustomData(new DataComponentText(text: DescriptionText));
                });

                PopUpBaseComponent verticalComponent2 = CreateComponent(popUpScheme.VerticalComponentParent, firstHorizontalComponent1.transform);
                verticalComponent.RunChildComponent(() =>
                {
                    CreateComponent(popUpScheme.ComponentTitle, verticalComponent2.transform).
                        WriteCustomData(new DataComponentText(text: TitleText, color: "#9c813a"));
                    CreateComponent(popUpScheme.ComponentDescription, verticalComponent2.transform).
                        WriteCustomData(new DataComponentText(text: DescriptionText));
                });

            });

            CreateComponent(popUpScheme.ComponentInput).
                WriteCustomData(new DataComponentInput(
                    new DataComponentText(alignmentOption: (int?)TextAlignmentOptions.Left), new DataComponentText(text: "" , alignmentOption: (int?)TextAlignmentOptions.Left), inputType: (int)InputFieldType.SMALL));

            popUpScheme.ActivateButtonParentObject(ButtonAlignment.Horizontal);

            PopUpBaseComponent buttonComp = CreateComponent(popUpScheme.ComponentButton, popUpScheme.HorizontalButtonParent.transform);
            buttonComp.WriteCustomData(new DataComponentButton(text: "asfas"));
            buttonComp.SetCustomMethod(() => OnButtonClicked());
            CreateComponent(popUpScheme.ComponentButton, popUpScheme.HorizontalButtonParent.transform);

            #region EXAMPLES

            #region HierarchicalExample
            //MyComponent firstHorizontalComponent1 = CreateComponent(dialogSchema.HorizontalComponentParent);
            //firstHorizontalComponent.RunChildComponent(() =>
            //{

            //    MyComponent verticalComponent = CreateComponent(dialogSchema.VerticalComponentParent, firstHorizontalComponent1.transform);
            //    verticalComponent.RunChildComponent(() =>
            //    {
            //        CreateComponent(dialogSchema.DialogComponentTitle, verticalComponent.transform).
            //            WriteCustomData(new DataComponentText(text: TitleText, color: "#9c813a"));
            //        CreateComponent(dialogSchema.DialogComponentDescription, verticalComponent.transform).
            //            WriteCustomData(new DataComponentText(text: DescriptionText));
            //    });

            //    MyComponent verticalComponent1 = CreateComponent(dialogSchema.VerticalComponentParent, firstHorizontalComponent1.transform);
            //    verticalComponent.RunChildComponent(() =>
            //    {
            //        CreateComponent(dialogSchema.DialogComponentTitle, verticalComponent1.transform).
            //            WriteCustomData(new DataComponentText(text: TitleText, color: "#9c813a"));
            //        CreateComponent(dialogSchema.DialogComponentDescription, verticalComponent1.transform).
            //            WriteCustomData(new DataComponentText(text: DescriptionText));
            //    });

            //    MyComponent verticalComponent2 = CreateComponent(dialogSchema.VerticalComponentParent, firstHorizontalComponent1.transform);
            //    verticalComponent.RunChildComponent(() =>
            //    {
            //        CreateComponent(dialogSchema.DialogComponentTitle, verticalComponent2.transform).
            //            WriteCustomData(new DataComponentText(text: TitleText, color: "#9c813a"));
            //        CreateComponent(dialogSchema.DialogComponentDescription, verticalComponent2.transform).
            //            WriteCustomData(new DataComponentText(text: DescriptionText));
            //    });

            //});
            #endregion

            #region Images
            //CreateComponent(dialogSchema.DialogComponentLogo, dialogSchema.MainHolder, LogoPath);
            #endregion

            #region Buttons
            //dialogSchema.ActivateButtonParentObject(ButtonAlignment.Horizontal);
            //CreateComponent(dialogSchema.DialogComponentButonHorizontal, dialogSchema.HorizontalButtonParent.transform);
            //dialogSchema.ActivateButtonParentObject(ButtonAlignment.Vertical);
            //CreateComponent(dialogSchema.DialogComponentButonHorizontal, dialogSchema.VerticalButtonParent.transform);
            //CreateComponent(dialogSchema.DialogComponentButonHorizontal, dialogSchema.HorizontalButtonParent.transform);
            //CreateComponent<string>(dialogSchema.DialogComponentButonHorizontal, dialogSchema.HorizontalButtonParent,(data) => OnOkButtonClicked(data),"asfasf");
            //CreateComponent(dialogSchema.DialogComponentButonHorizontal, dialogSchema.HorizontalButtonParent, OnSendButtonClicked);
            #endregion

            #region Input_Field
            //CreateComponent(dialogSchema.DialogComponentInput, dialogSchema.MainHolder,InputFieldType.SMALL);
            //CreateComponent(dialogSchema.DialogComponentInput, dialogSchema.MainHolder, InputFieldType.BIG);
            #endregion

            #endregion

        }

    private void OnExitButtonClicked()
    {
        Destroy(gameObject);
    }

    #region Example Actions

    private void OnButtonClicked()
        {
            Debug.Log("Button Clicked");
        }

        private void OnButtonClickedWithParameter(string data)
        {
            Debug.Log("OK: " + data);
        }

        void OnSendButtonClicked()
        {
            Debug.Log("Send: " + componentInput.GetComponent<ComponentInput>().GetInput());
        }

        #endregion

    }



