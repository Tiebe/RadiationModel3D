
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium172";
        public override double halfLife { get; } = 19.2d;
        public override double atomicWeight { get; } = 171.96002d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9881d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhenium172() } },

            { 0.011899999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(), new Tungsten168() } },

        };
    }
}
    
    