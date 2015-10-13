using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegularExpressionTesting
{
    public partial class Form1 : Form
    {
        readonly SimpleMonitor _monitor = new SimpleMonitor();
        public Form1( )
        {
            InitializeComponent();
            RunRegularExpression();
            SetEscapedRegularExpression(regularExpressionControl.Text);
        }

        private void regularExpressionControl_TextChanged(object sender, EventArgs e)
        {
            _monitor.ActionIfNotBusy(RunCompleteRegularExpression);
        }

        private void RunCompleteRegularExpression()
        {
            RunRegularExpression();
            SetEscapedRegularExpression(regularExpressionControl.Text);
        }

        private void ContentChanged(object sender, EventArgs e)
        {
            RunRegularExpression();
        }

        private void RunRegularExpression( )
        {
            string message = null;
            try
            {
                var regExp = regularExpressionControl.Text;
                var testString = contentControl.Text;

                var reg = new System.Text.RegularExpressions.Regex(regExp, System.Text.RegularExpressions.RegexOptions.Multiline | System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Compiled);
                Match m = reg.Match(testString);
                if ( m.Success )
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("success");
                    sb.AppendFormat( "Value: {0}\r\n", m.Value);
                    if( m.Groups.Count > 0)
                    {
                        foreach (Group group in m.Groups)
	                    {
                            sb.AppendFormat( "Group: {0}\r\n", group.Value);
	                    }
                    }
                    message = sb.ToString();
                }
                else
                {
                    message = "no success";
                }
            }
            catch ( Exception exc )
            {
                //swallow
                message = "Exception \r\n" + exc.Message;
            }
            finally
            {
                try
                {
                    resultControl.Text = message;
                }
                catch ( Exception )
                {
                    //swallow
                }
            }
        }

        private void escapedRegularExpressionControl_TextChanged(object sender, EventArgs e)
        {
            _monitor.ActionIfNotBusy(RunCompleteEscapedRegularExpression);
        }

        private void RunCompleteEscapedRegularExpression()
        {
            SetNormalRegularExpression(escapedRegularExpressionControl.Text);
            RunRegularExpression();
        }

        private void SetEscapedRegularExpression(string text)
        {
            escapedRegularExpressionControl.Text = text.Replace("\\", "\\\\").Replace("\"", "\\\"");
        }

        private void SetNormalRegularExpression(string text)
        {
            regularExpressionControl.Text = text.Replace("\\\"", "\"").Replace("\\\\", "\\");
        }
    }
}
