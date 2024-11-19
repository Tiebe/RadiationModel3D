using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel65m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel65m";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 64.93015d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01956, 63400.0), new Nickel65() } },

        };
    }
}
    
    