using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium256";
        public override double halfLife { get; } = 1.7d;
        public override double atomicWeight { get; } = 256.10768d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new List<RadioactiveSubstance> { new AlphaParticle(10355047.4), new Lawrencium252() } },
            { 0.3d, new List<RadioactiveSubstance> { new BetaParticle(1, 6078000.0), new Rutherfordium256() } },

        };
    }
}
    
    