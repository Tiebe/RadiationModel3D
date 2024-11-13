
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen18 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen18";
        public override double halfLife { get; } = 0.6192d;
        public override double atomicWeight { get; } = 18.01408d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Oxygen18() } },

        };
    }
}
    
    