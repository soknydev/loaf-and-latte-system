using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loaf_and_latte_system.Components.Button
{
    public partial class ButtonComponent2: Component
    {    
        public ButtonComponent2()
        {
            InitializeComponent();
        }

        public ButtonComponent2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
