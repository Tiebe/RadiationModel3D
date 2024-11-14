using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium65 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium65";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 65.00559d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    