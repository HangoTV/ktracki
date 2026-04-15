
namespace Console
{
    class Program
    {
        const int MAX_FILES = 10;
        static string[] fileNames = new string[MAX_FILES];
        static string[] dinhdang = new string[MAX_FILES];
        static int count = 0;

         static string[] cacdinhdang= 
        {
            ".mp4",
            ".avi",
            ".mp3",
            ".wav",
        };

        static Random random = new Random();

        void Main(string[] args)
        {
            while (true)
            {
                System.Console.Clear();
                System.Console.WriteLine("===HỆ THỐNG QUẢN LÝ FILE MEDIA===");
                System.Console.WriteLine("1.Thêm file vào hàng đơị");
                System.Console.WriteLine("2.Xem danh sách hàng đợi");
                System.Console.WriteLine("3.Bắt đầu xử lý (Nén & Chuyển đổi)");
                System.Console.WriteLine("4.Thoát chương trình Chọn chức năng(1-4):_");
                System.Console.Write("Chọn chức năng (1-4): ");
                string input = System.Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddFile();
                        break;
                    case "2":
                        ShowFiles();
                        break;
                    case "3":
                        System.Console.WriteLine("Đang chuyển đổi...");
                        break;
                    case "4":
                        System.Console.WriteLine("Đang thoát khỏi chuương trình...");
                        return;
                    default:
                        System.Console.WriteLine("Nhập sai giá trị!!!!");
                        System.Console.WriteLine("Vui lòng nhập lại từ 1 đến 4:_");
                        break;
                }

            }
        }

        bool CheckValidExtension(string ext)
        {
            for (int i = 0; i < fileNames.Length; i++)
            {
                if (fileNames[i] == ext) return true;

            }

            return false;
        }

        double EstimateSize(double currentSize)
        {
            int percent = random.Next(10, 40);
            double newSize = currentSize * (100 - percent) / 100;
            return newSize;
        }

        void ShowFiles()
        {
            for (int i = 0; i < fileNames.Length; i++)
                System.Console.WriteLine($"{i++}. {fileNames[i]}-{i++}.{dinhdang[i]}");
        }


        static void AddFile()
        {
            if (count > MAX_FILES)
            {
                System.Console.WriteLine("he thong full");
                return;
            }

            System.Console.Write("Input name file: ");
            string fileName = System.Console.ReadLine();
            System.Console.Write("Input name dinh dang: ");
            string dinhdangName = System.Console.ReadLine();
        }
    }
}
