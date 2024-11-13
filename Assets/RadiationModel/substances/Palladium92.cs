
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium92";
        public override double halfLife { get; } = 1.06d;
        public override double atomicWeight { get; } = 91.94119d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhodium92() } },

        };
    }
}
    
    