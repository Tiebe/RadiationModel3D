
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten186 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten186";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 185.95437d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    