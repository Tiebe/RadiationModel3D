using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium164";
        public override double halfLife { get; } = 1728.0d;
        public override double atomicWeight { get; } = 163.93024d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.61d, new List<RadioactiveSubstance> { new Dysprosium164() } },
            { 0.39d, new List<RadioactiveSubstance> { new BetaParticle(1, 987100.0), new Dysprosium164() } },

        };
    }
}
    
    