using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtaxInvoice
{
    static class Program
    {
        /*
         * การส่ง parameter จากโปรแกรมของ Ada ไปเรียกโปรแกรม E_TAX

            1. รหัสสาขา

            2. ชื่อ POS Server (เครื่อง POSBack)

            3.ชื่อฐานข้อมูล

            4.Login สำหรับ Access ฐานข้อมูลเครื่อง POS Server

            5. Password สำหรับ Access ฐานข้อมูลเครื่อง POS Server

            6.รหัสผู้ใช้ ที่เปิดใช้งาน

            7.ชื่อผู้ใช้ ที่เปิดใช้งาน

            8.โหมดการทำงาน (1 = บิลเงินสด/ใบกำกับภาษี(Full Tax Invoice), 2 = ใบลดหนี้/รับคืนสินค้า (Credit Note) )

            ใช้ | เป็นตัวคั่น parameter

            ตัวอย่าง

            0730|0730POSBack|SFMPOS|sa|p@ssw0rd|12345|ผู้จัดการสาขา|1
                    
        ความหมายข้อมูล

            1. รหัสสาขา = 0730

            2. ชื่อ POS Server (เครื่อง POSBack) = 0730POSBack

            3.ชื่อฐานข้อมูล = SFMPOS

            4.Login สำหรับ Access ฐานข้อมูลเครื่อง POS Server = sa

            5. Password สำหรับ Access ฐานข้อมูลเครื่อง POS Server = p@ssw0rd

            6.รหัสผู้ใช้ ที่เปิดใช้งาน = 12345

            7.ชื่อผู้ใช้ ที่เปิดใช้งาน = ผู้จัดการสาขา

            8.โหมดการทำงาน : 1 = บิลเงินสด/ใบกำกับภาษี(Full Tax Invoice)

            ตัวอย่างการเรียกโปรแกรม E-TAX

            shell "c:\program file\AdaPos3.0Hpm\AdaPos\eTax.exe" "'0730|0730POSBack|SFMPOS|sa|p@ssw0rd|12345|ผู้จัดการสาขา|1"

         */
        public static string globalBranchNumber = "0730";
        public static string globalPOSServer = "0730POSBack";
        public static string globalDBName = "SFMPOS";
        public static string globalPOSServerLogin = "sa";
        public static string globalPOSServerPassword = "12345";
        public static string globalStartUserPassword = "12345";
        public static string globalStartUserName = "x10-tester";//"ผู้จัดการสาขา";
        public static int globalProgramMode = 1;

        public static string testargument = "Meng";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string recieve_argument = args.Length > 0 ? args[0] : null;   //  extract form name from command line parameter
            if (recieve_argument != null)
            {
                testargument = recieve_argument;
                string[] each_rec = recieve_argument.Split('|');
                if (each_rec.Length != 8)
                {
                    MessageHelper.ShowError("argument: \"" + recieve_argument + "\" ไม่เท่ากับ 8 ตัว");
                    return;
                }
                globalBranchNumber = each_rec[0];
                globalPOSServer = each_rec[1];
                globalDBName = each_rec[2];
                globalPOSServerLogin = each_rec[3];
                globalPOSServerPassword = each_rec[4];
                globalStartUserPassword = each_rec[5];
                globalStartUserName = each_rec[6];
                globalProgramMode = int.Parse(each_rec[7]);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());    //  use factory method to instantiate form you need to open
        }
    }
}
