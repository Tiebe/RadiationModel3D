
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium146n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium146n";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 145.96713d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    