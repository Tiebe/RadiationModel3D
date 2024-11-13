
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine107 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine107";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 106.94693d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    