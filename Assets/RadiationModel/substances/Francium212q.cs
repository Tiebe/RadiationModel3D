using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium212q : RadioactiveSubstance
    {
        public override string name { get; } = "Francium212q";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 212.00539d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00015, 8533000.0), new Francium212() } },

        };
    }
}
    
    