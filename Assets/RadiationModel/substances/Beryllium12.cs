
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium12 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium12";
        public override double halfLife { get; } = 0.02146d;
        public override double atomicWeight { get; } = 12.02692d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Boron12() } },

        };
    }
}
    
    