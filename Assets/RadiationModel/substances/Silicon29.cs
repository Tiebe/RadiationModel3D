
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon29 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon29";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 28.97649d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    