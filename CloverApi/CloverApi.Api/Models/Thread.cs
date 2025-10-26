namespace CloverApi.Api.Models;

/// <summary>A representation of a single OP and all the replies, which form a thread</summary>
public class Thread
{
    /// <summary>OP and all replies in the thread.</summary>
    public ThreadPost[] Posts { get; set; }
}