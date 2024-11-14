using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon26i : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon26i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 26.00631d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    