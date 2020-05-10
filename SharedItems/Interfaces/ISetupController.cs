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
}
