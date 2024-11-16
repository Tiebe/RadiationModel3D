using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium153n : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium153n";
        public override double halfLife { get; } = 8e-05d;
        public override double atomicWeight { get; } = 152.92194d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((171200.00002, 0.00724)), new Gadolinium153() } },

        };
    }
}
    
    