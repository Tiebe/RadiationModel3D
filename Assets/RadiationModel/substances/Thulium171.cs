
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium171";
        public override double halfLife { get; } = 60589347.84d;
        public override double atomicWeight { get; } = 170.93644d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium171() } },

        };
    }
}
    
    