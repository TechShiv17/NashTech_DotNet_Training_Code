namespace Problem5
{
    public class WorkflowEngine
    {
        public void Run(IActivity[] activities)
        {
            foreach (var activity in activities)
            {
                activity.Execute();
            }
        }
    }
}
