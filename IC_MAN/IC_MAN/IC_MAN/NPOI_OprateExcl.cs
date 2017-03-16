using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI;
using NPOI.HPSF;
using NPOI.HSSF;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.POIFS;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;
using NPOI.Util;
using NPOI.SS;
using NPOI.DDF;
using NPOI.SS.Util;
using System.Collections;
using System.Text.RegularExpressions;
using NPOI.XSSF;
using NPOI.XSSF.UserModel;
using System.IO;
using System.Windows.Forms;
using System.Windows;
using System.Data;
using NPOI.POIFS.FileSystem;
using System.Drawing;
namespace IC_MAN
{
    class NPOI_OprateExcl
    {
        /// <summary>
        /// 读取excl文件数据 读取实时信息表单
        /// </summary>
        /// <param name="filePath"></param>
        /// 读取文件绝对路径包含文件名和格式
        /// <param name="dgv"></param>
        /// 需要更新到窗口datagridview控件
        /// <param name="sheetnum"></param>
        /// 需要读取的表单号 从0开始
        /// <param name="userID"></param>
        /// 需要查询的键值
        public static void ReadFromExclFile(string filePath,int sheetnum, DataGridView dgv,string userID)
        {
            IWorkbook wk = null;
            int j = 0;
            dgv.Rows.Clear();
            string extension = System.IO.Path.GetExtension(filePath);
            try
            {
                FileStream fs = File.OpenRead(filePath);
                if (extension.Equals(".xls"))
                {
                    //把xls文件中的数据写入wk中
                    wk = new HSSFWorkbook(fs);
                }
                else
                {
                    //把xlsx文件中的数据写入wk中
                    wk = new XSSFWorkbook(fs);
                }
                fs.Close();
                //读取当前表数据
                ISheet sheet = wk.GetSheetAt(sheetnum);

                IRow row = sheet.GetRow(0);  //读取当前行数据
                //LastRowNum 是当前表的总行数-1（注意）
                // int offset = 0;
                for (int i = 1; i <= sheet.LastRowNum; i++)
                {
                    row = sheet.GetRow(i);  //读取当前行数据
                    if (row != null)
                    {
                        if (userID == "")
                        {
                            string value = row.GetCell(0).ToString();
                            dgv.Rows.Add();
                            dgv.Rows[i - 1].Cells[0].Value = row.GetCell(1).ToString();
                            dgv.Rows[i - 1].Cells[1].Value = row.GetCell(2).ToString();
                            dgv.Rows[i - 1].Cells[2].Value = row.GetCell(16).ToString();
                            dgv.Rows[i - 1].Cells[3].Value = row.GetCell(15).ToString();
                            dgv.Rows[i - 1].Cells[4].Value = row.GetCell(13).ToString();
                            DataGridViewButtonCell vcell = (DataGridViewButtonCell)dgv.Rows[i - 1].Cells[5];
                            if (dgv.Rows[i - 1].Cells[4].Value.ToString() == "FALSE")
                            {
                                vcell.Value = "挂失";
                                dgv.Rows[i - 1].DefaultCellStyle.BackColor = Color.White;
                            }
                            else if (dgv.Rows[i - 1].Cells[4].Value.ToString() == "TRUE")
                            {
                                vcell.Value = "已挂失";
                                dgv.Rows[i - 1].DefaultCellStyle.BackColor = Color.OrangeRed;
                            }
                        }
                        else if(row.GetCell(1).ToString()==userID)
                        {
                            string value = row.GetCell(0).ToString();
                            dgv.Rows.Add();
                            dgv.Rows[j].Cells[0].Value = row.GetCell(1).ToString();
                            dgv.Rows[j].Cells[1].Value = row.GetCell(2).ToString();
                            dgv.Rows[j].Cells[2].Value = row.GetCell(16).ToString();
                            dgv.Rows[j].Cells[3].Value = row.GetCell(15).ToString();
                            dgv.Rows[j].Cells[4].Value = row.GetCell(13).ToString();
                            DataGridViewButtonCell vcell = (DataGridViewButtonCell)dgv.Rows[j].Cells[5];
                            if (dgv.Rows[j].Cells[4].Value.ToString() == "FALSE")
                            {
                                vcell.Value = "挂失";
                                dgv.Rows[j].DefaultCellStyle.BackColor = Color.White;
                            }
                            else if (dgv.Rows[j].Cells[4].Value.ToString() == "TRUE")
                            {
                                vcell.Value = "已挂失";
                                dgv.Rows[j].DefaultCellStyle.BackColor = Color.OrangeRed;
                            }
                            j++;
                        }

                    }
                }
            }
            catch (Exception e)
            {
                //只在Debug模式下才输出
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// 读取excl文件数据 读取写卡记录表单
        /// </summary>
        /// <param name="filePath"></param>
        /// 读取文件绝对路径包含文件名和格式
        /// <param name="dgv"></param>
        /// 需要更新到窗口datagridview控件
        /// <param name="sheetnum"></param>
        /// 需要读取的表单号 从0开始
        public static void ReadExcelFile(string filePath,int sheetnum,DataGridView dgv,string searchData,int searchIndex)
        {            
            IWorkbook wk = null;
            int r = 0;
            dgv.Rows.Clear();
            string extension = System.IO.Path.GetExtension(filePath);
            try
            {
                FileStream fs = File.OpenRead(filePath);
                if (extension.Equals(".xls"))
                {
                    //把xls文件中的数据写入wk中
                    wk = new HSSFWorkbook(fs);
                }
                else
                {
                    //把xlsx文件中的数据写入wk中
                    wk = new XSSFWorkbook(fs);
                }
                fs.Close();
                //读取当前表数据
                ISheet sheet = wk.GetSheetAt(sheetnum);

                IRow row = sheet.GetRow(0);  //读取当前行数据
                //LastRowNum 是当前表的总行数-1（注意）
               // int offset = 0;
                
                for (int i = 1; i <= sheet.LastRowNum; i++)
                {
                    row = sheet.GetRow(i);  //读取当前行数据
                    if (row != null)
                    {
                        if (searchData == "")
                        { 
                            //string value = row.GetCell(0).ToString();
                            dgv.Rows.Add();
                            dgv.Rows[i-1].Cells[0].Value = row.GetCell(1).ToString();
                            dgv.Rows[i - 1].Cells[1].Value = row.GetCell(2).ToString();
                            dgv.Rows[i - 1].Cells[2].Value = row.GetCell(3).ToString();
                            dgv.Rows[i - 1].Cells[3].Value = row.GetCell(12).ToString();
                            dgv.Rows[i - 1].Cells[4].Value = row.GetCell(10).ToString();
                            dgv.Rows[i - 1].Cells[5].Value = row.GetCell(11).ToString();
                            dgv.Rows[i - 1].Cells[6].Value = row.GetCell(7).ToString();
                            dgv.Rows[i - 1].Cells[7].Value = row.GetCell(15).ToString();
                        }
                        else if (searchIndex == 0)
                        {//搜索IC卡号
                            if (row.GetCell(1).ToString() == searchData.ToString())
                            {
                               // string value = row.GetCell(0).ToString();
                                dgv.Rows.Add();
                                dgv.Rows[r].Cells[0].Value = row.GetCell(1).ToString();
                                dgv.Rows[r].Cells[1].Value = row.GetCell(2).ToString();
                                dgv.Rows[r].Cells[2].Value = row.GetCell(3).ToString();
                                dgv.Rows[r].Cells[3].Value = row.GetCell(12).ToString();
                                dgv.Rows[r].Cells[4].Value = row.GetCell(10).ToString();
                                dgv.Rows[r].Cells[5].Value = row.GetCell(11).ToString();
                                dgv.Rows[r].Cells[6].Value = row.GetCell(7).ToString();
                                dgv.Rows[r].Cells[7].Value = row.GetCell(15).ToString();
                                r++;
                            }
                        }
                        else if (searchIndex == 1)
                        {//搜索用户名
                            if (row.GetCell(2).ToString() == searchData.ToString())
                            {
                               // string value = row.GetCell(0).ToString();
                                dgv.Rows.Add();
                                dgv.Rows[r].Cells[0].Value = row.GetCell(1).ToString();
                                dgv.Rows[r].Cells[1].Value = row.GetCell(2).ToString();
                                dgv.Rows[r].Cells[2].Value = row.GetCell(3).ToString();
                                dgv.Rows[r].Cells[3].Value = row.GetCell(12).ToString();
                                dgv.Rows[r].Cells[4].Value = row.GetCell(10).ToString();
                                dgv.Rows[r].Cells[5].Value = row.GetCell(11).ToString();
                                dgv.Rows[r].Cells[6].Value = row.GetCell(7).ToString();
                                dgv.Rows[r].Cells[7].Value = row.GetCell(15).ToString();
                                r++;
                            }
                        }
                        else if (searchIndex == 2)
                        {//搜索发卡时间 
                            string[] sss=null;
                            sss = row.GetCell(12).ToString().Split(new string[] { " " }, StringSplitOptions.None);
                            if (sss[0] == searchData.ToString())
                            {
                               // string value = row.GetCell(0).ToString();
                                dgv.Rows.Add();
                                dgv.Rows[r].Cells[0].Value = row.GetCell(1).ToString();
                                dgv.Rows[r].Cells[1].Value = row.GetCell(2).ToString();
                                dgv.Rows[r].Cells[2].Value = row.GetCell(3).ToString();
                                dgv.Rows[r].Cells[3].Value = row.GetCell(12).ToString();
                                dgv.Rows[r].Cells[4].Value = row.GetCell(10).ToString();
                                dgv.Rows[r].Cells[5].Value = row.GetCell(11).ToString();
                                dgv.Rows[r].Cells[6].Value = row.GetCell(7).ToString();
                                dgv.Rows[r].Cells[7].Value = row.GetCell(15).ToString();
                                r++;
                            }                        
                        }

                    }
                }
            }
            catch (Exception e)
            {
                //只在Debug模式下才输出
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// 读取某一单元格数据
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        public object GetCellValue(ICell cell)
        {
            object value = null;
            try
            {
                if (cell.CellType != CellType.Blank)
                {
                    switch (cell.CellType)
                    {
                        case CellType.Numeric:
                            // Date comes here
                            if (DateUtil.IsCellDateFormatted(cell))
                            {
                                value = cell.DateCellValue;
                            }
                            else
                            {
                                // Numeric type
                                value = cell.NumericCellValue;
                            }
                            break;
                        case CellType.Boolean:
                            // Boolean type
                            value = cell.BooleanCellValue;
                            break;
                        case CellType.Formula:
                            value = cell.CellFormula;
                            break;
                        default:
                            // String type
                            value = cell.StringCellValue;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                value = "";
            }

            return value;
        }
        /// <summary>
        /// 向excl写入1行数据 写入到实时信息表
        /// </summary>
        /// <param name="filePath"></param>
        /// excl绝对地址（包含文件名和格式）
        /// <param name="index"></param>
        /// 从第index列开始写入
        /// <param name="card"></param>
        /// 写入内容为1张卡数据 
        /// <param name="sheetnum"></param> 
        /// 第几张表单 从0开始
        public static void ModifyACellToExcel(string filePath,int sheetnum,int rownum,int columnum,bool value)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);//读取流

            POIFSFileSystem ps = new POIFSFileSystem(fs);//需using NPOI.POIFS.FileSystem;
            IWorkbook workbook = new HSSFWorkbook(ps);
            ISheet sheet = workbook.GetSheetAt(sheetnum);//获取工作表
            IRow row = sheet.GetRow(0); //得到表头
            FileStream fout = new FileStream(filePath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);//写入流
            ICell cell = null;
            row = sheet.GetRow(rownum+1);  //读取当前行数据
            if (row != null)
            {
                cell = row.GetCell(columnum);
                SetCellValue(cell, value);
                sheet.AutoSizeColumn(columnum);//自动调整列宽
                cell = row.GetCell(16);
                SetCellValue(cell, DateTime.Now);
                sheet.AutoSizeColumn(16);
            }
            fout.Flush();
            workbook.Write(fout);//写入文件
            workbook = null;
            fout.Close();
        }

        /// <summary>
        /// 向excl写入1行数据 写入到写卡记录表
        /// </summary>
        /// <param name="filePath"></param>
        /// excl绝对地址（包含文件名和格式）
        /// <param name="index"></param>
        /// 从第index列开始写入
        /// <param name="card"></param>
        /// 写入内容为1张卡数据 
        /// <param name="sheetnum"></param> 
        /// 第几张表单 从0开始
        public static void UpdateExcl(string filePath,int sheetnum,int index,object[] card)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);//读取流

            POIFSFileSystem ps=new POIFSFileSystem(fs);//需using NPOI.POIFS.FileSystem;
            IWorkbook workbook = new HSSFWorkbook(ps);
            ISheet sheet = workbook.GetSheetAt(sheetnum);//获取工作表
            IRow row = sheet.GetRow(0); //得到表头
            FileStream fout = new FileStream(filePath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);//写入流
            row = sheet.CreateRow((sheet.LastRowNum + 1));//在工作表中添加一行

            ICell cell = null;
            cell = row.CreateCell(0);
            cell.SetCellValue(sheet.LastRowNum);//赋值
            for (int i = 0; i < card.Length-1; i++)
            {
                cell = row.CreateCell(i+index);
                SetCellValue(cell,card[i]);
                sheet.AutoSizeColumn(i + index);//自动调整列宽
            }
                
            fout.Flush();
            workbook.Write(fout);//写入文件
            workbook = null;
            fout.Close();
         }
        /// <summary>
        /// 向EXCL里写入一行数据 写入到实时信息表 每个卡号只有一行有效数据
        /// </summary>
        /// <param name="filePath"></param>
        /// 要写入文件的绝对路径含文件名和格式
        /// <param name="sheetnum"></param>
        /// 数据表单号 从0开始
        /// <param name="index"></param>
        /// 从第index列数据开始插入
        /// <param name="card"></param>
        /// 需要写入的数据
        public static void UpdatetoExcl(string filePath, int sheetnum, int index, object[] card)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);//读取流

            POIFSFileSystem ps = new POIFSFileSystem(fs);//需using NPOI.POIFS.FileSystem;
            IWorkbook workbook = new HSSFWorkbook(ps);
            ISheet sheet = workbook.GetSheetAt(sheetnum);//获取工作表
            IRow row = sheet.GetRow(0); //得到表头
            FileStream fout = new FileStream(filePath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);//写入流
            ICell cell = null;
            bool have_same = false;
            for (int i = 1; i < sheet.LastRowNum+1; i++)
            {
                row = sheet.GetRow(i);  //读取当前行数据
                if (row != null)
                {                   
                    if (row.GetCell(1).ToString() == card[0].ToString())
                    {
                        for (int j = 0; j < card.Length; j++)
                        {
                            cell = row.GetCell(j + index);
                            SetCellValue(cell, card[j]);
                            sheet.AutoSizeColumn(j + index);//自动调整列宽
                        }
                        have_same = true;
                        break;
                    }
                }
            }
           if(!have_same)
           {
                have_same = false;
                row = sheet.CreateRow((sheet.LastRowNum + 1));//在工作表中添加一行
                cell = row.CreateCell(0);
                cell.SetCellValue(sheet.LastRowNum);//赋值
                for (int k = 0; k < card.Length ; k++)
                {
                    cell = row.CreateCell(k + index);
                    SetCellValue(cell, card[k]);
                    sheet.AutoSizeColumn(k + index);//自动调整列宽
                }
           }

           fout.Flush();
           workbook.Write(fout);//写入文件
           workbook = null;
           fout.Close();
        }

        /// <summary>
        /// 向EXCL文件写数据
        /// </summary>
        /// <param name="filePath"></param>
        public static void WriteToExcl(string filePath)
        {
            //创建工作薄  
            IWorkbook wb;
            string extension = System.IO.Path.GetExtension(filePath);
            //根据指定的文件格式创建对应的类
            if (extension.Equals(".xls"))
            {
                wb = new HSSFWorkbook();
            }
            else
            {
                wb = new XSSFWorkbook();
            }

            ICellStyle style1 = wb.CreateCellStyle();//样式
            style1.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;//文字水平对齐方式
            style1.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;//文字垂直对齐方式
            //设置边框
            style1.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.WrapText = true;//自动换行

            ICellStyle style2 = wb.CreateCellStyle();//样式
            IFont font1 = wb.CreateFont();//字体
            font1.FontName = "楷体";
            font1.Color = HSSFColor.Red.Index;//字体颜色
            font1.Boldweight = (short)FontBoldWeight.Normal;//字体加粗样式
            style2.SetFont(font1);//样式里的字体设置具体的字体样式
            //设置背景色
            style2.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Yellow.Index;
            style2.FillPattern = FillPattern.SolidForeground;
            style2.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.Yellow.Index;
            style2.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;//文字水平对齐方式
            style2.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;//文字垂直对齐方式

            ICellStyle dateStyle = wb.CreateCellStyle();//样式
            dateStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;//文字水平对齐方式
            dateStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;//文字垂直对齐方式
            //设置数据显示格式
            IDataFormat dataFormatCustom = wb.CreateDataFormat();
            dateStyle.DataFormat = dataFormatCustom.GetFormat("yyyy-MM-dd HH:mm:ss");

            //创建一个表单
            ISheet sheet = wb.CreateSheet("Sheet0");
            //设置列宽
            int[] columnWidth = { 10, 10, 20, 10 };
            for (int i = 0; i < columnWidth.Length; i++)
            {
                //设置列宽度，256*字符数，因为单位是1/256个字符
                sheet.SetColumnWidth(i, 256 * columnWidth[i]);
            }

            //测试数据
            int rowCount = 3, columnCount = 4;
            object[,] data = {
		        {"列0", "列1", "列2", "列3"},
		        {"", 400, 5.2, 6.01},
		        {"", true, "2014-07-02", DateTime.Now}
		        //日期可以直接传字符串，NPOI会自动识别
		        //如果是DateTime类型，则要设置CellStyle.DataFormat，否则会显示为数字
	        };

            IRow row;
            ICell cell;

            for (int i = 0; i < rowCount; i++)
            {
                row = sheet.CreateRow(i);//创建第i行
                for (int j = 0; j < columnCount; j++)
                {
                    cell = row.CreateCell(j);//创建第j列
                    cell.CellStyle = j % 2 == 0 ? style1 : style2;
                    //根据数据类型设置不同类型的cell
                    object obj = data[i, j];
                    SetCellValue(cell, data[i, j]);
                    //如果是日期，则设置日期显示的格式
                    if (obj.GetType() == typeof(DateTime))
                    {
                        cell.CellStyle = dateStyle;
                    }
                    //如果要根据内容自动调整列宽，需要先setCellValue再调用
                    //sheet.AutoSizeColumn(j);
                }
            }

            //合并单元格，如果要合并的单元格中都有数据，只会保留左上角的
            //CellRangeAddress(0, 2, 0, 0)，合并0-2行，0-0列的单元格
            CellRangeAddress region = new CellRangeAddress(0, 2, 0, 0);
            sheet.AddMergedRegion(region);

            try
            {
                FileStream fs = File.OpenWrite(filePath);
                wb.Write(fs);//向打开的这个Excel文件中写入表单并保存。  
                fs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// 向某一单元格写数据
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="obj"></param>
        public static void SetCellValue(ICell cell, object obj)
        {
            if (obj.GetType() == typeof(int))
            {
                cell.SetCellValue((int)obj);
            }
            else if (obj.GetType() == typeof(double))
            {
                cell.SetCellValue((double)obj);
            }
            else if (obj.GetType() == typeof(IRichTextString))
            {
                cell.SetCellValue((IRichTextString)obj);
            }
            else if (obj.GetType() == typeof(string))
            {
                cell.SetCellValue(obj.ToString());
            }
            else if (obj.GetType() == typeof(DateTime))
            {
                cell.SetCellValue((DateTime)obj);
            }
            else if (obj.GetType() == typeof(bool))
            {
                cell.SetCellValue((bool)obj);
            }
            else
            {
                cell.SetCellValue(obj.ToString());
            }
        }




        /// <summary>
        /// Excel导入成Datable
        /// </summary>
        /// <param name="file"></param>
        ///需要导出数据的绝对路径含文件名及格式后缀
        ///<param name="sheetnum"></param> 
        /// 需要导出数据表的表单号 从0开始
        /// <returns></returns>
        /// 
        public static DataTable ExcelToTable(string file,int sheetnum)
        {
            DataTable dt = new DataTable();
            IWorkbook workbook;
            string fileExt = Path.GetExtension(file).ToLower();
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                //XSSFWorkbook 适用XLSX格式，HSSFWorkbook 适用XLS格式
                if (fileExt == ".xlsx") { workbook = new XSSFWorkbook(fs); } else if (fileExt == ".xls") { workbook = new HSSFWorkbook(fs); } else { workbook = null; }
                if (workbook == null) { return null; }
                ISheet sheet = workbook.GetSheetAt(sheetnum);

                //表头  
                IRow header = sheet.GetRow(sheet.FirstRowNum);
                List<int> columns = new List<int>();
                for (int i = 0; i < header.LastCellNum; i++)
                {
                    object obj = GetValueType(header.GetCell(i));
                    if (obj == null || obj.ToString() == string.Empty)
                    {
                        dt.Columns.Add(new DataColumn("Columns" + i.ToString()));
                    }
                    else
                        dt.Columns.Add(new DataColumn(obj.ToString()));
                    columns.Add(i);
                }
                //数据  
                for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                {
                    DataRow dr = dt.NewRow();
                    bool hasValue = false;
                    foreach (int j in columns)
                    {
                        dr[j] = GetValueType(sheet.GetRow(i).GetCell(j));
                        if (dr[j] != null && dr[j].ToString() != string.Empty)
                        {
                            hasValue = true;
                        }
                    }
                    if (hasValue)
                    {
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// Datable导出成Excel
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="file"></param>
        public static void TableToExcel(DataTable dt, string file)
        {
            IWorkbook workbook;
            string fileExt = Path.GetExtension(file).ToLower();
            if (fileExt == ".xlsx") { workbook = new XSSFWorkbook(); } else if (fileExt == ".xls") { workbook = new HSSFWorkbook(); } else { workbook = null; }
            if (workbook == null) { return; }
            ISheet sheet = string.IsNullOrEmpty(dt.TableName) ? workbook.CreateSheet("Sheet1") : workbook.CreateSheet(dt.TableName);

            //表头  
            IRow row = sheet.CreateRow(0);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                ICell cell = row.CreateCell(i);
                cell.SetCellValue(dt.Columns[i].ColumnName);
            }

            //数据  
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                IRow row1 = sheet.CreateRow(i + 1);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ICell cell = row1.CreateCell(j);
                    cell.SetCellValue(dt.Rows[i][j].ToString());
                }
            }

            //转为字节数组  
            MemoryStream stream = new MemoryStream();
            workbook.Write(stream);
            var buf = stream.ToArray();

            //保存为Excel文件  
            using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                fs.Write(buf, 0, buf.Length);
                fs.Flush();
            }
        }

        /// <summary>
        /// 获取单元格类型
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        private static object GetValueType(ICell cell)
        {
            if (cell == null)
                return null;
            switch (cell.CellType)
            {
                case CellType.Blank: //BLANK:  
                    return null;
                case CellType.Boolean: //BOOLEAN:  
                    return cell.BooleanCellValue;
                case CellType.Numeric: //NUMERIC:  
                    return cell.NumericCellValue;
                case CellType.String: //STRING:  
                    return cell.StringCellValue;
                case CellType.Error: //ERROR:  
                    return cell.ErrorCellValue;
                case CellType.Formula: //FORMULA:  
                default:
                    return "=" + cell.CellFormula;
            }
        }

        
    }//end
}
