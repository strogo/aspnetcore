// <auto-generated />
namespace Microsoft.AspNetCore.Routing
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Routing.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Value must be greater than or equal to {0}.
        /// </summary>
        internal static string ArgumentMustBeGreaterThanOrEqualTo
        {
            get { return GetString("ArgumentMustBeGreaterThanOrEqualTo"); }
        }

        /// <summary>
        /// Value must be greater than or equal to {0}.
        /// </summary>
        internal static string FormatArgumentMustBeGreaterThanOrEqualTo(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ArgumentMustBeGreaterThanOrEqualTo"), p0);
        }

        /// <summary>
        /// The value for argument '{0}' should be less than or equal to the value for the argument '{1}'.
        /// </summary>
        internal static string RangeConstraint_MinShouldBeLessThanOrEqualToMax
        {
            get { return GetString("RangeConstraint_MinShouldBeLessThanOrEqualToMax"); }
        }

        /// <summary>
        /// The value for argument '{0}' should be less than or equal to the value for the argument '{1}'.
        /// </summary>
        internal static string FormatRangeConstraint_MinShouldBeLessThanOrEqualToMax(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RangeConstraint_MinShouldBeLessThanOrEqualToMax"), p0, p1);
        }

        /// <summary>
        /// The '{0}' property of '{1}' must not be null.
        /// </summary>
        internal static string PropertyOfTypeCannotBeNull
        {
            get { return GetString("PropertyOfTypeCannotBeNull"); }
        }

        /// <summary>
        /// The '{0}' property of '{1}' must not be null.
        /// </summary>
        internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PropertyOfTypeCannotBeNull"), p0, p1);
        }

        /// <summary>
        /// The supplied route name '{0}' is ambiguous and matched more than one route.
        /// </summary>
        internal static string NamedRoutes_AmbiguousRoutesFound
        {
            get { return GetString("NamedRoutes_AmbiguousRoutesFound"); }
        }

        /// <summary>
        /// The supplied route name '{0}' is ambiguous and matched more than one route.
        /// </summary>
        internal static string FormatNamedRoutes_AmbiguousRoutesFound(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NamedRoutes_AmbiguousRoutesFound"), p0);
        }

        /// <summary>
        /// A default handler must be set on the RouteCollection.
        /// </summary>
        internal static string DefaultHandler_MustBeSet
        {
            get { return GetString("DefaultHandler_MustBeSet"); }
        }

        /// <summary>
        /// A default handler must be set on the RouteCollection.
        /// </summary>
        internal static string FormatDefaultHandler_MustBeSet()
        {
            return GetString("DefaultHandler_MustBeSet");
        }

        /// <summary>
        /// The constructor to use for activating the constraint type '{0}' is ambiguous. Multiple constructors were found with the following number of parameters: {1}.
        /// </summary>
        internal static string DefaultInlineConstraintResolver_AmbiguousCtors
        {
            get { return GetString("DefaultInlineConstraintResolver_AmbiguousCtors"); }
        }

        /// <summary>
        /// The constructor to use for activating the constraint type '{0}' is ambiguous. Multiple constructors were found with the following number of parameters: {1}.
        /// </summary>
        internal static string FormatDefaultInlineConstraintResolver_AmbiguousCtors(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DefaultInlineConstraintResolver_AmbiguousCtors"), p0, p1);
        }

        /// <summary>
        /// Could not find a constructor for constraint type '{0}' with the following number of parameters: {1}.
        /// </summary>
        internal static string DefaultInlineConstraintResolver_CouldNotFindCtor
        {
            get { return GetString("DefaultInlineConstraintResolver_CouldNotFindCtor"); }
        }

        /// <summary>
        /// Could not find a constructor for constraint type '{0}' with the following number of parameters: {1}.
        /// </summary>
        internal static string FormatDefaultInlineConstraintResolver_CouldNotFindCtor(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DefaultInlineConstraintResolver_CouldNotFindCtor"), p0, p1);
        }

        /// <summary>
        /// The constraint type '{0}' which is mapped to constraint key '{1}' must implement the '{2}' interface.
        /// </summary>
        internal static string DefaultInlineConstraintResolver_TypeNotConstraint
        {
            get { return GetString("DefaultInlineConstraintResolver_TypeNotConstraint"); }
        }

        /// <summary>
        /// The constraint type '{0}' which is mapped to constraint key '{1}' must implement the '{2}' interface.
        /// </summary>
        internal static string FormatDefaultInlineConstraintResolver_TypeNotConstraint(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DefaultInlineConstraintResolver_TypeNotConstraint"), p0, p1, p2);
        }

        /// <summary>
        /// A path segment that contains more than one section, such as a literal section or a parameter, cannot contain a catch-all parameter.
        /// </summary>
        internal static string TemplateRoute_CannotHaveCatchAllInMultiSegment
        {
            get { return GetString("TemplateRoute_CannotHaveCatchAllInMultiSegment"); }
        }

        /// <summary>
        /// A path segment that contains more than one section, such as a literal section or a parameter, cannot contain a catch-all parameter.
        /// </summary>
        internal static string FormatTemplateRoute_CannotHaveCatchAllInMultiSegment()
        {
            return GetString("TemplateRoute_CannotHaveCatchAllInMultiSegment");
        }

        /// <summary>
        /// The route parameter '{0}' has both an inline default value and an explicit default value specified. A route parameter cannot contain an inline default value when a default value is specified explicitly. Consider removing one of them.
        /// </summary>
        internal static string TemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly
        {
            get { return GetString("TemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly"); }
        }

        /// <summary>
        /// The route parameter '{0}' has both an inline default value and an explicit default value specified. A route parameter cannot contain an inline default value when a default value is specified explicitly. Consider removing one of them.
        /// </summary>
        internal static string FormatTemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly"), p0);
        }

        /// <summary>
        /// A path segment cannot contain two consecutive parameters. They must be separated by a '/' or by a literal string.
        /// </summary>
        internal static string TemplateRoute_CannotHaveConsecutiveParameters
        {
            get { return GetString("TemplateRoute_CannotHaveConsecutiveParameters"); }
        }

        /// <summary>
        /// A path segment cannot contain two consecutive parameters. They must be separated by a '/' or by a literal string.
        /// </summary>
        internal static string FormatTemplateRoute_CannotHaveConsecutiveParameters()
        {
            return GetString("TemplateRoute_CannotHaveConsecutiveParameters");
        }

        /// <summary>
        /// The route template separator character '/' cannot appear consecutively. It must be separated by either a parameter or a literal value.
        /// </summary>
        internal static string TemplateRoute_CannotHaveConsecutiveSeparators
        {
            get { return GetString("TemplateRoute_CannotHaveConsecutiveSeparators"); }
        }

        /// <summary>
        /// The route template separator character '/' cannot appear consecutively. It must be separated by either a parameter or a literal value.
        /// </summary>
        internal static string FormatTemplateRoute_CannotHaveConsecutiveSeparators()
        {
            return GetString("TemplateRoute_CannotHaveConsecutiveSeparators");
        }

        /// <summary>
        /// A catch-all parameter cannot be marked optional.
        /// </summary>
        internal static string TemplateRoute_CatchAllCannotBeOptional
        {
            get { return GetString("TemplateRoute_CatchAllCannotBeOptional"); }
        }

        /// <summary>
        /// A catch-all parameter cannot be marked optional.
        /// </summary>
        internal static string FormatTemplateRoute_CatchAllCannotBeOptional()
        {
            return GetString("TemplateRoute_CatchAllCannotBeOptional");
        }

        /// <summary>
        /// An optional parameter cannot have default value.
        /// </summary>
        internal static string TemplateRoute_OptionalCannotHaveDefaultValue
        {
            get { return GetString("TemplateRoute_OptionalCannotHaveDefaultValue"); }
        }

        /// <summary>
        /// An optional parameter cannot have default value.
        /// </summary>
        internal static string FormatTemplateRoute_OptionalCannotHaveDefaultValue()
        {
            return GetString("TemplateRoute_OptionalCannotHaveDefaultValue");
        }

        /// <summary>
        /// A catch-all parameter can only appear as the last segment of the route template.
        /// </summary>
        internal static string TemplateRoute_CatchAllMustBeLast
        {
            get { return GetString("TemplateRoute_CatchAllMustBeLast"); }
        }

        /// <summary>
        /// A catch-all parameter can only appear as the last segment of the route template.
        /// </summary>
        internal static string FormatTemplateRoute_CatchAllMustBeLast()
        {
            return GetString("TemplateRoute_CatchAllMustBeLast");
        }

        /// <summary>
        /// The literal section '{0}' is invalid. Literal sections cannot contain the '?' character.
        /// </summary>
        internal static string TemplateRoute_InvalidLiteral
        {
            get { return GetString("TemplateRoute_InvalidLiteral"); }
        }

        /// <summary>
        /// The literal section '{0}' is invalid. Literal sections cannot contain the '?' character.
        /// </summary>
        internal static string FormatTemplateRoute_InvalidLiteral(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TemplateRoute_InvalidLiteral"), p0);
        }

        /// <summary>
        /// The route parameter name '{0}' is invalid. Route parameter names must be non-empty and cannot contain these characters: '{{', '}}', '/'. The '?' character marks a parameter as optional, and can occur only at the end of the parameter. The '*' character marks a parameter as catch-all, and can occur only at the start of the parameter.
        /// </summary>
        internal static string TemplateRoute_InvalidParameterName
        {
            get { return GetString("TemplateRoute_InvalidParameterName"); }
        }

        /// <summary>
        /// The route parameter name '{0}' is invalid. Route parameter names must be non-empty and cannot contain these characters: '{{', '}}', '/'. The '?' character marks a parameter as optional, and can occur only at the end of the parameter. The '*' character marks a parameter as catch-all, and can occur only at the start of the parameter.
        /// </summary>
        internal static string FormatTemplateRoute_InvalidParameterName(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TemplateRoute_InvalidParameterName"), p0);
        }

        /// <summary>
        /// The route template cannot start with a '/' or '~' character.
        /// </summary>
        internal static string TemplateRoute_InvalidRouteTemplate
        {
            get { return GetString("TemplateRoute_InvalidRouteTemplate"); }
        }

        /// <summary>
        /// The route template cannot start with a '/' or '~' character.
        /// </summary>
        internal static string FormatTemplateRoute_InvalidRouteTemplate()
        {
            return GetString("TemplateRoute_InvalidRouteTemplate");
        }

        /// <summary>
        /// There is an incomplete parameter in the route template. Check that each '{' character has a matching '}' character.
        /// </summary>
        internal static string TemplateRoute_MismatchedParameter
        {
            get { return GetString("TemplateRoute_MismatchedParameter"); }
        }

        /// <summary>
        /// There is an incomplete parameter in the route template. Check that each '{' character has a matching '}' character.
        /// </summary>
        internal static string FormatTemplateRoute_MismatchedParameter()
        {
            return GetString("TemplateRoute_MismatchedParameter");
        }

        /// <summary>
        /// The route parameter name '{0}' appears more than one time in the route template.
        /// </summary>
        internal static string TemplateRoute_RepeatedParameter
        {
            get { return GetString("TemplateRoute_RepeatedParameter"); }
        }

        /// <summary>
        /// The route parameter name '{0}' appears more than one time in the route template.
        /// </summary>
        internal static string FormatTemplateRoute_RepeatedParameter(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TemplateRoute_RepeatedParameter"), p0);
        }

        /// <summary>
        /// The constraint entry '{0}' - '{1}' on the route '{2}' must have a string value or be of a type which implements '{3}'.
        /// </summary>
        internal static string RouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint
        {
            get { return GetString("RouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint"); }
        }

        /// <summary>
        /// The constraint entry '{0}' - '{1}' on the route '{2}' must have a string value or be of a type which implements '{3}'.
        /// </summary>
        internal static string FormatRouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint(object p0, object p1, object p2, object p3)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint"), p0, p1, p2, p3);
        }

        /// <summary>
        /// The constraint entry '{0}' - '{1}' on the route '{2}' could not be resolved by the constraint resolver of type '{3}'.
        /// </summary>
        internal static string RouteConstraintBuilder_CouldNotResolveConstraint
        {
            get { return GetString("RouteConstraintBuilder_CouldNotResolveConstraint"); }
        }

        /// <summary>
        /// The constraint entry '{0}' - '{1}' on the route '{2}' could not be resolved by the constraint resolver of type '{3}'.
        /// </summary>
        internal static string FormatRouteConstraintBuilder_CouldNotResolveConstraint(object p0, object p1, object p2, object p3)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RouteConstraintBuilder_CouldNotResolveConstraint"), p0, p1, p2, p3);
        }

        /// <summary>
        /// In a route parameter, '{' and '}' must be escaped with '{{' and '}}'
        /// </summary>
        internal static string TemplateRoute_UnescapedBrace
        {
            get { return GetString("TemplateRoute_UnescapedBrace"); }
        }

        /// <summary>
        /// In a route parameter, '{' and '}' must be escaped with '{{' and '}}'
        /// </summary>
        internal static string FormatTemplateRoute_UnescapedBrace()
        {
            return GetString("TemplateRoute_UnescapedBrace");
        }

        /// <summary>
        /// In the segment '{0}', the optional parameter '{1}' is preceded by an invalid segment '{2}'.  Only a period (.) can precede an optional parameter.
        /// </summary>
        internal static string TemplateRoute_OptionalParameterCanbBePrecededByPeriod
        {
            get { return GetString("TemplateRoute_OptionalParameterCanbBePrecededByPeriod"); }
        }

        /// <summary>
        /// In the segment '{0}', the optional parameter '{1}' is preceded by an invalid segment '{2}'.  Only a period (.) can precede an optional parameter.
        /// </summary>
        internal static string FormatTemplateRoute_OptionalParameterCanbBePrecededByPeriod(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TemplateRoute_OptionalParameterCanbBePrecededByPeriod"), p0, p1, p2);
        }

        /// <summary>
        /// An optional parameter must be at the end of the segment. In the segment '{0}', optional parameter '{1}' is followed by '{2}'.
        /// </summary>
        internal static string TemplateRoute_OptionalParameterHasTobeTheLast
        {
            get { return GetString("TemplateRoute_OptionalParameterHasTobeTheLast"); }
        }

        /// <summary>
        /// An optional parameter must be at the end of the segment. In the segment '{0}', optional parameter '{1}' is followed by '{2}'.
        /// </summary>
        internal static string FormatTemplateRoute_OptionalParameterHasTobeTheLast(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TemplateRoute_OptionalParameterHasTobeTheLast"), p0, p1, p2);
        }

        /// <summary>
        /// Two or more routes named '{0}' have different templates.
        /// </summary>
        internal static string AttributeRoute_DifferentLinkGenerationEntries_SameName
        {
            get { return GetString("AttributeRoute_DifferentLinkGenerationEntries_SameName"); }
        }

        /// <summary>
        /// Two or more routes named '{0}' have different templates.
        /// </summary>
        internal static string FormatAttributeRoute_DifferentLinkGenerationEntries_SameName(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AttributeRoute_DifferentLinkGenerationEntries_SameName"), p0);
        }

        /// <summary>
        /// Unable to find the required services. Please add all the required services by calling '{0}.{1}' inside the call to '{2}' in the application startup code.
        /// </summary>
        internal static string UnableToFindServices
        {
            get { return GetString("UnableToFindServices"); }
        }

        /// <summary>
        /// Unable to find the required services. Please add all the required services by calling '{0}.{1}' inside the call to '{2}' in the application startup code.
        /// </summary>
        internal static string FormatUnableToFindServices(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnableToFindServices"), p0, p1, p2);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
