
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium45m : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium45m";
        public override double halfLife { get; } = 8e-05d;
        public override double atomicWeight { get; } = 44.97917d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Chromium45() } },

        };
    }
}
    
    