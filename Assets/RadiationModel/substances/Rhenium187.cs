
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium187 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium187";
        public override double halfLife { get; } = 1.3127692032e+18d;
        public override double atomicWeight { get; } = 186.95575d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium187() } },

            { 0.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Tantalum183() } },

        };
    }
}
    
    