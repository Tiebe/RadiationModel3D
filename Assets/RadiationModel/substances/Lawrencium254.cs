using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium254";
        public override double halfLife { get; } = 12.0d;
        public override double atomicWeight { get; } = 254.09624d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7170000000000001d, new List<RadioactiveSubstance> { new AlphaParticle(9845047.4), new Mendelevium250() } },
            { 0.28300000000000003d, new List<RadioactiveSubstance> { new BetaParticle(1, 4927000.0), new Nobelium254() } },
            { 0.001d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    