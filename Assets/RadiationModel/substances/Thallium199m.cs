using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium199m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium199m";
        public override double halfLife { get; } = 0.0284d;
        public override double atomicWeight { get; } = 198.97068d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00166), new Thallium199() } },

        };
    }
}
    
    