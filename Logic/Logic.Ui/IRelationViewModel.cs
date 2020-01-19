namespace tomaszbaginski.UbsTask2.Logic.Ui
{
    public interface IRelationViewModel
    {
        IMainViewModel ViewModel { get; set; }
        
        IMainViewModel Get();
    }
}