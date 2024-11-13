
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium190 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium190";
        public override double halfLife { get; } = 156.0d;
        public override double atomicWeight { get; } = 189.97384d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury190() } },

        };
    }
}
    
    