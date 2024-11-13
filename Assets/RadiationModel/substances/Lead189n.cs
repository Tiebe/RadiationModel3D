
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead189n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead189n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 188.9835d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Lead189() } },

        };
    }
}
    
    