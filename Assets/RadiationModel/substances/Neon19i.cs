using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon19i : RadioactiveSubstance
    {
        public override string name { get; } = "Neon19i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 19.00993d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    