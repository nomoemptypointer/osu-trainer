using System.Drawing.Text;
using System.Globalization;
using System.Runtime.InteropServices;

namespace osu_trainer
{
    public static class Program
    {
#if DEBUG
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();
#endif

        public static PrivateFontCollection FontCollection { get; } = new PrivateFontCollection();

        [STAThread]
        public static void Main()
        {
#if DEBUG
            AllocConsole();
            Console.WriteLine("+ AllocConsole");
#endif

            AddFont(FontCollection, Resources.Comfortaa_Bold);
            Application.CurrentCulture = new CultureInfo("en-US", false);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void AddFont(PrivateFontCollection collection, byte[] bytes)
        {
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            IntPtr pointer = handle.AddrOfPinnedObject();
            try
            {
                collection.AddMemoryFont(pointer, bytes.Length);
            }
            finally
            {
                handle.Free();
            }
        }
    }
}