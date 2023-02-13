namespace Xtra.Models.Settings;

public class ServiceBusSettings
{
    public ServiceBusPlatform Platform { get; set; }
    public string? ConnectionString { get; set; }
    public string? InputQueueName { get; set; }


    /// <summary>
    /// Configures the number of workers. If thread-based workers are used, this is the number of threads that will be created.
    /// </summary>
    /// <remarks>
    /// Guidance on reasonable settings:
    /// <list type="bullet">
    /// <item>
    ///     <term>Work is predominantly asynchronous</term>
    ///     <description>You can use a few worker threads and a fairly high parallelism. E.g. <code>NumberOfWorkers = 2; MaxParallelism = 20;</code></description>
    /// </item>
    /// <item>
    ///     <term>Work is fast and synchronous</term>
    ///     <description>You can use a few worker threads and a matching parallelism (although setting parallelism higher will not affect anything in this case). E.g. <code>NumberOfWorkers = 5; MaxParallelism = 5;</code></description>
    /// </item>
    /// <item>
    ///     <term>Work is slow and synchronous</term>
    ///     <description>You can use more worker threads and a matching parallelism. E.g. <code>NumberOfWorkers = 20; MaxParallelism = 20;</code></description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <value>
    /// This number should be less than or equal to <see cref="MaxParallelism"/>. Setting to 0 results in no workers, effectively
    /// disabling use of the service-bus.
    /// The default value of <see langword="null"/> indicates to use whatever the built-in default is (with Rebus this would be 1).
    /// </value>
    public int? NumberOfWorkers { get; set; } = null;


    /// <summary>
    /// Configures the total degree of parallelism allowed. This will be the maximum number of parallel, potentially asynchronous,
    /// operations that can be active, regardless of the number of workers.
    /// </summary>
    /// <remarks>
    /// Guidance on reasonable settings:
    /// <list type="bullet">
    /// <item>
    ///     <term>Work is predominantly asynchronous</term>
    ///     <description>You can use a few worker threads and a fairly high parallelism. E.g. <code>NumberOfWorkers = 2; MaxParallelism = 20;</code></description>
    /// </item>
    /// <item>
    ///     <term>Work is fast and synchronous</term>
    ///     <description>You can use a few worker threads and a matching parallelism (although setting parallelism higher will not affect anything in this case). E.g. <code>NumberOfWorkers = 5; MaxParallelism = 5;</code></description>
    /// </item>
    /// <item>
    ///     <term>Work is slow and synchronous</term>
    ///     <description>You can use more worker threads and a matching parallelism. E.g. <code>NumberOfWorkers = 20; MaxParallelism = 20;</code></description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <value>
    /// This number should be a positive integer, greater than 0.
    /// The default value of <see langword="null"/> indicates to use whatever the built-in default is (with Rebus this would be 5).
    /// </value>
    public int? MaxParallelism { get; set; } = null;
}