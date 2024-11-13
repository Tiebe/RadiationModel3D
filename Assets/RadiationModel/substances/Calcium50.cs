
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium50 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium50";
        public override double halfLife { get; } = 13.45d;
        public override double atomicWeight { get; } = 49.9575d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Scandium50() } },

        };
    }
}
    
    