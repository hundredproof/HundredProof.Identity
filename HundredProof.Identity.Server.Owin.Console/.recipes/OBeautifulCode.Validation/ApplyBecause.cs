﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplyBecause.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.Validation source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Validation.Recipes
{
    /// <summary>
    /// Determines how to apply the optional, user-specified rationale for a validation.
    /// </summary>
#if !OBeautifulCodeValidationRecipesProject
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.Validation", "See package version number")]
    internal
#else
    public
#endif
        enum ApplyBecause
    {
        /// <summary>
        /// Apply the rationale prefixed to the default exception message.
        /// </summary>
        PrefixedToDefaultMessage,

        /// <summary>
        /// Apply the rationale suffixed to the default exception message.
        /// </summary>
        SuffixedToDefaultMessage,

        /// <summary>
        /// Apply the rationale in lieu of the default exception message.
        /// </summary>
        InLieuOfDefaultMessage,
    }
}
