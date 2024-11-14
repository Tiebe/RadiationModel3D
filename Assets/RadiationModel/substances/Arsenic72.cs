using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic72 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic72";
        public override double halfLife { get; } = 93600.0d;
        public override double atomicWeight { get; } = 71.92675d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4355910.0), new Germanium72() } },

        };
    }
}
    
    