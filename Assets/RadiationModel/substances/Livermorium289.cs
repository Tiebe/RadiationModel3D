using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Livermorium289 : RadioactiveSubstance
    {
        public override string name { get; } = "Livermorium289";
        public override double halfLife { get; } = 0.016d;
        public override double atomicWeight { get; } = 289.19803d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    