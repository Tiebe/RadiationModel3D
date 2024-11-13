
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium56 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium56";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 56.00857d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    