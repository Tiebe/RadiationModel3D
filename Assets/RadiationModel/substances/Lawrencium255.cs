using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium255";
        public override double halfLife { get; } = 31.1d;
        public override double atomicWeight { get; } = 255.09656d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.997d, new List<RadioactiveSubstance> { new AlphaParticle(9575047.4), new Mendelevium251() } },
            { 0.003d, new List<RadioactiveSubstance> { new BetaParticle(1, 3135000.0), new Nobelium255() } },

        };
    }
}
    
    