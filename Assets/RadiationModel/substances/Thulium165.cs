
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium165";
        public override double halfLife { get; } = 108216.0d;
        public override double atomicWeight { get; } = 164.93244d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium165() } },

        };
    }
}
    
    