﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace FlexiMvvm.Views.Generation.Ios
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ViewsGenerator : ViewsGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 1 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"

// =========================================================================
// Copyright 2019 EPAM Systems, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// =========================================================================

            
            #line default
            #line hidden
            this.Write("#nullable enable\r\n\r\n");
            this.Write("using System;\r\nusing System.Diagnostics.CodeAnalysis;\r\nusing System.Threading.Tas" +
                    "ks;\r\nusing FlexiMvvm.ViewModels;\r\nusing FlexiMvvm.Views.Core;\r\nusing FlexiMvvm.V" +
                    "iews.Keyboard;\r\nusing Foundation;\r\nusing UIKit;\r\n");
            
            #line 29 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
 foreach (var viewGenerationOptions in ViewsGenerationOptions) { 
            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 31 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetNamespace(viewGenerationOptions)));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    /// <summary>\r\n    /// Represents a/an <see cref=\"");
            
            #line 34 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.BaseClassName));
            
            #line default
            #line hidden
            this.Write("\"/> that is adapted for use with the FlexiMvvm.\r\n    /// </summary>\r\n    public p" +
                    "artial class ");
            
            #line 36 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 36 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.BaseClassName));
            
            #line default
            #line hidden
            this.Write(", IIosView\r\n    {\r\n        private IViewLifecycleDelegate? _lifecycleDelegate;\r\n " +
                    "       private KeyboardHandler? _keyboardHandler;\r\n\r\n        /// <inheritdoc />\r" +
                    "\n        public ");
            
            #line 42 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n            LifecycleDelegate.ForceInstanceCreation();\r\n        }\r" +
                    "\n\r\n        /// <inheritdoc />\r\n        public ");
            
            #line 48 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("(NSCoder coder)\r\n            : base(coder)\r\n        {\r\n            LifecycleDeleg" +
                    "ate.ForceInstanceCreation();\r\n        }\r\n\r\n        /// <inheritdoc />\r\n        p" +
                    "ublic ");
            
            #line 55 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("(string nibName, NSBundle bundle)\r\n            : base(nibName, bundle)\r\n        {" +
                    "\r\n            LifecycleDelegate.ForceInstanceCreation();\r\n        }\r\n\r\n        /" +
                    "// <inheritdoc />\r\n        protected ");
            
            #line 62 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("(NSObjectFlag t)\r\n            : base(t)\r\n        {\r\n            LifecycleDelegate" +
                    ".ForceInstanceCreation();\r\n        }\r\n\r\n        /// <inheritdoc />\r\n        prot" +
                    "ected internal ");
            
            #line 69 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(@"(IntPtr handle)
            : base(handle)
        {
            LifecycleDelegate.ForceInstanceCreation();
        }

        /// <summary>
        /// Gets the view lifecycle delegate. Intended for internal use by the FlexiMvvm.
        /// </summary>
        protected IViewLifecycleDelegate LifecycleDelegate => _lifecycleDelegate ??= CreateLifecycleDelegate();

");
            
            #line 80 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
      if (viewGenerationOptions.HandleKeyboard) { 
            
            #line default
            #line hidden
            this.Write("        /// <inheritdoc />\r\n        public virtual IKeyboardHandler? KeyboardHand" +
                    "ler => _keyboardHandler ??= Keyboard.KeyboardHandler.Create(View);\r\n");
            
            #line 83 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
      } else { 
            
            #line default
            #line hidden
            this.Write("        /// <inheritdoc />\r\n        public virtual IKeyboardHandler? KeyboardHand" +
                    "ler => _keyboardHandler;\r\n");
            
            #line 86 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
      } 
            
            #line default
            #line hidden
            this.Write(@"
        /// <summary>
        /// Creates a new <see cref=""IViewLifecycleDelegate""/> instance. Intended for internal use by the FlexiMvvm.
        /// </summary>
        protected virtual IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<");
            
            #line 93 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(">(this);\r\n        }\r\n\r\n        /// <inheritdoc />\r\n        public override void W" +
                    "illMoveToParentViewController(UIViewController? parent)\r\n        {\r\n            " +
                    "base.WillMoveToParentViewController(parent);\r\n\r\n            LifecycleDelegate.Wi" +
                    "llMoveToParentViewController(parent);\r\n        }\r\n\r\n        /// <inheritdoc />\r\n" +
                    "        public override void ViewDidLoad()\r\n        {\r\n            base.ViewDidL" +
                    "oad();\r\n\r\n            LifecycleDelegate.ViewDidLoad();\r\n        }\r\n\r\n        ///" +
                    " <inheritdoc />\r\n        public override void ViewWillAppear(bool animated)\r\n   " +
                    "     {\r\n            base.ViewWillAppear(animated);\r\n\r\n            LifecycleDeleg" +
                    "ate.ViewWillAppear();\r\n        }\r\n\r\n        /// <inheritdoc />\r\n        public o" +
                    "verride void ViewDidAppear(bool animated)\r\n        {\r\n            base.ViewDidAp" +
                    "pear(animated);\r\n\r\n            LifecycleDelegate.ViewDidAppear();\r\n        }\r\n\r\n" +
                    "        /// <inheritdoc />\r\n        public override void ViewWillDisappear(bool " +
                    "animated)\r\n        {\r\n            base.ViewWillDisappear(animated);\r\n\r\n         " +
                    "   LifecycleDelegate.ViewWillDisappear();\r\n        }\r\n\r\n        /// <inheritdoc " +
                    "/>\r\n        public override void ViewDidDisappear(bool animated)\r\n        {\r\n   " +
                    "         base.ViewDidDisappear(animated);\r\n\r\n            LifecycleDelegate.ViewD" +
                    "idDisappear();\r\n        }\r\n\r\n        /// <inheritdoc />\r\n        public override" +
                    " void DidMoveToParentViewController(UIViewController? parent)\r\n        {\r\n      " +
                    "      base.DidMoveToParentViewController(parent);\r\n\r\n            LifecycleDelega" +
                    "te.DidMoveToParentViewController(parent);\r\n        }\r\n    }\r\n\r\n    /// <summary>" +
                    "\r\n    /// Represents a/an <see cref=\"");
            
            #line 154 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.BaseClassName));
            
            #line default
            #line hidden
            this.Write(@"""/> that is adapted for use with the FlexiMvvm
    /// and has its own lifecycle-aware view model.
    /// </summary>
    /// <typeparam name=""TViewModel"">The type of the view model.</typeparam>
    [SuppressMessage(
        ""Compiler"",
        ""CS8618:Non-nullable field is uninitialized."",
        Justification = ""The view lifecycle delegate sets a value to the ViewModel property so it is never null."")]
    public partial class ");
            
            #line 162 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("<TViewModel> : ");
            
            #line 162 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(", INavigationView<TViewModel>, ILifecycleViewModelOwner<TViewModel>\r\n        wher" +
                    "e TViewModel : class, ILifecycleViewModelWithoutParameters\r\n    {\r\n        /// <" +
                    "inheritdoc />\r\n        public ");
            
            #line 166 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n        }\r\n\r\n        /// <inheritdoc />\r\n        public ");
            
            #line 171 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("(NSCoder coder)\r\n            : base(coder)\r\n        {\r\n        }\r\n\r\n        /// <" +
                    "inheritdoc />\r\n        public ");
            
            #line 177 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("(string nibName, NSBundle bundle)\r\n            : base(nibName, bundle)\r\n        {" +
                    "\r\n        }\r\n\r\n        /// <inheritdoc />\r\n        protected ");
            
            #line 183 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("(NSObjectFlag t)\r\n            : base(t)\r\n        {\r\n        }\r\n\r\n        /// <inh" +
                    "eritdoc />\r\n        protected internal ");
            
            #line 189 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(@"(IntPtr handle)
            : base(handle)
        {
        }

        /// <inheritdoc />
        public event EventHandler<ResultSetEventArgs> ResultSet;

        /// <inheritdoc />
        public TViewModel ViewModel { get; private set; }

        /// <inheritdoc />
        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<");
            
            #line 203 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(@"<TViewModel>, TViewModel>(this);
        }

        /// <inheritdoc />
        public void SetResult(ResultCode resultCode, Result? result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        /// <inheritdoc />
        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        /// <inheritdoc />
        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void ILifecycleViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task ILifecycleViewModelOwner<TViewModel>.InitializeViewModelAsync(bool recreated)
        {
            await ViewModel.InitializeAsync(recreated);
        }
    }

    /// <summary>
    /// Represents a/an <see cref=""");
            
            #line 241 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.BaseClassName));
            
            #line default
            #line hidden
            this.Write(@"""/> that is adapted for use with the FlexiMvvm,
    /// has its own lifecycle-aware view model and takes lifecycle-aware view model parameters.
    /// </summary>
    /// <typeparam name=""TViewModel"">The type of the view model.</typeparam>
    /// <typeparam name=""TParameters"">The type of the view model parameters.</typeparam>
    [SuppressMessage(
        ""Compiler"",
        ""CS8618:Non-nullable field is uninitialized."",
        Justification = ""The view lifecycle delegate sets a value to the ViewModel property so it is never null."")]
    public partial class ");
            
            #line 250 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("<TViewModel, TParameters> : ");
            
            #line 250 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(@", INavigationView<TViewModel, TParameters>, ILifecycleViewModelOwner<TViewModel>
        where TViewModel : class, ILifecycleViewModelWithParameters<TParameters>
        where TParameters : Parameters
    {
        private TParameters? _parameters;

        /// <inheritdoc />
        public ");
            
            #line 257 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n        }\r\n\r\n        /// <inheritdoc />\r\n        public ");
            
            #line 262 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("(NSCoder coder)\r\n            : base(coder)\r\n        {\r\n        }\r\n\r\n        /// <" +
                    "inheritdoc />\r\n        public ");
            
            #line 268 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("(string nibName, NSBundle bundle)\r\n            : base(nibName, bundle)\r\n        {" +
                    "\r\n        }\r\n\r\n        /// <inheritdoc />\r\n        protected ");
            
            #line 274 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("(NSObjectFlag t)\r\n            : base(t)\r\n        {\r\n        }\r\n\r\n        /// <inh" +
                    "eritdoc />\r\n        protected internal ");
            
            #line 280 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(@"(IntPtr handle)
            : base(handle)
        {
        }

        /// <inheritdoc />
        public event EventHandler<ResultSetEventArgs> ResultSet;

        /// <inheritdoc />
        public TViewModel ViewModel { get; private set; }

        /// <inheritdoc />
        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<");
            
            #line 294 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(@"<TViewModel, TParameters>, TViewModel>(this);
        }

        /// <inheritdoc />
        public void SetParameters(TParameters? parameters)
        {
            _parameters = parameters;
        }

        /// <inheritdoc />
        public void SetResult(ResultCode resultCode, Result? result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        /// <inheritdoc />
        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        /// <inheritdoc />
        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void ILifecycleViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task ILifecycleViewModelOwner<TViewModel>.InitializeViewModelAsync(bool recreated)
        {
            await ViewModel.InitializeAsync(_parameters, recreated);
        }
    }
}
");
            
            #line 337 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Ios\ViewsGenerator.tt"
 } 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class ViewsGeneratorBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
