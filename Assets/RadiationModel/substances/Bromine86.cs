using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine86 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine86";
        public override double halfLife { get; } = 55.1d;
        public override double atomicWeight { get; } = 85.91881d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7633676.0), new Krypton86() } },

        };
    }
}
    
    