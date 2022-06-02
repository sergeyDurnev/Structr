namespace Structr.Validation
{
    /// <summary>
    /// Specifies the level of <see cref="ValidationFailure"/>.
    /// </summary>
    public enum ValidationFailureLevel
    {
        /// <summary>
        /// Critical failure.
        /// </summary>
        Error,

        /// <summary>
        /// No critical failure.
        /// </summary>
        Warning,

        /// <summary>
        /// Just for information.
        /// </summary>
        Info
    }
}
