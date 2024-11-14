using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium82";
        public override double halfLife { get; } = 75.45d;
        public override double atomicWeight { get; } = 81.91821d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4403795.0), new Krypton82() } },

        };
    }
}
    
    