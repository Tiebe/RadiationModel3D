using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium155";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 154.92263d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    