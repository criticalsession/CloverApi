namespace CloverApi.Api.Models;

/// <summary>
/// Comprehensive list of all threads grouped by page number
/// </summary>
public class ThreadPage
{
    /// <summary>
    /// The page number that the threads are on
    /// </summary>
    public int Page { get; set; }

    /// <summary>
    /// The array of thread summary objects
    /// </summary>
    public ThreadSummary[] Threads { get; set; }
}