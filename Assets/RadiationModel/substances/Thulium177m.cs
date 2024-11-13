
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium177m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium177m";
        public override double halfLife { get; } = 77.0d;
        public override double atomicWeight { get; } = 176.94904d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium177() } },

        };
    }
}
    
    