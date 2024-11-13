
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium5 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium5";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 5.03987d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    