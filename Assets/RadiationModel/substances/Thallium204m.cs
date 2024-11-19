using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium204m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium204m";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 203.97505d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00112, 1104100.0), new Thallium204() } },

        };
    }
}
    
    