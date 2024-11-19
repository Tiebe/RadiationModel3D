using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium259 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium259";
        public override double halfLife { get; } = 2.63d;
        public override double atomicWeight { get; } = 259.1056d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.85d, new List<RadioactiveSubstance> { new AlphaParticle(10155002.09), new Nobelium255() } },
            { 0.15d, new List<RadioactiveSubstance> { new BetaParticle(1, 2520000.0), new Lawrencium259() } },
            { 0.03d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    