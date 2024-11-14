using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine17i : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine17i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 17.01411d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    