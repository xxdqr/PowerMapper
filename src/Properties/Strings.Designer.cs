﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PowerMapper.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PowerMapper.Properties.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 The argument value cannot be null or empty string. 的本地化字符串。
        /// </summary>
        internal static string Argument_CannotNullOrEmpty {
            get {
                return ResourceManager.GetString("Argument_CannotNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The collection is read-only. 的本地化字符串。
        /// </summary>
        internal static string Collection_ReadOnly {
            get {
                return ResourceManager.GetString("Collection_ReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The convention is read-only. 的本地化字符串。
        /// </summary>
        internal static string Convention_ReadOnly {
            get {
                return ResourceManager.GetString("Convention_ReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The type &apos;{0}&apos; is ambiguous: it could come from assembly &apos;{1}&apos; or from assembly &apos;{2}&apos;. Please specify the assembly explicitly in the type name. 的本地化字符串。
        /// </summary>
        internal static string Converter_AmbiguousTypes {
            get {
                return ResourceManager.GetString("Converter_AmbiguousTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot find the type &quot;{0}&quot;. 的本地化字符串。
        /// </summary>
        internal static string Converter_CannotFindType {
            get {
                return ResourceManager.GetString("Converter_CannotFindType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The source type of the converter is {0}, which does not match the type of the source member: {1}. 的本地化字符串。
        /// </summary>
        internal static string Converter_InvalidSourceType {
            get {
                return ResourceManager.GetString("Converter_InvalidSourceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The target type of the converter is {0}, which does not match the type of the target member: {1}. 的本地化字符串。
        /// </summary>
        internal static string Converter_InvalidTargetType {
            get {
                return ResourceManager.GetString("Converter_InvalidTargetType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Type &apos;{0}&apos; does not have a parameterless constructor. 的本地化字符串。
        /// </summary>
        internal static string Creator_CannotFindConstructor {
            get {
                return ResourceManager.GetString("Creator_CannotFindConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot cast from type &apos;{0}&apos; to type &apos;{1}&apos;. 的本地化字符串。
        /// </summary>
        internal static string Emit_InvalidCastType {
            get {
                return ResourceManager.GetString("Emit_InvalidCastType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The lambda expression must be property or field access expression. 的本地化字符串。
        /// </summary>
        internal static string InvalidLambdaExpression {
            get {
                return ResourceManager.GetString("InvalidLambdaExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The type mapper has been initialized. Please configure options before the other configurations. 的本地化字符串。
        /// </summary>
        internal static string TypeMapper_Initialized {
            get {
                return ResourceManager.GetString("TypeMapper_Initialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The name of the target member cannot be null or empty. 的本地化字符串。
        /// </summary>
        internal static string TypeMapper_MemberNameCannotNullOrEmpty {
            get {
                return ResourceManager.GetString("TypeMapper_MemberNameCannotNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The type mapper is read-only. 的本地化字符串。
        /// </summary>
        internal static string TypeMapper_ReadOnly {
            get {
                return ResourceManager.GetString("TypeMapper_ReadOnly", resourceCulture);
            }
        }
    }
}
