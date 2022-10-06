using IronPython.Hosting;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var eng = IronPython.Hosting.Python.CreateEngine();
            var scope = eng.CreateScope();
            var paths = eng.GetSearchPaths();

            // Python 경로 설정
            paths.Add(@"C:\Users\fffig\anaconda3\envs\mp");
            paths.Add(@"C:\Users\fffig\anaconda3\envs\mp\DLLs");
            paths.Add(@"C:\Users\fffig\anaconda3\envs\mp\Lib");
            paths.Add(@"C:\Users\fffig\anaconda3\envs\mp\Lib\site-packages");
          //  paths.Add(@"C:\Users\fffig\anaconda3\envs\mp\Lib\site-packages\tensorflow_datasets");
          //  paths.Add(@"C:\Users\fffig\anaconda3\envs\mp\Lib\site-packages\tensorflow_metadata");
          //  paths.Add(@"C:\Users\fffig\anaconda3\envs\mp\Lib\site-packages\tensorflow_serving");

            // 실행 시킬 Python 파일 경로
            var source = eng.CreateScriptSourceFromFile(@"C:\mes\mp\test\ConsoleApp1\WindowsFormsApp1\bin\Debug\mycode.py");

            // 파이썬 파일 실행
            source.Execute(scope);

            var getPythonFuncResult = scope.GetVariable<Func<int, int, int>>("sum");
            textBox1.Text = $"def 실행 테스트 : " + getPythonFuncResult(1, 2);

        }
    }
}
