
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium55 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium55";
        public override double halfLife { get; } = 209.82d;
        public override double atomicWeight { get; } = 54.94084d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Manganese55() } },

        };
    }
}
    
    