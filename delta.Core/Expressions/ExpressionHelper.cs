﻿using System;
using System.Linq.Expressions;
using System.Reflection;

namespace delta.Core
{
    /// <summary>
    /// A helper for expressions
    /// </summary>
    public static class ExpressionHelper
    {
        /// <summary>
        /// Compiles an expression and get the function return value
        /// </summary>
        /// <typeparam name="T">The unknown type of return value</typeparam>
        /// <param name="lambda">The expression to compile</param>
        /// <returns></returns>
        public static T GetPropertyValue<T>(this Expression<Func<T>> lambda)
        {
            return lambda.Compile().Invoke();
        }

        /// <summary>
        /// Sets the underline properties value to the given value
        /// from an expression that contains the property
        /// </summary>
        /// <typeparam name="T">The type of value to set</typeparam>
        /// <param name="lambda">The expression</param>
        /// <param name="value"> The value to set the property to</param>
        public static void SetPropertyValue<T>(this Expression<Func<T>> lambda, T value)
        {
            //Converts a lambda '() => some.Property', to 'some.Property'
            var expression = (lambda as LambdaExpression).Body as MemberExpression;

            //Get the property information so we can set it
            var propInfo = (PropertyInfo)expression.Member;
            var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();

            propInfo.SetValue(target, value);
        }
    }
}
