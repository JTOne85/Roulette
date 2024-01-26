using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette.Test
{
    public partial class MockRouletteDbContext : Component
    {
        public MockRouletteDbContext()
        {
            InitializeComponent();
        }

        public MockRouletteDbContext(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
