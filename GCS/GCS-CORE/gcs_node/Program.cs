using Rcl;
using Rcl.Logging;

namespace GCS_Node
{
    class Program
    {
        public static async Task Main(string[] args)
        {

            var Node = new GCSNode();

            await Node.Run(args);


        }
    }

}