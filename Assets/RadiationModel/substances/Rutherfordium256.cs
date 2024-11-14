using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium256";
        public override double halfLife { get; } = 0.0066d;
        public override double atomicWeight { get; } = 256.10115d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9969d, new List<RadioactiveSubstance> {  } },
            { 0.0031d, new List<RadioactiveSubstance> { new AlphaParticle(9946047.4), new Nobelium252() } },

        };
    }
}
    
    