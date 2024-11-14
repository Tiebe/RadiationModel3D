using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium252p : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium252p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 252.08647d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    