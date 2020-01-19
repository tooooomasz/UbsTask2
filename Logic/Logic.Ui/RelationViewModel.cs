namespace tomaszbaginski.UbsTask2.Logic.Ui
{
    public class RelationViewModel : IRelationViewModel
    {
        public RelationViewModel()
        {
        }

        public IMainViewModel ViewModel { get; set; }

        public IMainViewModel Get()
        {
            // setting some viewmodel properties
            return ViewModel;
        }
    }
}