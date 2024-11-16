using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine120n : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine120n";
        public override double halfLife { get; } = 3180.0d;
        public override double atomicWeight { get; } = 119.91043d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5932200.0), new Tellurium120() } },

        };
    }
}
    
    