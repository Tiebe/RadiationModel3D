using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium255";
        public override double halfLife { get; } = 1.63d;
        public override double atomicWeight { get; } = 255.10127d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.528d, new List<RadioactiveSubstance> { new AlphaParticle(10075047.4), new Nobelium251() } },
            { 0.47200000000000003d, new List<RadioactiveSubstance> {  } },
            { 0.06d, new List<RadioactiveSubstance> { new BetaParticle(1, 4383000.0), new Lawrencium255() } },

        };
    }
}
    
    