namespace Shared.Interface
{
    /// <summary>
    /// The setup
    /// </summary>
    /// <typeparam name="T">The specified type</typeparam>
    public interface ISetupController <T>
    {
        /// <summary>
        /// The control
        /// </summary>
        /// <returns>The T control</returns>
        T GetControl();
    }

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
