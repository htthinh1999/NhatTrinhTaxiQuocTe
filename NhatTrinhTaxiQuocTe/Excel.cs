using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace NhatTrinhTaxiQuocTe
{
    class Excel
    {
        private String path = "";
        private _Application excel = new _Excel.Application();
        private Workbook wb;
        private Worksheet ws;
        private int lineENDOfFile;
        private int indexStart = 5;
        private int indexEnd;
        private int daySum;
        private ProgressBar progressBar;

        public Excel(){}

        public Excel(String path, int Sheet, int lineENDOfFile, ProgressBar progressBar)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
            this.lineENDOfFile = lineENDOfFile;
            this.progressBar = progressBar;
        }

        public int getIndexStart()
        {
            return indexStart;
        }

        private string ReadCell(int i, int j)
        {
            if (ws.Cells[i, j].Value2 != null)
            {
                return ws.Cells[i, j].Value2;
            }
            else
                return "";
        }

        private void WriteToCell(int i, int j, string s)
        {
            ws.Cells[i, j].Value2 = s;
        }

        private void Save()
        {
            wb.Save();
        }

        private void SaveAs(string path)
        {
            wb.SaveAs(path);
            wb.Close();
        }

        public void closeExcel()
        {
            wb.Close();
        }

        public void AutoCopyPatse()
        {
            bool notEnough = true;
            int[] daysOfMonth = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            indexStart = 5;
            indexEnd = 0;
            daySum = 0;

            for (int month = 1; month <= 12; month++)
            {
                // Viết vào ô tháng
                WriteToCell(2, 2, month.ToString());

                daySum += daysOfMonth[month - 1];

                for (int day = 1; day <= daysOfMonth[month]; day++)
                {
                    // Viết vào ô ngày
                    WriteToCell(2, 6, day.ToString());

                    //Console.WriteLine("day = " + day);
                    string strDate = "";
                    do
                    {
                        indexEnd += 5;
                        if (indexEnd > lineENDOfFile)
                        {
                            break;
                        }
                        strDate = Convert.ToString(ws.Cells[indexEnd, 1].Value2);
                        //Console.WriteLine(strDate);
                    } while (Convert.ToInt32(strDate) < (42370 + day + daySum));

                    //Console.WriteLine("indexStart = " + indexStart + ", indexEnd = " + indexEnd);

                    notEnough = !notEnough;

                    for (int i = indexStart; i < indexEnd; i += 3)
                    {

                        if (indexStart < lineENDOfFile)
                        {
                            progressBar.Value = indexStart;
                        }

                        string doanhThu = Convert.ToString(ws.Cells[1, 7].Value2);

                        if (notEnough)
                        {
                            int viTriTien = doanhThu.IndexOf("THIẾU");
                            if (viTriTien != -1)
                            {
                                viTriTien += 7;
                                int tien = Convert.ToInt32(doanhThu.Substring(viTriTien, doanhThu.Length - viTriTien));
                                if (tien < 30000)
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (doanhThu.IndexOf("THỪA") != -1)
                                break;
                        }

                        String strValue1 = "";
                        String strValue2 = "";
                        try
                        {
                            strValue1 = ReadCell(i, 3);
                        }
                        catch (Exception e)
                        {
                        }

                        try
                        {
                            strValue2 = ReadCell(i + 1, 3);
                        }
                        catch (Exception e)
                        {
                        }


                        double hour = 0;
                        try
                        {
                            hour = Convert.ToDouble(ws.Cells[i, 2].Value2); //// >0.21: Sau 5h, <0.87: Trước 21h
                        }
                        catch (Exception e)
                        {

                        }

                        if (!strValue1.Equals("Chạy lại") && !strValue1.Equals("Dừng") && !strValue1.Equals("Tắt máy") && !strValue1.Equals("Mở máy")
                               && !strValue2.Equals("Chạy lại") && !strValue2.Equals("Dừng") && !strValue2.Equals("Tắt máy") && !strValue2.Equals("Mở máy")
                                && hour > 0.21 && hour < 0.87)
                        {
                            string strBefore = "";
                            try
                            {
                                strBefore = ReadCell(i - 1, 3);
                            }
                            catch (Exception ex)
                            {

                            }
                            if (strBefore.Equals("Dừng"))
                            {
                                continue;
                            }
                            //Console.WriteLine("Vao" + i);
                            //Console.WriteLine("Giờ: " + hour);  ///////// Hiển thị giá trị giờ > 0.21: Sau 5h, 0.87: Trước 21h
                            WriteToCell(i, 6, "=IF(C" + i + "=\"Chốt ca\",0,IF(OR(C" + i + "=\"Chạy lại\",C" + i + "=\"Dừng\",C" + i + "=\"Đổi đồng hồ\",C" + i + "=\"Hết quá tốc độ\",C" + i + "=\"km rỗng\",C" + i + "=\"Mở máy\",C" + i + "=\"Quá tốc độ\",C" + i + "=\"tắt máy\"),F" + (i - 1) + ",IF(AND(C" + i + ">0)*(F" + (i - 1) + "=0),6000,IF(AND(ISTEXT(C" + i + "))*(F" + (i - 1) + ">0),F" + (i - 1) + "+12300,ROUND(F" + (i - 1) + "+C" + i + "*12300,-3)))))");
                            WriteToCell(i + 1, 6, "=IF(C" + (i + 1) + "=\"Chốt ca\",0,IF(OR(C" + (i + 1) + "=\"Chạy lại\",C" + (i + 1) + "=\"Dừng\",C" + (i + 1) + "=\"Đổi đồng hồ\",C" + (i + 1) + "=\"Hết quá tốc độ\",C" + (i + 1) + "=\"km rỗng\",C" + (i + 1) + "=\"Mở máy\",C" + (i + 1) + "=\"Quá tốc độ\",C" + (i + 1) + "=\"tắt máy\"),F" + i + ",IF(AND(C" + (i + 1) + ">0)*(F" + i + "=0),6000,IF(AND(ISTEXT(C" + (i + 1) + "))*(F" + i + ">0),F" + i + "+12300,ROUND(F" + i + "+C" + (i + 1) + "*12300,-3)))))");

                        }
                    }

                    indexStart = indexEnd;
                }
            }

            Save();
            SaveAs(path);
            //SaveAs("C:\\Users\\MON MINA\\Downloads\\402.xlsx");
            //Console.WriteLine("Xong");

            //Console.ReadLine();
        }


    }
}
