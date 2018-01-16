using System;
using System.Windows.Forms;

namespace Magma
{
    public class ParameterControl
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public Type DataType { get; set; }

        public ParameterControlType ControlType { get; set; }

        public bool IsRequired { get; set; }

        public string DefaultValue { get; set; }

        public string HelpText { get; set; }

        public Control Control { get; set; }
    }
}
