﻿using System.Collections.Generic;
using PudderVarsel.Data;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PudderVarsel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PudderDetaljer : Page
    {
        public IEnumerable<DagligPuddervarsel> LokasjonPudderDetaljer { get; set; }
        public PudderDetaljer()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            LokasjonPudderDetaljer = e.Parameter as IEnumerable<DagligPuddervarsel>;
        }

        
    }
}
