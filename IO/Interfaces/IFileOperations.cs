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
        /// Parses incoming data into <see cref="A"/>
        /// </summary>
        /// <param name="content">The text to parse</param>
        List<A> Parse(string content);

        /// <summary>
        /// Saves data to file
        /// </summary>
        /// <param name="items">The list to export</param>
        /// <param name="path">The file path</param>
        void Save(List<A> items, string path = null);

        /// <summary>
        /// Converts list to data
        /// </summary>
        /// <param name="items">The list to convert</param>
        /// <returns>The stringified list</returns>
        string ConvertData(List<A> items);
    }
}
