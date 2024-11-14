using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium82";
        public override double halfLife { get; } = 4.31d;
        public override double atomicWeight { get; } = 81.92977d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4689900.0), new Arsenic82() } },

        };
    }
}
    
    