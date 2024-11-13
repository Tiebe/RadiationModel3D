
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium165";
        public override double halfLife { get; } = 8395.2d;
        public override double atomicWeight { get; } = 164.93171d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium165() } },

        };
    }
}
    
    