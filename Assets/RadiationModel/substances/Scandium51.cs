
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium51 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium51";
        public override double halfLife { get; } = 12.4d;
        public override double atomicWeight { get; } = 50.95357d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Titanium51() } },

        };
    }
}
    
    