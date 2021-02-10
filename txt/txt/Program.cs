using System;
using System.IO;
using txt.FileManager;

namespace txt
{
    class Program
    {
        static void Main()
        {
            string path = "TestDirectory";
            string moveToPath = "../../TestDirectory";

            FileManagerClass newManager =
                new FileManagerClass();

           //  newManager.CreateAFile(path);
            // newManager.MoveFile(path, moveToPath);

            newManager.CreateDirectory(path);
            newManager.MoveDirectory(path, moveToPath);
        }
    }
}
