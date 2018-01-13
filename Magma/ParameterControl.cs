using System;

namespace Magma
{
    public class ParameterControl
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public ParameterDataType DataType { get; set; }

        public ParameterControlType ControlType { get; set; }

        public bool IsRequired { get; set; }

        public string HelpText { get; set; }
    }
}
