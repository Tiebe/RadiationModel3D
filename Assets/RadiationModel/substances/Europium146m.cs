using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium146m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium146m";
        public override double halfLife { get; } = 0.00023d;
        public override double atomicWeight { get; } = 145.91793d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00186, 666000.0), new Europium146() } },

        };
    }
}
    
    