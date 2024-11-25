using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium252m : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium252m";
        public override double halfLife { get; } = 0.109d;
        public override double atomicWeight { get; } = 252.09031d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nobelium252() } } },

        };
    }
}
    