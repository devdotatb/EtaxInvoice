using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtaxInvoice
{
    internal static class Program
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
        public static string globalStartUserName = "ผู้จัดการสาขา";
        public static int globalProgramMode = 1;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
