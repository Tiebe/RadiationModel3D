
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium165m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium165m";
        public override double halfLife { get; } = 1.74d;
        public override double atomicWeight { get; } = 164.96712d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.87d, new List<RadioactiveSubstance> { new BetaParticle(), new Tungsten165() } },

            { 0.13d, new List<RadioactiveSubstance> { new AlphaParticle(), new Tantalum161() } },

        };
    }
}
    
    