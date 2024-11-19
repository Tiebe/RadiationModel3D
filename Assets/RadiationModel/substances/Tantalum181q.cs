using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum181q : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum181q";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 180.94959d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1483400.00001, 0.00084)), new Tantalum181() } },

        };
    }
}
    
    