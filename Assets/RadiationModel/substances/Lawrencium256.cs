using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium256";
        public override double halfLife { get; } = 27.9d;
        public override double atomicWeight { get; } = 256.0985d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.85d, new List<RadioactiveSubstance> { new AlphaParticle(9875047.4), new Mendelevium252() } },
            { 0.15d, new List<RadioactiveSubstance> { new BetaParticle(1, 3927000.0), new Nobelium256() } },
            { 0.0003d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    