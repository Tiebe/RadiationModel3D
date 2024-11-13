
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon201 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon201";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 200.99559d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    