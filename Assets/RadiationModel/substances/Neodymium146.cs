
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium146";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 145.91312d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    