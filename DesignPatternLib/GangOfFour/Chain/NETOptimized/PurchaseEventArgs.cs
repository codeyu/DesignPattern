using System;

namespace DesignPatternLib.Chain
{
    // Purchase event argument holds purchase info
    public class PurchaseEventArgs : EventArgs
    {
        internal Purchase Purchase { get; set; }
    }
}