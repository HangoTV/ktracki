
namespace ktracki;

public class GameManager
{
    //them nhan vat
    public List<Character> Characters = new List<Character>();

    public void AddCharacter(Character character)
    {
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");
        Console.WriteLine("Chon loai nhan vat: ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap Name: ");
        string name = Console.ReadLine();
        if (choice == 1)
        {
            Console.WriteLine("Nhap AttackDamage:  ");
            int attackDamage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Weapon:  ");
            string weapon = Console.ReadLine();
            Warrior w = new Warrior(id, name, attackDamage, weapon);
            Characters.Add(w);
            Console.WriteLine("da them nhan vat kieu Warrior");
        }
        else if (choice == 2)
        {
            Console.WriteLine("Nhap Mana:  ");
            int mana = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Magic Damage:  ");
            int magicDamage = Convert.ToInt32(Console.ReadLine());
            Mage m = new Mage(id, name, magicDamage, mana);
            Characters.Add(m);
            Console.WriteLine("da them nhan vat kieu Mana");
        }
        else
        {
            Console.WriteLine("ko hop le");
        }
    }

    //hien thi danh sach
        public void HienThiDanhSach()
        {
            foreach (Character c in Characters)
            {
                c.Display();
            }
        }
//tim id
        public void TimTheoId()
        {
            Console.WriteLine("Nhap ID: ");
            int  id = Convert.ToInt32(Console.ReadLine());
            foreach (Character c in Characters)
            {
                if (c.Id == id)
                {
                    Console.WriteLine("tim thay id:");
                    c.Display();
                }
                else Console.WriteLine("ko tim thay id ");
            }
        }
        //sap sep nhan vat theo suc manh giam gian
       public  int LaySucManh()
        {
            foreach (Character c in Characters)
            {
                if (c is Warrior w)
                {
                    return w.Power();
                }
                else if (c is Mage m)
                {
                    return m.PowerMagic();
                }
            }

            return 0;
        }

        public void SapXepGiamDan()
        {
            
        }

        public void TaiFile()
        {
            
        }

        public void LuuFile()
        {
            
        }

        public void AddCharacter()
        {
            throw new NotImplementedException();
        }
}