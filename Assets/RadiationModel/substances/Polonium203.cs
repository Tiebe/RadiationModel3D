
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

            { 0.9989d, new List<RadioactiveSubstance> { new BetaParticle(), new Bismuth203() } },

            { 0.0011d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead199() } },

        };
    }
}
    
    