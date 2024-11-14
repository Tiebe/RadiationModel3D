using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium141";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 140.90766d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    