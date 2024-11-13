
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium107";
        public override double halfLife { get; } = 0.1457d;
        public override double atomicWeight { get; } = 106.94201d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Niobium107() } },

        };
    }
}
    
    