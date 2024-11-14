using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium273p : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium273p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 273.14168d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    