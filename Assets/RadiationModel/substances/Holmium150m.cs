
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium150m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium150m";
        public override double halfLife { get; } = 23.3d;
        public override double atomicWeight { get; } = 149.93349d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium150() } },

        };
    }
}
    
    