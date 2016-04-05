﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace WebApiProxy.Server.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class JsProxyTemplate : JsProxyTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n;(function(exportCallback) {\r\n\t\"use strict\";\r\n\r\n\tvar exports = {\r\n\t\toptions: {\r" +
                    "\n\t\t\tbaseUrl: \"");
            
            #line 12 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Metadata.Host));
            
            #line default
            #line hidden
            this.Write("\",\r\n\t\t\tajax:  function(method, url, data) {\r\n\t\t\t\tif (typeof window === \'undefined" +
                    "\' || typeof window.jQuery === \'undefined\') {\r\n\t\t\t\t\tthrow \"WebApiProxy: jQuery is" +
                    " required if no other ajax method has been defined.\";\r\n\t\t\t\t}\r\n\r\n\t\t\t\tvar opts = {" +
                    "\r\n\t\t\t\t\ttype: method,\r\n\t\t\t\t\turl: url,\r\n\t\t\t\t\tdataType:\"json\"\r\n\t\t\t\t};\r\n\r\n\t\t\t\tif ((m" +
                    "ethod === \"post\" || method === \"put\") && data) {\r\n\t\t\t\t\topts.data = JSON.stringif" +
                    "y(data);\r\n\t\t\t\t}\r\n\r\n\t\t\t\treturn window.jQuery.ajax.apply(window.jQuery, opts);\r\n\t\t" +
                    "\t}\r\n\t\t},\r\n\t\tproxies: {}\r\n\t};\r\n\r\n\tfunction invoke(url, type, urlParams, body) {\r\n" +
                    "\t\treturn exports.options.ajax(type, combinePath(exports.options.baseUrl, compose" +
                    "Url(url, urlParams)), body);\r\n\t}\r\n\r\n\tfunction extend(){\r\n\t\tvar extended = argume" +
                    "nts[0] || {};\r\n\t\tvar prop;\r\n\t\tvar i;\r\n\r\n\t\tfor (i = 1; i < arguments.length; i++)" +
                    " {\r\n\t\t\tfor (prop in arguments[i]) {\r\n\t\t\t\tif (Object.prototype.hasOwnProperty.cal" +
                    "l(arguments[i], prop)) {\r\n\t\t\t\t\textended[prop] = arguments[i][prop];\r\n\t\t\t\t}\r\n\t\t\t}" +
                    "           \r\n\t\t}\r\n\r\n\t\treturn extended;\r\n\t}\r\n\r\n\tfunction composeUrl(url, urlParam" +
                    "s) {\r\n\t\tvar used = [];\r\n\t\tvar key;\r\n\t\tvar hasQuery = false;\r\n\r\n\t\turl = url.repla" +
                    "ce(/\\{(\\w+)\\}/gi, function(match, capture, offset) {\t\t\t\r\n\t\t\tif (typeof urlParams" +
                    "[capture] !== \'undefined\'){\r\n\t\t\t\tused[capture] = true;\r\n\t\t\t}\r\n\r\n\t\t\tif (urlParams" +
                    "[capture] == null){\r\n\t\t\t\treturn \'\';\r\n\t\t\t} else {\t\t\t\t\r\n\t\t\t\treturn urlParams[captu" +
                    "re].toString();\r\n\t\t\t}\r\n\t\t});\r\n\r\n\t\tfor (key in urlParams){\r\n\t\t\tif (!used[key] && " +
                    "urlParams[key] != null) {\r\n\t\t\t\tif (!hasQuery && url.indexOf(\'?\') === -1){\r\n\t\t\t\t\t" +
                    "url += \'?\';\r\n\t\t\t\t\thasQuery = true;\r\n\t\t\t\t} else {\r\n\t\t\t\t\turl += \'&\';\r\n\t\t\t\t}\r\n\t\t\t\tu" +
                    "rl += key + \'=\' + urlParams[key].toString();\r\n\t\t\t}\r\n\t\t}\r\n\r\n\t\treturn url;\r\n\t}\r\n\t\r" +
                    "\n\tfunction combinePath() {\r\n        var path = \'\';\r\n        var s;\r\n        var " +
                    "first;\r\n        var last;\r\n\r\n        for (var i = 0; i < arguments.length; i++) " +
                    "{\r\n            if (arguments[i] == null) {\r\n                continue;\r\n         " +
                    "   }\r\n            s = arguments[i].toString();\r\n                        \r\n      " +
                    "      first = s.indexOf(\'/\');\r\n\r\n            if (s === \'/\' && path.length > 0) {" +
                    "\r\n                continue;\r\n            }\r\n            else if (path[path.lengt" +
                    "h-1] === \'/\' && first === 0) {\r\n                path += s.slice(1);\r\n           " +
                    " } else if (path[path.length - 1] === \'/\' || first === 0) {\r\n                pat" +
                    "h += s;\r\n            } else if (path.length > 0) {                \r\n            " +
                    "    path += (\'/\'+s);\r\n            } else {\r\n                path += s;\r\n        " +
                    "    }\r\n        }\r\n\r\n        return path;\r\n    }\r\n\r\n\t/* Proxies */\r\n\r\n");
            
            #line 119 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 foreach(var definition in this.Metadata.Definitions) { 
            
            #line default
            #line hidden
            this.Write("\texports.proxies[\"");
            
            #line 120 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(definition.Name.ToLower()));
            
            #line default
            #line hidden
            this.Write("\"] = {\r\n\t\t\"defaultOptions\": {},\r\n");
            
            #line 122 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 foreach(var method in definition.ActionMethods.OrderBy(m => m.Name)) {	
	var allParameters = method.UrlParameters.AsEnumerable();	
	
	if (method.BodyParameter != null) {
		allParameters = allParameters.Concat(new [] { method.BodyParameter });
	}

	var selectedParameters = allParameters.Where(m => m != null).Select(m => m.Name).ToList();	
	var parameterList = string.Join(",", selectedParameters);
	var parameterString = new System.Text.StringBuilder();	

	if (method.UrlParameters.Any()) {
		parameterString.Append(", {");
		parameterString.Append(string.Join(", ", method.UrlParameters.Select(s => "'" + s.Name + "':" + s.Name)));		
		parameterString.Append("}");
	} else {
		parameterString.Append(",null");
	}
	
	if (method.BodyParameter != null) {
		parameterString.Append(", ").Append(method.BodyParameter.Name);		
	}


            
            #line default
            #line hidden
            this.Write("\t\t\"");
            
            #line 146 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name.ToCamelCasing()));
            
            #line default
            #line hidden
            this.Write("\": function(");
            
            #line 146 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterList));
            
            #line default
            #line hidden
            this.Write(") {\r\n\t\t\treturn invoke.call(this, \"");
            
            #line 147 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Url));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 147 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Type.ToString().ToLower()));
            
            #line default
            #line hidden
            this.Write("\" ");
            
            #line 147 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterString));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t},\r\n");
            
            #line 149 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" \r\n\t};\r\n");
            
            #line 151 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
	} 
            
            #line default
            #line hidden
            this.Write("\r\n\texportCallback(exports);\r\n\r\n}(function(exports){\r\n");
            
            #line 156 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
if (string.IsNullOrEmpty(this.ExportCallback)) {
            
            #line default
            #line hidden
            this.Write("\twindow.jQuery.proxies = exports.proxies;\r\n");
            
            #line 158 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
} else {
            
            #line default
            #line hidden
            this.Write("\tif (typeof ");
            
            #line 159 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ExportCallback));
            
            #line default
            #line hidden
            this.Write(" === \'function\'){\r\n\t\t");
            
            #line 160 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ExportCallback));
            
            #line default
            #line hidden
            this.Write("(exports);\r\n\t}\r\n");
            
            #line 162 "C:\code\git\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("}));");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class JsProxyTemplateBase
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
