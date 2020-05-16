using System.Collections.Generic;

namespace FileOperations.Interfaces
{
    /// <summary>
    /// File operations
    /// </summary>
    /// <typeparam name="A">Model for storage</typeparam>
    public interface IFileOperations<A>
    {
        /// <summary>
        /// Loads data from file
        /// </summary>
        /// <param name="path">The file path</param>
        /// <returns>Whether the data was fully uploaded</returns>
        List<A> Load(string path = null);

        /// <summary>
        /// Saves data to file
        /// </summary>
        /// <param name="items">The list to export</param>
        /// <param name="path">The file path</param>
        void Save(List<A> items, string path = null);
    }
}
