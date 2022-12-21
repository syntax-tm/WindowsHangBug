using System;
using System.ComponentModel;
using System.Reflection;

namespace WindowsCrashDemo.Common
{
    public static class AttributeExtensions
    {
        
        /// <summary>
        /// Gets the <c>Description</c> attribute for the source <see cref="Enum"/>.
        /// </summary>
        /// <seealso cref="DescriptionAttribute"/>
        /// <seealso cref="DisplayNameAttribute"/>
        public static string GetDescription(this Enum source)
        {
            var fi = source.GetType().GetField(source.ToString());
            try
            {
                //  check for the [Description] attribute on the field
                var description = fi.GetCustomAttribute<DescriptionAttribute>();
                if (description != null)
                {
                    return description.Description;
                }
                
                //  check for the [DisplayName] attribute on the field
                var displayName = fi.GetCustomAttribute<DisplayNameAttribute>();
                if (displayName != null)
                {
                    return displayName.DisplayName;
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException($"An error occurred getting the description of {nameof(source)} {fi.Name}. {e.Message}", e);
            }

            return fi.Name;
        }

    }
}
