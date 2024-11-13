
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium81 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium81";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 80.95023d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    