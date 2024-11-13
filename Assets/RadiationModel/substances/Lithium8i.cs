
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lithium8i : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium8i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 8.0341d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    