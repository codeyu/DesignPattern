namespace DesignPatternLib.Observer
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    interface IInvestor
    {
        void Update(object sender, ChangeEventArgs e);
    }
}