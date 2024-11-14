using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum192 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum192";
        public override double halfLife { get; } = 2.2d;
        public override double atomicWeight { get; } = 191.9752d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6520000.0), new Tungsten192() } },

        };
    }
}
    
    