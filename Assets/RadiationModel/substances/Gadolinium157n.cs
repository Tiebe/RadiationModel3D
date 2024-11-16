using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium157n : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium157n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 156.92443d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00291), new Gadolinium157() } },

        };
    }
}
    
    