using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tennessine293 : RadioactiveSubstance
    {
        public override string name { get; } = "Tennessine293";
        public override double halfLife { get; } = 0.025d;
        public override double atomicWeight { get; } = 293.20873d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(12345047.4), new Moscovium289() } },

        };
    }
}
    
    