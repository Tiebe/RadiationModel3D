using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten185m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten185m";
        public override double halfLife { get; } = 95.82d;
        public override double atomicWeight { get; } = 184.95363d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((197400.00001, 0.00628)), new Tungsten185() } },

        };
    }
}
    
    