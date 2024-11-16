using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium249";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 249.07848d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    