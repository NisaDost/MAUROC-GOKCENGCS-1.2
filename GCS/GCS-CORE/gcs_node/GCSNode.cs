using Rcl;
using Rcl.Logging;

namespace GCS_Node
{
    class GCSNode
    {
        public async Task Run(string[] args)
        {

            await using var context = new RclContext(args);
            using var node = context.CreateNode("gcs_node");
            using var pub = node.CreatePublisher<Std.String>("/chatter");

            node.Logger.LogInformation($"TARGET UAV ID PUBLISHER RUNNING!");

            while (true)
            {
                var message = new Std.String { Data = "Hello deneme" };
                pub.Publish(message);

                await Task.Delay(3000);

            }
        }
    }

}