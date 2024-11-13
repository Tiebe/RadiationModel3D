
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium250m : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium250m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 250.07836d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Berkelium250() } },

        };
    }
}
    
    