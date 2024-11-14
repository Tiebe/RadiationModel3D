using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium260";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 260.10551d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new List<RadioactiveSubstance> { new AlphaParticle(9415047.4), new Mendelevium256() } },
            { 0.2d, new List<RadioactiveSubstance> { new BetaParticle(1, 2670000.0), new Nobelium260() } },

        };
    }
}
    
    