using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium196 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium196";
        public override double halfLife { get; } = 6624.0d;
        public override double atomicWeight { get; } = 195.97048d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4328900.0), new Mercury196() } },

        };
    }
}
    
    