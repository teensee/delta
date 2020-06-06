namespace delta.Core
{
    /// <summary>
    /// Converts <see cref="IconType"/> to Material design string
    /// </summary>
    public static class IconTypeExtensions
    {
        /// <summary>
        /// Converts <see cref="IconType"/> to Material design string
        /// </summary>
        /// <param name="type">The type to convert</param>
        /// <returns></returns>
        public static string ToFontAwesome(this IconType type)
        {
            switch (type)
            {
                case IconType.Picture:
                    return "\uf21f";
                case IconType.File:
                    return "\uf214";
                default:
                    return null;
            }
        }
    }
}
