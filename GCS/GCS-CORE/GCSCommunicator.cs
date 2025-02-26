using System;
using Rcl;
using Rcl.Logging;
using Rosidl.Messages.StdMsgs;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GCS_CORE
{
    public class GCSCommunicator
    {
        private readonly Node _node;
        private readonly IPublisher<Int32> _publisher;
        private readonly ISubscription<Int32> _subscriber;

        public GCSCommunicator()
        {
            // Initialize RCL
            RclContext.Init();
            _node = new Node("gcs_node");

            // Publisher
            _publisher = _node.CreatePublisher<Int32>("gcs/target_uav_id");

            // Subscriber
            _subscriber = _node.CreateSubscription<Int32>("gcs/target_uav_id", msg =>
            {
                Console.WriteLine($"[Subscriber] Received UAV ID: {msg.Data}");
            });

            Console.WriteLine("[GCS] Publisher & Subscriber initialized.");
        }

        public void PublishUAVId(int uavId)
        {
            _publisher.Publish(new Int32 { Data = uavId });
            Console.WriteLine($"[Publisher] Sent UAV ID: {uavId}");
        }

        public async Task SpinAsync()
        {
            Console.WriteLine("[GCS] Spinning ROS 2 Node...");
            await _node.SpinAsync();
        }

        public void Dispose()
        {
            _publisher.Dispose();
            _subscriber.Dispose();
            _node.Dispose();
        }
    }
}
