
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium196 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium196";
        public override double halfLife { get; } = 52.0d;
        public override double atomicWeight { get; } = 195.96839d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum196() } },

        };
    }
}
    
    