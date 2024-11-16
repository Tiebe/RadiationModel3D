using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium203 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium203";
        public override double halfLife { get; } = 2202.0d;
        public override double atomicWeight { get; } = 202.98142d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9989d, new List<RadioactiveSubstance> { new BetaParticle(1, 4214000.0), new Bismuth203() } },
            { 0.0011d, new List<RadioactiveSubstance> { new AlphaParticle(6516047.4), new Lead199() } },

        };
    }
}
    
    