using Rcl;
using Rcl.Graph;
using Rcl.Logging;
using Rcl.Parameters;
using Rosidl.Messages.Std;
using System;
using System.Threading.Tasks;

namespace GCS_CORE
{
    public class TargetUavPublisher : IDisposable
    {
        private readonly RosNode _node;
        private readonly IPublisher<Int32> _publisher;

        public TargetUavPublisher()
        {
            // ROS2 düðümü oluþtur
            _node = new RosNode("gcs_target_uav_publisher");

            // Publisher oluþtur, /gcs/target_uav_id topic'ini yayýnlayacak
            _publisher = _node.CreatePublisher<Int32>("/gcs/target_uav_id");

            Console.WriteLine("Target UAV ID Publisher started.");
        }

        public void Publish(int uavId)
        {
            var msg = new Int32 { Data = uavId };
            _publisher.Publish(msg);
            Console.WriteLine($"Published UAV ID: {uavId}");
        }

        public void Dispose()
        {
            _publisher.Dispose();
            _node.Dispose();
        }
    }
}
