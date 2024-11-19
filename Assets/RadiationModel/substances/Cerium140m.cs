using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium140m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium140m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 139.90771d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2107900.00001, 0.00059)), new Cerium140() } },

        };
    }
}
    
    