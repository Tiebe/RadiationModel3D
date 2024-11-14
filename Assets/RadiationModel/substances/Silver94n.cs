using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver94n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver94n";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 93.95072d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9540000000000001d, new List<RadioactiveSubstance> { new BetaParticle(1, 20202000.0), new Palladium94() } },
            { 0.040999999999999995d, new List<RadioactiveSubstance> { new ProtonParticle(), new Palladium93() } },
            { 0.005d, new List<RadioactiveSubstance> { new ProtonParticle(), new Rhodium92() } },

        };
    }
}
    
    