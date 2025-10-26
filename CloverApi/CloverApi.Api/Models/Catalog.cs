namespace CloverApi.Api.Models;

/// <summary>Comprehensive list of all threads+attributes on a board. Every thread is grouped by page.</summary>
public class Catalog
{
    /// <summary>Page number.</summary>
    public int Page { get; set; }
    
    /// <summary>
    /// List of threads on the page.
    /// </summary>
    public CatalogThread[] Threads { get; set; }
}