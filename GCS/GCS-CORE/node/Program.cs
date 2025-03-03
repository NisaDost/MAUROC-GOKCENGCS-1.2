using Rcl;
using Rcl.Logging;

namespace node
{
    class Program
    {
        public static async void Main(string[] args)
        {
            await using var context = new RclContext(args);
            using var node = context.CreateNode("my_ros2_node");
            var sub = node.CreateSubscription<Std.String>(String.Empty);

            node.Logger.LogInformation($"Hello ROS 2 {RosEnvironment.Distribution}!");
        }
    }

}