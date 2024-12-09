using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantImaharaRobotControls
{
    public static class HandGesture
    {
        public static bool ThumbUp(Axis axis, ILogger logger)
        {
            logger.LogInformation("Thumb up gesture. Axis: {Axis}", axis);

            // Code to make robot perform gesture

            return true;
        }
    }

    public enum Axis { Left, Right }
}
