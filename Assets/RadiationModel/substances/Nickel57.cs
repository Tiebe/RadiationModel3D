
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel57 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel57";
        public override double halfLife { get; } = 128160.0d;
        public override double atomicWeight { get; } = 56.93979d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt57() } },

        };
    }
}
    
    