
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium148m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium148m";
        public override double halfLife { get; } = 9.49d;
        public override double atomicWeight { get; } = 147.93801d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium148() } },

        };
    }
}
    
    