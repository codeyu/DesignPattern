using System;

namespace DesignPatternLib.Chain.NETOptimized
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    abstract class Approver
    {
        // Purchase event 
        public EventHandler<PurchaseEventArgs> Purchase;
        // Purchase event handler
        public abstract void PurchaseHandler(object sender, PurchaseEventArgs e);
        // Constructor
        public Approver()
        {
            Purchase += PurchaseHandler;
        }
        public void ProcessRequest(Purchase purchase)
        {
            OnPurchase(new PurchaseEventArgs { Purchase = purchase });
        }
        // Invoke the Purchase event
        public virtual void OnPurchase(PurchaseEventArgs e)
        {
            if (Purchase != null)
            {
                Purchase(this, e);
            }
        }
        // Sets or gets the next approver
        public Approver Successor { get; set; }
    }
}