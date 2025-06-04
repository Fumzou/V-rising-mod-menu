using System.Threading.Tasks;
using VRisingBephinex.utils;

namespace VRisingBephinex.helpers
{
    /// <summary>
    /// Helper that simulates a left mouse click followed by a key press on 'F'
    /// two seconds later.
    /// </summary>
    public static class AutoFHelper
    {
        /// <summary>
        /// Performs a left click and, after a short delay, presses the F key.
        /// </summary>
        public static async void LeftClickThenPressF()
        {
            InputSimulator.LeftClick();
            await Task.Delay(2000);
            InputSimulator.KeyboardPress(0x46); // 'F' key
        }
    }
}
