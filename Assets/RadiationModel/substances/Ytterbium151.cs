
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium151";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 150.9554d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thulium151() } },

        };
    }
}
    
    