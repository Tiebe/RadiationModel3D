
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury174 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury174";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 173.99287d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Platinum170() } },

        };
    }
}
    
    