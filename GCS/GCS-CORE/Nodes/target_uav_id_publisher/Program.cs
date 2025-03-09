using Rcl;
using Rcl.Logging;
using target_uav_id_publisher; // Ensure your custom message namespace is used

await using var context = new RclContext(args);
using var node = context.CreateNode("gcs_target_uav_id_publisher");
using var pub = node.CreatePublisher<target_uav_id_publisher.Std.UInt32>("gcs/target_uav_id"); //idk

node.Logger.LogInformation($"TARGET UAV ID PUBLISHER RUNNING!");

// Simulate publishing target UAV IDs every 3 seconds
int targetId = 1001; // Simulated target UAV ID

async Task PublishTargetIds()
{
    while (true) // Keep running indefinitely
    {
        var message = new target_uav_id_publisher.Std.UInt32 { Data = (uint)targetId };
        pub.Publish(message);

        node.Logger.LogInformation($"Published Target UAV ID: {targetId}");

        // Simulate receiving a new ID every 3 seconds
        await Task.Delay(3000);
        targetId++; // Increment the target ID
    }
}
// Start the publishing loop asynchronously
_ = PublishTargetIds();

// Keep the program running
await Task.Delay(-1); // Prevents the program from exiting
