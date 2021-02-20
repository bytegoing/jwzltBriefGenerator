using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace jwzltBriefGenerator
{
    class DataHelper
    {
        public static string convertNumberToExcelColumn(int i, bool ifFromZero = true)
        {
            if (!ifFromZero) i = i - 1;
            if (i < 0)
            {
                //throw new Exception("Invalid parameter");
                return "";
            }
            string column = string.Empty;
            do
            {
                if (column.Length > 0)
                {
                    i--;
                }
                column = ((char)(i % 26 + (int)'A')).ToString() + column;
                i = (int)((i - i % 26) / 26);
            } while (i > 0);
            return column;
        }

        public static DataTable XlsxToDataTable(string file, int sheetNumber)
        {
            DataTable dt = new DataTable();
            IWorkbook workbook;
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                workbook = new XSSFWorkbook(fs);
                ISheet sheet = workbook.GetSheetAt(sheetNumber);
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
                //for (int i = sheet.FirstRowNum + 1; i <= to + 1; i++)
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

        public static DataTable GetBriefData(string username, string filename, int department, object departmentObj, string fromStr, string toStr, int sheetRange = 0)
        {
            if (username == "")
            {
                throw new Exception("请填写操作人姓名");
            }
            if (departmentObj == null || departmentObj.ToString() == "" || department == -1)
            {
                throw new Exception("请选择院系！");
            }
            string departmentStr = departmentObj.ToString();
            int from = 0; //注意，这里第1条为0。
            int to = -1;
            if (fromStr != "")
            {
                if (!Int32.TryParse(fromStr, out from))
                {
                    throw new Exception("请输入正确起始条数！");
                }
                from--;
            }
            if (toStr != "")
            {
                if (!Int32.TryParse(toStr, out to))
                {
                    throw new Exception("请输入正确的终止条数！");
                }
                to--;
            }
            DataTable dt = DataHelper.XlsxToDataTable(filename, department);
            if (dt == null || dt.Rows.Count <= 0)
            {
                throw new Exception("简报数据文件为空！请检查参数、选择的文件或院系是否正确！");
            }
            //数据合规性检查与裁剪数据
            if (to == -1) to = dt.Rows.Count - 1;
            //数据合规性检查
            if (from < 0)
            {
                throw new Exception("起始条数太小!");
            }
            if (to >= dt.Rows.Count)
            {
                throw new Exception("终止条数太大!");
            }
            if (from > to)
            {
                throw new Exception("起始条数大于终止条数!");
            }
            //选择合适的行数
            DataTable dtTmp = dt.Clone();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i >= from && i <= to) dtTmp.ImportRow(dt.Rows[i]);
            }
            dt = dtTmp;
            return dtTmp;
        }

        private static object GetValueType(ICell cell) //获取单元格类型
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

        public static void DataTableToXlsx(DataTable dt, string file, int sheetId, object sheetNameObj)
        {
            if (sheetNameObj == null || sheetNameObj.ToString() == "")
            {
                throw new Exception("请选择院系！");
            }
            string sheetName = sheetNameObj.ToString();
            bool ifCreate = false;
            IWorkbook wk = null;
            ISheet sheet = null;
            IRow row = null;//数据行
            ICell cell = null;//数据行中的某列
            if (File.Exists(file))
            {
                FileStream fs = File.OpenRead(file);
                wk = new XSSFWorkbook(fs);
                fs.Close();
                if (wk.NumberOfSheets <= sheetId)
                {
                    wk = new XSSFWorkbook();
                    sheet = wk.CreateSheet(sheetName);
                    ifCreate = true;
                }
                else
                {
                    sheet = wk.GetSheetAt(sheetId);
                }
            }
            else
            {
                wk = new XSSFWorkbook();
                sheet = wk.CreateSheet(sheetName);
                ifCreate = true;
            }

            row = sheet.GetRow(0);
            if (row == null) row = sheet.CreateRow(0);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                cell = row.GetCell(i);
                if (cell == null)
                {
                    cell = row.CreateCell(i, CellType.String);
                }
                cell.SetCellValue(dt.Columns[i].ColumnName);
            }

            for (int i = 1; i <= dt.Rows.Count; i++)
            {
                row = sheet.GetRow(i);
                if (row == null) row = sheet.CreateRow(i);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    cell = row.GetCell(j);
                    if (cell == null)
                    {
                        cell = row.CreateCell(j, CellType.String);
                    }
                    cell.SetCellValue(dt.Rows[i - 1][j].ToString());
                }
            }

            //转为字节数组
            MemoryStream stream = new MemoryStream();
            wk.Write(stream);
            var buf = stream.ToArray();

            //保存为Excel文件  
            using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                fs.Write(buf, 0, buf.Length);
                fs.Flush();
            }

            if (ifCreate) MsgBox.ShowInfo("保存成功!");
        }

        public static DataTable CsvToDataTable(string filePath, int contentStartFrom = 0)
        {
            DataTable dt = new DataTable();
            String csvSplitBy = "(?<=^|,)(\"(?:[^\"]|\"\")*\"|[^,]*)";
            StreamReader reader = new StreamReader(filePath, System.Text.Encoding.UTF8, false);
            int i = 0, m = 0;
            reader.Peek();
            while (reader.Peek() > 0)
            {
                m = m + 1;
                string str = reader.ReadLine();
                if (m >= contentStartFrom + 1)
                {
                    if (m == contentStartFrom + 1) //如果是字段行，则自动加入字段。
                    {
                        MatchCollection mcs = Regex.Matches(str, csvSplitBy);
                        foreach (Match mc in mcs)
                        {
                            if(mc.Value != "") dt.Columns.Add(mc.Value.Replace("\"", "")); //增加列标题
                        }

                    }
                    else
                    {
                        MatchCollection mcs = Regex.Matches(str, "(?<=^|,)(\"(?:[^\"]|\"\")*\"|[^,]*)");
                        i = 0;
                        System.Data.DataRow dr = dt.NewRow();
                        foreach (Match mc in mcs)
                        {
                            if(i < dt.Columns.Count) dr[i] = mc.Value.Replace("\"", "");
                            i++;
                        }
                        dt.Rows.Add(dr);  //DataTable 增加一行     
                    }

                }
            }
            reader.Close();
            return dt;
        }

        public static void DataTableToCsv(DataTable dt, string strPath)
        {
            if (File.Exists(strPath))
            {
                File.Delete(strPath);
            }
            //先打印标头
            StringBuilder strColu = new StringBuilder();
            StringBuilder strValue = new StringBuilder();
            int i = 0;
            StreamWriter sw = new StreamWriter(new FileStream(strPath, FileMode.CreateNew), Encoding.GetEncoding("UTF-8"));
            for (i = 0; i <= dt.Columns.Count - 1; i++)
            {
                strColu.Append(dt.Columns[i].ColumnName);
                strColu.Append(",");
            }
            strColu.Remove(strColu.Length - 1, 1);//移出掉最后一个,字符
            sw.WriteLine(strColu);
            foreach (DataRow dr in dt.Rows)
            {
                strValue.Remove(0, strValue.Length);//移出
                for (i = 0; i <= dt.Columns.Count - 1; i++)
                {
                    strValue.Append(dr[i].ToString());
                    strValue.Append(",");
                }
                strValue.Remove(strValue.Length - 1, 1);//移出掉最后一个,字符
                sw.WriteLine(strValue);
            }
            sw.Close();
        }
    }
}
