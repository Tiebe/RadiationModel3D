﻿namespace managers
{
    public class DefaultRadiationManager : Manager
    {
        protected override void StartOverride() {}

        protected override void RunExperiment()
        {
            counter.SetText(hits.ToString());
        }
    }
}