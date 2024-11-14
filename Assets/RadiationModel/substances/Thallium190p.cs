using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium190p : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium190p";
        public override double halfLife { get; } = 0.06d;
        public override double atomicWeight { get; } = 189.97418d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00395), new Thallium190() } },

        };
    }
}
    
    