
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium58 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium58";
        public override double halfLife { get; } = 0.004d;
        public override double atomicWeight { get; } = 57.99836d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    