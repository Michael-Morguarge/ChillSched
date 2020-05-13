namespace Shared.Interface
{
    /// <summary>
    /// An interface for connecting controls
    /// </summary>
    public interface IControl
    {
        /// <summary>
        /// The control id
        /// </summary>
        /// <returns>The id of the T control</returns>
        string GetId();
    }
}
