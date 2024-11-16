using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium237p : RadioactiveSubstance
    {
        public override string name { get; } = "Curium237p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 237.05309d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    