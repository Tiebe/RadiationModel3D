using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon30 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon30";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 29.97377d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    