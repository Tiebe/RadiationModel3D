using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium252m : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium252m";
        public override double halfLife { get; } = 0.1091d;
        public override double atomicWeight { get; } = 252.09031d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00099, 1254000.0), new Nobelium252() } },

        };
    }
}
    
    