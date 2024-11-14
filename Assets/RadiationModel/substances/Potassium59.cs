using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium59 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium59";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 59.03086d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    