
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium252";
        public override double halfLife { get; } = 108.0d;
        public override double atomicWeight { get; } = 252.08432d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    