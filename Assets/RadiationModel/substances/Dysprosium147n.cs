using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium147n : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium147n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 146.93474d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00036), new Dysprosium147() } },

        };
    }
}
    
    