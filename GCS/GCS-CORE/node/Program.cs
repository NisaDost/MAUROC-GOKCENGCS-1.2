using Rcl;
using Rcl.Logging;

namespace node
{
    class Program
    {
        public static void Main(string[] args)
        {
            using var context = new RclContext(args);
            using var node = context.CreateNode("my_ros2_node");

            // Setup subscriptions, publishers, etc. here if needed.
            node.Logger.LogInformation($"Hello ROS 2 {RosEnvironment.Distribution}!");

        }
    }
}
