
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium126";
        public override double halfLife { get; } = 1.53d;
        public override double atomicWeight { get; } = 125.91647d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin126() } },

        };
    }
}
    
    