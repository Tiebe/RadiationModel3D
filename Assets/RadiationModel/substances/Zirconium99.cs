using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium99";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 98.91667d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4718000.0), new Niobium99() } },

        };
    }
}
    
    