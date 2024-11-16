using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium92";
        public override double halfLife { get; } = 1095026234400000.1d;
        public override double atomicWeight { get; } = 91.90719d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2005720.0), new Zirconium92() } },

        };
    }
}
    
    