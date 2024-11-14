using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium102";
        public override double halfLife { get; } = 2.01d;
        public override double atomicWeight { get; } = 101.92315d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4717300.0), new Niobium102() } },

        };
    }
}
    
    