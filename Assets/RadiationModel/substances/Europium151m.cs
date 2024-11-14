using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium151m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium151m";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 150.92007d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00632), new Europium151() } },

        };
    }
}
    
    