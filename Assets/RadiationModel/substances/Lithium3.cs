
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lithium3 : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium3";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 3.03078d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    